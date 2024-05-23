namespace Business;

using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;

public static class CashFlows
{
    public static void AddCashFlow(int customerId, decimal balanceChanging, string content)
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

    public static IEnumerable<CashFlow> GetCashFlowsByCustomerId(int customerId)
    {
        using var context = new SavingsManagementContext();
        return context.CashFlows
                        .Where(cf => cf.CustomerId == customerId)
                        .OrderByDescending(cf => cf.Time)
                        .ToList();
    }

    public static CashFlow? GetCashFlowById(int id)
    {
        using var context = new SavingsManagementContext();
        return context.CashFlows.SingleOrDefault(cf => cf.Id == id);
    }

    public static void UpdateCashFlow(int id, decimal newBalanceChanging, string newContent)
    {
        using var context = new SavingsManagementContext();
        var cashFlow = context.CashFlows.SingleOrDefault(cf => cf.Id == id);
        if (cashFlow is not null)
        {
            cashFlow.BalanceChanging = newBalanceChanging;
            cashFlow.Content = newContent;
            context.SaveChanges();
        }
    }

    public static void DeleteCashFlow(int id)
    {
        using var context = new SavingsManagementContext();
        var cashFlow = context.CashFlows.SingleOrDefault(cf => cf.Id == id);
        if (cashFlow is not null)
        {
            context.CashFlows.Remove(cashFlow);
            context.SaveChanges();
        }
    }
}
