namespace DataAccess
{
    using System.Data;
    using System.Globalization;

    public static class CustomerAccounts
    {
        private static readonly object LockObj = new object();

        public static void AddData(Entity.CustomerAccount customerAccount)
        {
            lock (LockObj)
            {
                SqlQuery.ExecuteSqlCommand($"INSERT INTO {nameof(CustomerAccounts)}(" +
                    $"{nameof(customerAccount.Name)}, " +
                    $"{nameof(customerAccount.IsMale)}, " +
                    $"{nameof(customerAccount.CicNumber)}, " +
                    $"{nameof(customerAccount.BirthDate)}, " +
                    $"{nameof(customerAccount.PhoneNumber)}, " +
                    $"{nameof(customerAccount.Address)}, " +
                    $"{nameof(customerAccount.Username)}, " +
                    $"{nameof(customerAccount.HashedPassword)}, " +
                    $"{nameof(customerAccount.Balance)}) " +
                    $"VALUES(" +
                    $"N'{customerAccount.Name}', " +
                    $"{customerAccount.IsMale.GetHashCode()}, " +
                    $"'{customerAccount.CicNumber}', " +
                    $"'{customerAccount.BirthDate}', " +
                    $"'{customerAccount.PhoneNumber}', " +
                    $"N'{customerAccount.Address}', " +
                    $"'{customerAccount.Username}', " +
                    $"'{customerAccount.HashedPassword}', " +
                    $"{customerAccount.Balance})");
            }
        }

        public static void EditData(Entity.CustomerAccount customerAccount)
        {
            lock (LockObj)
            {
                SqlQuery.ExecuteSqlCommand($"UPDATE {nameof(CustomerAccounts)} SET " +
                    $"{nameof(customerAccount.Name)} = N'{customerAccount.Name}', " +
                    $"{nameof(customerAccount.IsMale)} = {customerAccount.IsMale.GetHashCode()}, " +
                    $"{nameof(customerAccount.CicNumber)} = '{customerAccount.CicNumber}', " +
                    $"{nameof(customerAccount.BirthDate)} = '{customerAccount.BirthDate.ToString(CultureInfo.InvariantCulture)}', " +
                    $"{nameof(customerAccount.PhoneNumber)} = '{customerAccount.PhoneNumber}', " +
                    $"{nameof(customerAccount.Address)} = N'{customerAccount.Address}', " +
                    $"{nameof(customerAccount.Username)} = '{customerAccount.Username}', " +
                    $"{nameof(customerAccount.HashedPassword)} = '{customerAccount.HashedPassword}' " +
                    $"WHERE {nameof(customerAccount.Id)} = {customerAccount.Id}");
            }
        }

        public static void DeleteData(Entity.CustomerAccount customerAccount)
        {
            lock (LockObj)
            {
                SqlQuery.ExecuteSqlCommand($"DELETE FROM {nameof(CustomerAccounts)} " +
                    $"WHERE {nameof(customerAccount.Id)} = {customerAccount.Id}");
            }
        }

        public static DataTable GetDataTable(string conditionString)
        {
            lock (LockObj)
            {
                return SqlQuery.GetDataTable($"SELECT * FROM {nameof(CustomerAccounts)} {conditionString}");
            }
        }
    }
}
