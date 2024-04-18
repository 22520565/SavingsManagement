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

    public static void Deposit(int period, decimal interestRate, decimal amount)
    {
        using var context = new SavingsManagementContext();

        decimal? currentBalance = context.CustomerAccounts.FirstOrDefault(c => c.Id == CurrentUser.Id)?.Balance;
        if (currentBalance is null || amount > currentBalance)
        {
            throw new Exception("The balance is not enough to deposit into a saving");
        }

        decimal? actualInterestRate = context.SavingInterestRates.FirstOrDefault(s => s.PeriodInMonths == period)?.AnnualInterestRate;
        if (actualInterestRate is null || interestRate != actualInterestRate)
        {
            throw new Exception("The interest rate may have been changed! Please try again!");
        }

        Saving saving = new Saving
        {
            CustomerId = CurrentUser.Id,
            Balance = amount,
            AnnualInterestRate = interestRate,
            PeriodInMonths = period,
        };
        context.Add(saving);
        context.SaveChanges();
    }
}
