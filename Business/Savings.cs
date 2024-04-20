namespace Business;

using System;
using System.Collections.ObjectModel;
using System.Linq;
using Entity;

public static class Savings
{
    public static Collection<int> SavingsId
    {
        get
        {
            using var context = new SavingsManagementContext();
            return [.. context.Savings
            .Where(s => s.CustomerId == CurrentUser.Id)
            .Select(s => s.Id)];
        }
    }

    public static Saving GetSaving(int savingId)
    {
        using var context = new SavingsManagementContext();
        return context.Savings.First(s => (s.Id == savingId) && (s.CustomerId == CurrentUser.Id));
    }

    public static void Deposit(SavingDepositInfo savingDepositInfo)
    {
        using var context = new SavingsManagementContext();

        decimal? currentBalance = context.CustomerAccounts.FirstOrDefault(c => c.Id == CurrentUser.Id)?.Balance;
        if (currentBalance is null || savingDepositInfo.Balance > currentBalance)
        {
            throw new Exception("The balance is not enough to deposit into a saving");
        }

        decimal? actualInterestRate = context.SavingInterestRates.FirstOrDefault(s => s.PeriodInMonths == savingDepositInfo.PeriodInMonths)?.AnnualInterestRate;
        if (actualInterestRate is null || savingDepositInfo.AnnualInterestRate != actualInterestRate)
        {
            throw new Exception("The interest rate may have been changed! Please try again!");
        }

        Saving saving = new Saving
        {
            CustomerId = CurrentUser.Id,
            Balance = savingDepositInfo.Balance,
            AnnualInterestRate = savingDepositInfo.AnnualInterestRate,
            PeriodInMonths = savingDepositInfo.PeriodInMonths,
        };
        context.Add(saving);
        context.SaveChanges();
    }

    public static void Withdraw(int savingId)
    {
        using var context = new SavingsManagementContext();
        context.Remove(context.Savings.First(s => s.Id == savingId));
        context.SaveChanges();
    }

    public static DateOnly GetMaturityDate(DateTimeOffset openDate, int periodInMonth)
    {
        return DateOnly.FromDateTime(openDate.LocalDateTime).AddMonths(periodInMonth);
    }

    public static SavingWithdrawInfo GetWithdrawInfo(int savingId)
    {
        using var context = new SavingsManagementContext();
        Saving saving = context.Savings.First(s => s.Id == savingId);
        SavingWithdrawInfo savingWithdrawInfo = new SavingWithdrawInfo
        {
            Id = saving.Id,
            Balance = saving.Balance,
            MaturityDate = GetMaturityDate(saving.OpenDate, saving.PeriodInMonths),
            AmountToGet = saving.Balance,
        };

        DateOnly openDate = DateOnly.FromDateTime(saving.OpenDate.LocalDateTime);
        DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);

        if (savingWithdrawInfo.MaturityDate <= currentDate)
        {
            savingWithdrawInfo.AmountToGet += saving.Balance * (saving.AnnualInterestRate * (saving.PeriodInMonths / 12.0M));
        }
        else if (openDate < currentDate)
        {
            decimal actualInterestRate = context.SavingInterestRates.Where(s => s.PeriodInMonths == 0).Select(s => s.AnnualInterestRate)
                .AsEnumerable().FirstOrDefault(decimal.Zero);
            savingWithdrawInfo.AmountToGet += saving.Balance * (actualInterestRate * (currentDate.DayNumber - openDate.DayNumber - 1) / 365.0M);
        }
        else
        {
            // No interest to add.
        }

        return savingWithdrawInfo;
    }
}
