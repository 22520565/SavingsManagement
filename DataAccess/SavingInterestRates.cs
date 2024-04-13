namespace DataAccess
{
    using System.Data;

    public static class SavingInterestRates
    {
        private static readonly object LockObj = new object();

        public static void AddData(Entity.SavingInterestRate savingInterestRate)
        {
            lock (LockObj)
            {
                SqlQuery.ExecuteSqlCommand(
                    $"INSERT INTO {nameof(SavingInterestRates)}(" +
                    $"{nameof(savingInterestRate.PeriodInMonths)}, " +
                    $"{nameof(savingInterestRate.AnnualInterestRate)}) " +
                    $"VALUES(" +
                    $"{savingInterestRate.PeriodInMonths}, " +
                    $"{savingInterestRate.AnnualInterestRate})");
            }
        }

        public static void EditData(Entity.SavingInterestRate savingInterestRate)
        {
            lock (LockObj)
            {
                SqlQuery.ExecuteSqlCommand(
                    $"UPDATE {nameof(SavingInterestRates)} SET " +
                    $"{nameof(savingInterestRate.AnnualInterestRate)} = {savingInterestRate.AnnualInterestRate} " +
                    $"WHERE {nameof(savingInterestRate.PeriodInMonths)} = {savingInterestRate.PeriodInMonths}");
            }
        }

        public static void DeleteData(Entity.SavingInterestRate savingInterestRate)
        {
            lock (LockObj)
            {
                SqlQuery.ExecuteSqlCommand(
                    $"DELETE FROM {nameof(SavingInterestRates)} " +
                    $"WHERE {nameof(savingInterestRate.PeriodInMonths)} = {savingInterestRate.PeriodInMonths}");
            }
        }

        public static DataTable? GetDataTable(string conditionalString)
        {
            lock (LockObj)
            {
                return SqlQuery.GetDataTable($"SELECT * FROM {nameof(SavingInterestRates)} {conditionalString}");
            }
        }
    }
}
