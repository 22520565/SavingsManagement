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
                const string sqlCommandString = "INSERT INTO CashFlows (id, customerId, time, balanceChanging, balanceRemaining) VALUES ({0}, {1}, '{2}', {3}, {4})";
                SqlAccess.ExecuteSqlCommand(string.Format(CultureInfo.InvariantCulture, sqlCommandString,
                    cashFlow.Id, cashFlow.CustomerId, cashFlow.Time.ToString(CultureInfo.InvariantCulture), cashFlow.BalanceChanging, cashFlow.BalanceRemaining));
            }
        }

        public static void EditData(Entity.CashFlow cashFlow)
        {
            lock (LockObj)
            {
                const string sqlCommandString = "UPDATE CashFlows SET customerId = {1}, time = '{2}', balanceChanging = {3}, balanceRemaining = {4} WHERE customerId = {0}";
                SqlAccess.ExecuteSqlCommand(string.Format(CultureInfo.InvariantCulture, sqlCommandString,
                  cashFlow.Id, cashFlow.CustomerId, cashFlow.Time.ToString(CultureInfo.InvariantCulture), cashFlow.BalanceChanging, cashFlow.BalanceRemaining));
            }
        }

        public static void DeleteData(Entity.CashFlow cashFlow)
        {
            lock (LockObj)
            {
                const string sqlCommandString = "DELETE FROM CashFlows WHERE id = {0}";
                SqlAccess.ExecuteSqlCommand(string.Format(CultureInfo.InvariantCulture, sqlCommandString, cashFlow.Id));
            }
        }

        public static DataTable? GetDataTable(string conditionString)
        {
            lock (LockObj)
            {
                const string sqlCommandString = "SELECT * FROM CashFlows {0}";
                return SqlAccess.GetDataTable(string.Format(CultureInfo.InvariantCulture, sqlCommandString, conditionString));
            }
        }
    }
}
