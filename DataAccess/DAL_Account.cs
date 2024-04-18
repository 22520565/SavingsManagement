namespace DataAccess
{
    using Entity;
    using System;

    public class DAL_Account
    {  
        public string CheckLogin(Account account)
        {
            if (account.AcActive == false)
            {
                return "disable_account";
            }
            if (account.AcUsername == string.Empty)
            {
                return "requeid_account";
            }

            if (account.AcPassword == string.Empty)
            {
                return "requeid_password";
            }
            string query = "Select * from Account Where AcUsername = '" + account.AcUsername + "' and AcPassword = '" + account.AcPassword + "'";
            if (SqlQuery.Accounts(query).Count != 0)
            {
                return "successful_login";
            }
            else
            {
                return "incorrect_account_and_password";
            }
        }

        public string CheckSignUp(Account account)
        {
            string query1 = "Select * from Account Where AcUsername = '" + account.AcUsername + "'";
            if (SqlQuery.Accounts(query1).Count != 0)
            {
                return "available_username";
            }
            string query2 = "Select * from Account Where AcEmail = '" + account.AcEmail + "'";
            if (SqlQuery.Accounts(query2).Count != 0)
            {
                return "available_email";
            }
            try
            {
                string query3 = "Insert into Account (AcUsername, AcPassword, AcEmail, AcActive, ApId, Name, IsMale, CicNumber, BirthDate, PhoneNumber, Address, Balance) values ('" + account.AcUsername + "','" + account.AcPassword + "','" + account.AcEmail + "', '" + true + "','" + 3 + "', '" + "Update" + "','" + true + "','" + "Update" + "','" +"01/01/0001" + "','" + "Update" + "','" + "Update" + "','" + 0 + "')";
                SqlQuery.ExecuteSqlCommand(query3);
                return "successful_signup";
            }
            catch
            {
                return "error";
            }
        }

        public string CheckForgotPassword(Account account)
        {
            string query = "Select * from Account Where AcEmail = '" + account.AcEmail + "'";
            if (SqlQuery.Accounts(query).Count != 0)
            {
                return SqlQuery.Accounts(query)[0].AcPassword;
            }
            else
            {
                return "not_registered";
            }
        }

        public string checkAccountPermission(Account account)
        {
            string query = "Select * from Account Where AcUsername = '" + account.AcUsername + "' and AcPassword = '" + account.AcPassword + "'";
            if (SqlQuery.Accounts(query).Count != 0)
            {
                switch (SqlQuery.Accounts(query)[0].ApId)
                {
                    case 1:
                        return "admin";
                    case 2:
                        return "staff";
                    case 3:
                        return "customer";
                }
            } 
            return "error";
        }
    }
}
