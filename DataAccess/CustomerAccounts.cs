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
                const string sqlCommandString = "INSERT INTO CustomerAccounts(id, name, isMale, cicNumber, birthDate, phoneNumber, address, username, hashedPassword, balance) VALUES ({0}, N'{1}', {2}, '{3}', '{4}', '{5}', N'{6}', '{7}', '{8}', {9})";
                SqlAccess.ExecuteSqlCommand(string.Format(CultureInfo.InvariantCulture, sqlCommandString,
                    customerAccount.Id, customerAccount.Name, customerAccount.IsMale, customerAccount.CicNumber, customerAccount.BirthDate.ToString(CultureInfo.InvariantCulture),
                    customerAccount.PhoneNumber, customerAccount.Address, customerAccount.Username, customerAccount.HashedPassword, customerAccount.Balance));
            }
        }

        public static void EditData(Entity.CustomerAccount customerAccount)
        {
            lock (LockObj)
            {
                const string sqlCommandString = "UPDATE CustomerAccounts SET name = N'{1}', isMale = {2}, cicNumber = '{3}', birthDate = '{4}', phoneNumber = '{5}', address = N'{6}', hashedPassword = '{7}' WHERE id = {0}";
                SqlAccess.ExecuteSqlCommand(string.Format(CultureInfo.InvariantCulture, sqlCommandString,
                    customerAccount.Id, customerAccount.Name, customerAccount.IsMale, customerAccount.CicNumber, customerAccount.BirthDate.ToString(CultureInfo.InvariantCulture),
                    customerAccount.PhoneNumber, customerAccount.Address, customerAccount.HashedPassword));
            }
        }

        public static void DeleteData(Entity.CustomerAccount customerAccount)
        {
            lock (LockObj)
            {
                const string sqlCommandString = "DELETE FROM CustomerAccounts WHERE id = {0}";
                SqlAccess.ExecuteSqlCommand(string.Format(CultureInfo.InvariantCulture, sqlCommandString, customerAccount.Id));
            }
        }

        public static DataTable? GetDataTable(string conditionString)
        {
            lock (LockObj)
            {
                const string sqlCommandString = "SELECT * FROM CustomerAccounts {0}";
                return SqlAccess.GetDataTable(string.Format(CultureInfo.InvariantCulture, sqlCommandString, conditionString));
            }
        }
    }
}
