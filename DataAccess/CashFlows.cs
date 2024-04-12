using System.Data;
using System.Globalization;

namespace DataAccess
{
    public static class CashFlows
    {
        private static readonly object LockObj = new object();

        public static void AddData(Entity.CashFlow cashFlow)
        {
            lock (LockObj)
            {
                SqlQuery.ExecuteSqlCommand($"INSERT INTO {nameof(CashFlows)}(" +
                    $"{nameof(cashFlow.CustomerId)}, " +
                    $"{nameof(cashFlow.Time)}, " +
                    $"{nameof(cashFlow.BalanceChanging)}, " +
                    $"{nameof(cashFlow.BalanceRemaining)}, " +
                    $"{nameof(cashFlow.Context)}, " +
                    $"VALUES(" +
                    $"{cashFlow.CustomerId}, " +
                    $"'{cashFlow.Time}', " +
                    $"{cashFlow.BalanceChanging}, " +
                    $"{cashFlow.BalanceRemaining}, " +
                    $"{cashFlow.Context})");
            }
        }

        public static void EditData(Entity.CashFlow cashFlow)
        {
            lock (LockObj)
            {
                 SqlQuery.ExecuteSqlCommand($"UPDATE {nameof(CashFlows)} SET " +
                     $"{nameof(cashFlow.CustomerId)} = {cashFlow.CustomerId}, " +
                     $"{nameof(cashFlow.Time)} = '{cashFlow.Time}', " +
                     $"{nameof(cashFlow.BalanceChanging)} = {cashFlow.BalanceChanging}, " +
                     $"{nameof(cashFlow.BalanceRemaining)} = {cashFlow.BalanceRemaining}, " +
                     $"{nameof(cashFlow.Context)} = {cashFlow.Context} " +
                     $"WHERE {nameof(cashFlow.Id)} = {cashFlow.Id}");
            }
        }

        public static void DeleteData(Entity.CashFlow cashFlow)
        {
            lock (LockObj)
            {
                SqlQuery.ExecuteSqlCommand($"DELETE FROM {nameof(CashFlows)} WHERE {nameof(cashFlow.Id)} = {cashFlow.Id}");
            }
        }

        public static DataTable? GetDataTable(string conditionString)
        {
            lock (LockObj)
            {
                return SqlQuery.GetDataTable($"SELECT * FROM {nameof(CashFlows)} {conditionString}");
            }
        }
    }
}
