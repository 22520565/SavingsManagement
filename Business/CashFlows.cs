namespace Business;

using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;

public static class CashFlows
{
    public static void Deposit(int customerId, decimal amount, string content)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Amount to deposit must be positive.");
        }
        else
        {
            AddCashFlow(customerId, amount, content);
        }
    }

    public static void Withdraw(int customerId, decimal amount, string content)
    {
        if (amount > 0)
        {
            AddCashFlow(customerId, -amount, content);
        }
        else
        {
            throw new ArgumentException("Amount to deposit must be positive.");
        }
    }

    public static IEnumerable<CashFlow> GetCashFlowsByCustomerId(int customerId)
    {
        using var context = new SavingsManagementContext();
        return context.CashFlows
                        .Where(cf => cf.CustomerId == customerId)
                        .OrderByDescending(cf => cf.Time)
                        .ToList();
    }

    private static void AddCashFlow(int customerId, decimal balanceChanging, string content)
    {
        using var context = new SavingsManagementContext();
        var cashFlow = new CashFlow
        {
            Time = DateTimeOffset.Now,
            CustomerId = customerId,
            BalanceChanging = balanceChanging,
            Content = content,
        };
        context.CashFlows.Add(cashFlow);
        context.SaveChanges();
    }

}
