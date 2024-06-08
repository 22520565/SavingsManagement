namespace Business;

using System.Linq;
using DataAccess;

public static class Configurations
{
    public static decimal MaxAmountOpeningSaving
    {
        get
        {
            using var context = new SavingsManagementContext();
            return context.Configurations.FirstOrDefault()?.MaxAmountOpeningSaving ?? decimal.Zero;
        }
    }

    public static decimal MinAmountOpeningSaving
    {
        get
        {
            using var context = new SavingsManagementContext();
            return context.Configurations.FirstOrDefault()?.MinAmountOpeningSaving ?? decimal.Zero;
        }
    }

    public static decimal MaxAmountDepositing
    {
        get
        {
            using var context = new SavingsManagementContext();
            return context.Configurations.FirstOrDefault()?.MaxAmountDepositing ?? decimal.Zero;
        }
    }

    public static decimal MinAmountDepositing
    {
        get
        {
            using var context = new SavingsManagementContext();
            return context.Configurations.FirstOrDefault()?.MinAmountDepositing ?? decimal.Zero;
        }
    }

    public static decimal MaxAmountWithdrawing
    {
        get
        {
            using var context = new SavingsManagementContext();
            return context.Configurations.FirstOrDefault()?.MaxAmountWithdrawing ?? decimal.Zero;
        }
    }

    public static decimal MinAmountWithdrawing
    {
        get
        {
            using var context = new SavingsManagementContext();
            return context.Configurations.FirstOrDefault()?.MinAmountWithdrawing ?? decimal.Zero;
        }
    }
}
