namespace DataAccess
{
    using System.Data;

    public static class StaffAccounts
    {
        private static readonly object LockObj = new object();

        public static void AddData(Entity.StaffAccount staffAccount)
        {
            lock (LockObj)
            {
                SqlQuery.ExecuteSqlCommand(
                    $"INSERT INTO {nameof(StaffAccounts)}(" +
                    $"{nameof(staffAccount.Name)}, " +
                    $"{nameof(staffAccount.IsMale)}, " +
                    $"{nameof(staffAccount.Position)}, " +
                    $"{nameof(staffAccount.Username)}, " +
                    $"{nameof(staffAccount.HashedPassword)}, " +
                    $"{nameof(staffAccount.AccountTypeId)}) " +
                    $"VALUES(" +
                    $"N'{staffAccount.Name}', " +
                    $"{(staffAccount.IsMale ? 1 : 0)}, " +
                    $"N'{staffAccount.Position}', " +
                    $"'{staffAccount.Username}', " +
                    $"'{staffAccount.HashedPassword}', " +
                    $"{staffAccount.AccountTypeId})");
            }
        }

        public static void EditData(Entity.StaffAccount staffAccount)
        {
            lock (LockObj)
            {
                SqlQuery.ExecuteSqlCommand(
                    $"UPDATE {nameof(StaffAccounts)} SET " +
                    $"{nameof(staffAccount.Name)} = N'{staffAccount.Name}', " +
                    $"{nameof(staffAccount.IsMale)} = {(staffAccount.IsMale ? 1 : 0)}, " +
                    $"{nameof(staffAccount.Position)} = N'{staffAccount.Position}', " +
                    $"{nameof(staffAccount.Username)} = '{staffAccount.Username}', " +
                    $"{nameof(staffAccount.HashedPassword)} = '{staffAccount.HashedPassword}' ," +
                    $"{nameof(staffAccount.AccountTypeId)} = {staffAccount.AccountTypeId} " +
                    $"WHERE {nameof(staffAccount.Id)} = {staffAccount.Id}");
            }
        }

        public static void DeleteData(Entity.StaffAccount staffAccount)
        {
            lock (LockObj)
            {
                SqlQuery.ExecuteSqlCommand(
                    $"DELETE FROM {nameof(StaffAccounts)} " +
                    $"WHERE {nameof(staffAccount.Id)} = {staffAccount.Id}");
            }
        }

        public static DataTable? GetDataTable(string conditionalString)
        {
            lock (LockObj)
            {
                return SqlQuery.GetDataTable($"SELECT * FROM {nameof(StaffAccounts)} {conditionalString}");
            }
        }
    }
}
