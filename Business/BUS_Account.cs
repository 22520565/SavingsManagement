namespace Business
{
    using Entity;
    using DataAccess;

    public class BUS_Account
    {
        DAL_Account dal_account = new DAL_Account();

        public string CheckLogin(Account account)
        {
            return dal_account.CheckLogin(account);
        }

        public string CheckSignUp(Account account) 
        {
            return dal_account.CheckSignUp(account);
        }

        public string CheckForgotPassword(Account account)
        {
            return dal_account.CheckForgotPassword(account);
        }

        public string checkAccountPermission(Account account)
        {
            return dal_account.checkAccountPermission(account);
        }
    }
}
