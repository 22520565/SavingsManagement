namespace DataAccess
{
    using System.Data;
    using System.Globalization;

    public static class Savings
    {
        private static readonly object LockObj = new object();

        public static void AddData(Entity.Saving saving)
        {
            lock (LockObj)
            {
                const string sqlCommandString = "INSERT INTO Savings(id, customerId, balance, annualInterestRate, periodInMonths, openDate) VALUES ({0}, {1}, {2}, {3}, {4}, '{5}')";
                SqlQuery.ExecuteSqlCommand(string.Format(CultureInfo.InvariantCulture, sqlCommandString,
                    saving.Id, saving.CustomerId, saving.Balance, saving.AnnualInterestRate, saving.PeriodInMonths, saving.OpenDay.ToString(CultureInfo.InvariantCulture)));
            }
        }

        public static void EditData(Entity.Saving saving)
        {
            lock (LockObj)
            {
                const string sqlCommandString = "UPDATE Savings SET customerId = {1}, balance = {2}, annualInterestRate = {3}, periodInMonths = {4}, openDate = '{5}' WHERE id = {0}";
                SqlQuery.ExecuteSqlCommand(string.Format(CultureInfo.InvariantCulture, sqlCommandString,
                    saving.Id, saving.CustomerId, saving.Balance, saving.AnnualInterestRate, saving.PeriodInMonths, saving.OpenDay.ToString(CultureInfo.InvariantCulture)));
            }
        }

        public static void DeleteData(Entity.Saving saving)
        {
            lock (LockObj)
            {
                const string sqlCommandString = "DELETE FROM Savings WHERE id = {0}";
                SqlQuery.ExecuteSqlCommand(string.Format(CultureInfo.InvariantCulture, sqlCommandString, saving.Id));
            }
        }

        public static DataTable? GetDataTable(string conditionString)
        {
            lock (LockObj)
            {
                const string sqlCommandString = "SELECT * FROM Savings {0}";
                return SqlQuery.GetDataTable(string.Format(CultureInfo.InvariantCulture, sqlCommandString, conditionString));
            }
        }
    }
}
