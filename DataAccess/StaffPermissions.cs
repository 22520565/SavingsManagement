namespace DataAccess
{
    using System.Data;

    public static class StaffPermissions
    {
        private static readonly object LockObj = new object();

        public static void AddData(Entity.StaffPermission staffPermission)
        {
            lock (LockObj)
            {
                SqlQuery.ExecuteSqlCommand(
                    $"INSERT INTO {nameof(StaffPermissions)}(" +
                    $"{staffPermission.Name}) " +
                    $"VALUES(" +
                    $"'{staffPermission.Name}')");
            }
        }

        public static void EditData(Entity.StaffPermission staffPermission)
        {
            lock (LockObj)
            {
                SqlQuery.ExecuteSqlCommand(
                    $"UPDATE {nameof(StaffPermissions)} SET " +
                    $"{nameof(staffPermission.Name)} = '{staffPermission.Name}' " +
                    $"WHERE {nameof(staffPermission.Id)} = {staffPermission.Id}");
            }
        }

        public static void DeleteData(Entity.StaffPermission staffPermission)
        {
            lock (LockObj)
            {
                SqlQuery.ExecuteSqlCommand(
                    $"DELETE FROM {nameof(StaffPermissions)} " +
                    $"WHERE {nameof(staffPermission.Id)} = {staffPermission.Id}");
            }
        }

        public static DataTable? GetDataTable(string conditionalString)
        {
            lock (LockObj)
            {
                return SqlQuery.GetDataTable($"SELECT * FROM {nameof(StaffPermissions)} {conditionalString}");
            }
        }
    }
}
