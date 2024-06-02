namespace Business;

using System;
using System.Linq;
using DataAccess;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

public static class CustomerAccounts
{
    private static readonly PasswordHasher<CustomerAccount> PasswordHasher = new();

    public enum LoginResult
    {
        Success,
        UsernameError,
        MultiUsernameError,
        PasswordError,
        Disabled,
    }

    public static int? CurrentCustomerId { get; private set; } = null;

    public static decimal? CurrentCustomerBalance => CurrentCustomerAccount?.Balance;

    public static CustomerAccount? CurrentCustomerAccount => GetCustomerAccount(CurrentCustomerId);

    public static CustomerAccount? GetCustomerAccount(int? customerId)
    {
        using var context = new SavingsManagementContext();
        return context.CustomerAccounts.Find(customerId);
    }

    public static bool checkPass(string password)
    {
        using var context = new SavingsManagementContext();
        var customerAccount = context.CustomerAccounts.Find(CurrentCustomerId);
        if (customerAccount is not null)
        {
            switch (PasswordHasher.VerifyHashedPassword(null!, customerAccount.HashedPassword, password))
            {
                case PasswordVerificationResult.Success:
                    return true;
            }
        }
        return false;
    }

    public static void updatePass(string newpass)
    {
        using var context = new SavingsManagementContext();
        var customerAccount = context.CustomerAccounts.Find(CurrentCustomerId);
        if (customerAccount is not null)
        {
            customerAccount.HashedPassword = PasswordHasher.HashPassword(null!, newpass);
            context.SaveChanges();
        }
    }

    public static LoginResult Login(LoginInfo loginInfo)
    {
        ArgumentNullException.ThrowIfNull(loginInfo);

        LoginResult loginResult = LoginResult.UsernameError;

        using var context = new SavingsManagementContext();
        var listAccounts = context.CustomerAccounts.Where(customerAccount => customerAccount.Username == loginInfo.Username).AsEnumerable();
        if (listAccounts.IsNullOrEmpty())
        {
            loginResult = LoginResult.UsernameError;
        }
        else if (listAccounts.Count() > 1)
        {
            loginResult = LoginResult.MultiUsernameError;
        }
        else
        {
            var customerAccount = listAccounts.ElementAt(Index.Start);
            if (customerAccount.IsDisabled)
            {
                loginResult = LoginResult.Disabled;
            }
            else
            {
                switch (PasswordHasher.VerifyHashedPassword(null!, customerAccount.HashedPassword, loginInfo.Password))
                {
                    case PasswordVerificationResult.Success:
                    case PasswordVerificationResult.SuccessRehashNeeded:
                        loginResult = LoginResult.Success;
                        CurrentCustomerId = customerAccount.Id;
                        break;

                    default:
                        loginResult = LoginResult.PasswordError;
                        break;
                }
            }
        }

        return loginResult;
    }

    public static void LogOut()
    {
        CurrentCustomerId = null;
    }

    public static void SignUp(SignUpInfo signUpInfo)
    {
        ArgumentNullException.ThrowIfNull(signUpInfo);

        using var context = new SavingsManagementContext();
        context.CustomerAccounts.Add(new CustomerAccount
        {
            Name = signUpInfo.Name,
            IsMale = signUpInfo.IsMale,
            CicNumber = signUpInfo.CicNumber,
            BirthDate = signUpInfo.BirthDate,
            PhoneNumber = signUpInfo.PhoneNumber,
            Address = signUpInfo.Address,
            Email = signUpInfo.Email,
            Username = signUpInfo.Username,
            HashedPassword = PasswordHasher.HashPassword(null!, signUpInfo.Password),
        });
        context.SaveChanges();
    }
}
