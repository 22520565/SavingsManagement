namespace DataAccess
{
    using System.Data;
    using System.Globalization;

    public static class AnnualSavingsInterestRates
    {
        private static readonly object LockObj = new object();

        public static void AddData(Entity.AnnualSavingsInterestRate annualSavingsInterestRate)
        {
            lock (LockObj)
            {
                const string sqlCommandString = "INSERT INTO AnnualSavingsInterestRates(periodInMonths, annualInterestRate) VALUES ({0}, {1})";
                SqlQuery.ExecuteSqlCommand(string.Format(CultureInfo.InvariantCulture, sqlCommandString,
                    annualSavingsInterestRate.PeriodInMonths, annualSavingsInterestRate.AnnualInterestRate));
            }
        }

        public static void EditData(Entity.AnnualSavingsInterestRate annualSavingsInterestRate)
        {
            lock (LockObj)
            {
                const string sqlCommandString = "UPDATE AnnualSavingsInterestRates SET annualInterestRate = {1} WHERE periodInMonths = {0}";
                SqlQuery.ExecuteSqlCommand(string.Format(CultureInfo.InvariantCulture, sqlCommandString,
                   annualSavingsInterestRate.PeriodInMonths, annualSavingsInterestRate.AnnualInterestRate));
            }
        }

        public static void DeleteData(Entity.AnnualSavingsInterestRate annualSavingsInterestRate)
        {
            lock (LockObj)
            {
                const string sqlCommandString = "DELETE FROM AnnualSavingsInterestRates WHERE id = {0}";
                SqlQuery.ExecuteSqlCommand(string.Format(CultureInfo.InvariantCulture, sqlCommandString, annualSavingsInterestRate.PeriodInMonths));
            }
        }

        public static DataTable? GetDataTable(string conditionString)
        {
            lock (LockObj)
            {
                const string sqlCommandString = "SELECT * FROM AnnualSavingsInterestRates {0}";
                return SqlQuery.GetDataTable(string.Format(CultureInfo.InvariantCulture, sqlCommandString, conditionString));
            }
        }
    }
}
