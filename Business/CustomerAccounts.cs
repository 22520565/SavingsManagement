namespace Business
{
    using System.Collections.Generic;
    using System.Linq;

    public static class CustomerAccounts
    {
        public static void AddData(Entity.CustomerAccount customerAccount)
        {
            using var context = new Entity.SavingsManagementContext();
            context.Add(customerAccount);
            context.SaveChanges();
        }

        public static void EditData(Entity.CustomerAccount customerAccount)
        {
            using var context = new Entity.SavingsManagementContext();
            context.Update(customerAccount);
            context.SaveChanges();
        }

        public static void DeleteData(Entity.CustomerAccount customerAccount)
        {
            using var context = new Entity.SavingsManagementContext();
            context.Remove(customerAccount);
            context.SaveChanges();
        }

        public static List<Entity.CustomerAccount> GetDataTable(string conditionalString)
        {
            using var context = new Entity.SavingsManagementContext();
            return context.CustomerAccounts.ToList();
        }
    }
}
