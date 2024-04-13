using System.Data;

namespace DataAccess
{
    public static class StaffAccountTypes
    {
        private static readonly object LockObj = new object();

        public static void AddData(Entity.StaffAccountType staffAccountType)
        {
            lock (LockObj)
            {
                SqlQuery.ExecuteSqlCommand(
                    $"INSERT INTO {nameof(StaffAccountTypes)}(" +
                    $"{nameof(staffAccountType.Name)}, " +
                    $"{nameof(staffAccountType.PermissionId)}) " +
                    $"VALUES(" +
                    $"'{staffAccountType.Name}', " +
                    $"{staffAccountType.PermissionId})");
            }
        }

        public static void EditData(Entity.StaffAccountType staffAccountType)
        {
            lock (LockObj)
            {
                SqlQuery.ExecuteSqlCommand(
                    $"UPDATE {nameof(StaffAccountTypes)} SET " +
                    $"{nameof(staffAccountType.Name)} = '{staffAccountType.Name}', " +
                    $"{nameof(staffAccountType.PermissionId)} = {staffAccountType.PermissionId} " +
                    $"WHERE {nameof(staffAccountType.Id)} = {staffAccountType.Id}");
            }
        }

        public static void DeleteData(Entity.StaffAccountType staffAccountType)
        {
            lock (LockObj)
            {
                SqlQuery.ExecuteSqlCommand(
                    $"DELETE FROM {nameof(StaffAccountTypes)} " +
                    $"WHERE {nameof(staffAccountType.Id)} = {staffAccountType.Id}");
            }
        }

        public static DataTable? GetDataTable(string conditionalString)
        {
            lock (LockObj)
            {
                return SqlQuery.GetDataTable($"SELECT * FROM {nameof(StaffAccountTypes)} {conditionalString}");
            }
        }
    }
}
