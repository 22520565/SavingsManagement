namespace Business;

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Entity;

public static class SavingInterestRates
{
    public static Collection<SavingInterestRate> Collection
    {
        get
        {
            using var context = new SavingsManagementContext();
            return [.. context.SavingInterestRates.Where(s => s.PeriodInMonths > 0)];
        }
    }

    public static ICollection<int> Periods
    {
        get
        {
            using var context = new SavingsManagementContext();
            return [.. context.SavingInterestRates.Select(s => s.PeriodInMonths).Where(p => p > 0)];
        }
    }

    public static decimal GetInterest(int period)
    {
        using var context = new SavingsManagementContext();
        return context.SavingInterestRates.Where(s => s.PeriodInMonths == period).Select(s => s.AnnualInterestRate).First();
    }
}
