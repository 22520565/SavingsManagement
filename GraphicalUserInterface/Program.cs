namespace GraphicalUserInterface;

using System;
using System.Windows.Forms;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.

        ApplicationConfiguration.Initialize();
        bool exitApplication = false;
        while (!exitApplication)
        {
            switch (CurrentForm.SelectedForm)
            {
                case CurrentForm.OpenForm.Login:
                    using (LoginForm loginForm = new LoginForm())
                    {
                        Application.Run(loginForm);
                    }
                    break;

                case CurrentForm.OpenForm.Customer:
                    using (CustomerMenuForm customerMenuForm = new CustomerMenuForm())
                    {
                        Application.Run(customerMenuForm);
                    }
                    break;

                case CurrentForm.OpenForm.Staff:
                    using (StaffMenuForm staffMenuForm = new StaffMenuForm())
                    {
                        Application.Run(staffMenuForm);
                    }
                    break;

                case CurrentForm.OpenForm.Forgot:
                    using (ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm())
                    {
                        Application.Run(forgotPasswordForm);
                    }
                    break;

                case CurrentForm.OpenForm.SignUp:
                    using (CustomerSignUpForm customerSignUpForm = new CustomerSignUpForm())
                    {
                        Application.Run(customerSignUpForm);
                    }
                    break;

                case CurrentForm.OpenForm.Exit:
                    exitApplication = true;
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
                    break;
            }
        }
    }
}
