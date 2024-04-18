namespace Business;

using System.Linq;
using Entity;


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

    public static CustomerAccount GetCustomerAccount(int id)
    {
        using var context = new Entity.SavingsManagementContext();
        return context.CustomerAccounts.Where(c => c.Id == id).First();
    }
}
