namespace DataAccess
{
    using System.Data;
    using System.Globalization;

    public static class StaffAccounts
    {
        private static readonly object LockObj = new object();

        public static void AddData(Entity.StaffAccount staffAccount)
        {
            lock (LockObj)
            {
                const string sqlCommandString = "INSERT INTO StaffAccounts(id, name, isMale, position, username, hashedPassword, staffAccountTypeId) VALUES ({0}, N'{1}', {2}, N'{3}', '{4}', '{5}', {6})";
                SqlAccess.ExecuteSqlCommand(string.Format(CultureInfo.InvariantCulture, sqlCommandString,
                    staffAccount.Id, staffAccount.Name, staffAccount.IsMale, staffAccount.Position, staffAccount.Username, staffAccount.HashedPassword, staffAccount.StaffAccountTypeId));
            }
        }

        public static void EditData(Entity.StaffAccount staffAccount)
        {
            lock (LockObj)
            {
                const string sqlCommandString = "UPDATE StaffAccounts SET name = N'{1}', isMale = {2}, position = N'{3}', hashedPassword = '{4}', staffAccountTypeId = {5} WHERE id = {0}";
                SqlAccess.ExecuteSqlCommand(string.Format(CultureInfo.InvariantCulture, sqlCommandString,
                  staffAccount.Id, staffAccount.Name, staffAccount.IsMale, staffAccount.Position, staffAccount.HashedPassword, staffAccount.StaffAccountTypeId));
            }
        }

        public static void DeleteData(Entity.StaffAccount staffAccount)
        {
            lock (LockObj)
            {
                const string sqlCommandString = "DELETE FROM StaffAccounts WHERE id = {0}";
                SqlAccess.ExecuteSqlCommand(string.Format(CultureInfo.InvariantCulture, sqlCommandString, staffAccount.Id));
            }
        }

        public static DataTable? GetDataTable(string conditionString)
        {
            lock (LockObj)
            {
                const string sqlCommandString = "SELECT * FROM StaffAccounts {0}";
                return SqlAccess.GetDataTable(string.Format(CultureInfo.InvariantCulture, sqlCommandString, conditionString));
            }
        }
    }
}
