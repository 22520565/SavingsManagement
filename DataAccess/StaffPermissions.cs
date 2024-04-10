using System.Data;
using System.Globalization;

namespace DataAccess
{
    public static class StaffPermissions
    {
        private static readonly object LockObj = new object();

        public static void AddData(Entity.StaffPermission staffPermission)
        {
            lock (LockObj)
            {
                const string sqlCommandString = "INSERT INTO StaffPermissions(id, name) VALUES ({0}, '{1}')";
                SqlAccess.ExecuteSqlCommand(string.Format(CultureInfo.InvariantCulture, sqlCommandString,
                    staffPermission.Id, staffPermission.Name));
            }
        }

        public static void EditData(Entity.StaffPermission staffPermission)
        {
            lock (LockObj)
            {
                const string sqlCommandString = "UPDATE StaffPermissions SET name = '{1}' WHERE id = {0}";
                SqlAccess.ExecuteSqlCommand(string.Format(CultureInfo.InvariantCulture, sqlCommandString,
                   staffPermission.Id, staffPermission.Name));
            }
        }

        public static void DeleteData(Entity.StaffPermission staffPermission)
        {
            lock (LockObj)
            {
                const string sqlCommandString = "DELETE FROM StaffPermissions WHERE id = {0}";
                SqlAccess.ExecuteSqlCommand(string.Format(CultureInfo.InvariantCulture, sqlCommandString, staffPermission.Id));
            }
        }

        public static DataTable? GetDataTable(string conditionString)
        {
            lock (LockObj)
            {
                const string sqlCommandString = "SELECT * FROM StaffPermissions {0}";
                return SqlAccess.GetDataTable(string.Format(CultureInfo.InvariantCulture, sqlCommandString, conditionString));
            }
        }
    }
}
