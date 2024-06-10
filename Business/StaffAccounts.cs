namespace Business;

using System;
using System.Linq;
using System.Text.RegularExpressions;
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

    public static void UpdateStaff(StaffAccount staff)
    {
        if (staff == null)
        {
            return;
        }
        else
        {
            using var context = new SavingsManagementContext();
            StaffAccount staffAccount = context.StaffAccounts.Find(CurrentStaffId);
            if (staffAccount != null)
            {
                staffAccount.Name = staff.Name;
                staffAccount.Position = staff.Position;
                staffAccount.IsMale = staff.IsMale;
                staffAccount.Address = staff.Address;
                staffAccount.PhoneNumber = staff.PhoneNumber;
                staffAccount.Email = staff.Email;
                staffAccount.BirthDate = staff.BirthDate;
                staffAccount.Username = staff.Username;
                context.SaveChanges();
            }
        }
    }

    public enum PasswordChangingResult
    {
        Success,
        AccountNotFound,
        EmptyOldPassword,
        InvalidNewPassword,
        WrongOldPassword,
    }

    private static bool checkPasssword(string password)
    {
        //Tối thiểu tám ký tự, ít nhất một chữ cái viết hoa, ít nhất một chữ cái viết thường, ít nhất một số và ít nhất một ký tự đặc biệt
        return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
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
        else if (newPassword.IsNullOrEmpty() || !checkPasssword(newPassword))
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
