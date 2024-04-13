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
                SqlQuery.ExecuteSqlCommand(
                    $"INSERT INTO {nameof(Savings)}(" +
                    $"{nameof(saving.CustomerId)}, " +
                    $"{nameof(saving.Balance)}, " +
                    $"{nameof(saving.AnnualInterestRate)}, " +
                    $"{nameof(saving.PeriodInMonths)}, " +
                    $"{nameof(saving.OpenDay)}) " +
                    $"VALUES(" +
                    $"{saving.CustomerId}, " +
                    $"{saving.Balance}, " +
                    $"{saving.AnnualInterestRate}, " +
                    $"{saving.PeriodInMonths}, " +
                    $"'{saving.OpenDay.ToString(CultureInfo.InvariantCulture)}')");
            }
        }

        public static void EditData(Entity.Saving saving)
        {
            lock (LockObj)
            {
                SqlQuery.ExecuteSqlCommand(
                    $"UPDATE Savings SET " +
                    $"{nameof(saving.CustomerId)} = {saving.CustomerId}, " +
                    $"{nameof(saving.Balance)} = {saving.Balance}, " +
                    $"{nameof(saving.AnnualInterestRate)} = {saving.AnnualInterestRate}, " +
                    $"{nameof(saving.PeriodInMonths)} = {saving.PeriodInMonths}, " +
                    $"{nameof(saving.OpenDay)} = '{saving.OpenDay.ToString(CultureInfo.InvariantCulture)}' " +
                    $"WHERE {nameof(saving.Id)} = {saving.Id}");
            }
        }

        public static void DeleteData(Entity.Saving saving)
        {
            lock (LockObj)
            {
                SqlQuery.ExecuteSqlCommand(
                    $"DELETE FROM {nameof(Savings)} " +
                    $"WHERE {nameof(saving.Id)} = {saving.Id}");
            }
        }

        public static DataTable? GetDataTable(string conditionalString)
        {
            lock (LockObj)
            {
                return SqlQuery.GetDataTable($"SELECT * FROM {nameof(Savings)} {conditionalString}");
            }
        }
    }
}
