using System.Data;
using System.Globalization;

namespace DataAccess
{
    public static class StaffAccountTypes
    {
        private static readonly object LockObj = new object();

        public static void AddData(Entity.StaffAccountType staffAccountType)
        {
            lock (LockObj)
            {
                const string sqlCommandString = "INSERT INTO StaffAccountTypes(id, name, permissionId) VALUES ({0}, '{1}', {2})";
                SqlAccess.ExecuteSqlCommand(string.Format(CultureInfo.InvariantCulture, sqlCommandString,
                    staffAccountType.Id, staffAccountType.Name, staffAccountType.PermissionId));
            }
        }

        public static void EditData(Entity.StaffAccountType staffAccountType)
        {
            lock (LockObj)
            {
                const string sqlCommandString = "UPDATE StaffAccountTypes SET name = N'{1}', permissionId = {2} WHERE id = {0}";
                SqlAccess.ExecuteSqlCommand(string.Format(CultureInfo.InvariantCulture, sqlCommandString,
                   staffAccountType.Id, staffAccountType.Name, staffAccountType.PermissionId));
            }
        }

        public static void DeleteData(Entity.StaffAccountType staffAccountType)
        {
            lock (LockObj)
            {
                const string sqlCommandString = "DELETE FROM StaffAccountTypes WHERE id = {0}";
                SqlAccess.ExecuteSqlCommand(string.Format(CultureInfo.InvariantCulture, sqlCommandString, staffAccountType.Id));
            }
        }

        public static DataTable? GetDataTable(string conditionString)
        {
            lock (LockObj)
            {
                const string sqlCommandString = "SELECT * FROM StaffAccountTypes {0}";
                return SqlAccess.GetDataTable(string.Format(CultureInfo.InvariantCulture, sqlCommandString, conditionString));
            }
        }
    }
}
