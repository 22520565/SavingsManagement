namespace Business;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

public static class StaffAccounts
{
    private static readonly PasswordHasher<StaffAccount> PasswordHasher = new();

    public enum LoginResult
    {
        Success,
        UsernameError,
        MultiUsernameError,
        PasswordError,
    }

    public static int? CurrentStaffId { get; private set; } = null;

    public static LoginResult Login(LoginInfo loginInfo)
    {
        ArgumentNullException.ThrowIfNull(loginInfo);

        LoginResult loginResult = LoginResult.PasswordError;

        using var context = new SavingsManagementContext();
        var listAccounts = context.StaffAccounts.Where(staffAccount => staffAccount.Username == loginInfo.Username).AsEnumerable();
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
            var staffAccount = listAccounts.ElementAt(Index.Start);

            switch (PasswordHasher.VerifyHashedPassword(null!, staffAccount.HashedPassword, loginInfo.Password))
            {
                case PasswordVerificationResult.Success:
                case PasswordVerificationResult.SuccessRehashNeeded:
                    loginResult = LoginResult.Success;
                    CurrentStaffId = staffAccount.Id;
                    break;

                default:
                    loginResult = LoginResult.PasswordError;
                    break;
            }
        }
        return loginResult;
    }

    public static void LogOut()
    {
        CurrentStaffId = null;
    }
}

