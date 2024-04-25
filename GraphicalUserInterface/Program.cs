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
        do
        {
            using var loginForm = new LoginForm();
            Application.Run(loginForm);
            if (!loginForm.UserSuccessfullyAuthenticated)
            {
                break;
            }

            using var mainMenuForm = new MainMenuForm();
            Application.Run(mainMenuForm);
            if (!mainMenuForm.GoingBackToLoginForm)
            {
                break;
            }


        } while (true);
    }
}
