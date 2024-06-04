namespace Business;

using System;
using System.Linq;
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
        Disabled,
    }

    public static int? CurrentStaffId { get; private set; } = null;

    public static StaffAccount? CurrentStaffAccount => GetStaffAccount(CurrentStaffId);

    public static StaffAccount? GetStaffAccount(int? staffId)
    {
        using var context = new SavingsManagementContext();
        return context.StaffAccounts.Find(staffId);
    }

    public enum PasswordChangingResult
    {
        Success,
        AccountNotFound,
        EmptyOldPassword,
        InvalidNewPassword,
        WrongOldPassword,
    }

    public static PasswordChangingResult ChangePassword(string oldPassword, string newPassword)
    {
        PasswordChangingResult passwordChangingResult = PasswordChangingResult.WrongOldPassword;

        using var context = new SavingsManagementContext();
        var staffAccount = context.StaffAccounts.Find(CurrentStaffId);

        if (oldPassword.IsNullOrEmpty())
        {
            passwordChangingResult = PasswordChangingResult.EmptyOldPassword;
        }
        else if (newPassword.IsNullOrEmpty())
        {
            passwordChangingResult = PasswordChangingResult.InvalidNewPassword;
        }
        else if (staffAccount is null)
        {
            passwordChangingResult = PasswordChangingResult.AccountNotFound;
        }
        else if (PasswordHasher.VerifyHashedPassword(null!, staffAccount.HashedPassword!, oldPassword)
            == PasswordVerificationResult.Failed)
        {
            passwordChangingResult = PasswordChangingResult.WrongOldPassword;
        }
        else
        {
            staffAccount.HashedPassword = PasswordHasher.HashPassword(null!, newPassword);
            context.SaveChanges();
            passwordChangingResult = PasswordChangingResult.Success;
        }

        return passwordChangingResult;
    }

    public static LoginResult Login(LoginInfo loginInfo)
    {
        ArgumentNullException.ThrowIfNull(loginInfo);

        LoginResult loginResult = LoginResult.UsernameError;

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
            if (staffAccount.IsDisabled)
            {
                loginResult = LoginResult.Disabled;
            }
            else
            {
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
        }

        return loginResult;
    }

    public static void LogOut()
    {
        CurrentStaffId = null;
    }
}
