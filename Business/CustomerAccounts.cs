namespace Business
{
    using System.Data;

    public static class CustomerAccounts
    {
        public static void AddData(Entity.CustomerAccount customerAccount)
        {
            DataAccess.CustomerAccounts.AddData(customerAccount);
        }

        public static void EditData(Entity.CustomerAccount customerAccount)
        {
            DataAccess.CustomerAccounts.EditData(customerAccount);
        }

        public static void DeleteData(Entity.CustomerAccount customerAccount)
        {
            DataAccess.CustomerAccounts.DeleteData(customerAccount);
        }

        public static DataTable GetDataTable(string conditionalString)
        {
            return DataAccess.CustomerAccounts.GetDataTable(conditionalString);
        }
    }
}
