namespace GraphicalUserInterface;

using System;
using System.Drawing;
using System.Windows.Forms;
using Business;
using GraphicalUserInterface.Properties;
using Microsoft.IdentityModel.Tokens;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        this.InitializeComponent();
    }

    public bool UserSuccessfullyAuthenticated { get; private set; } = false;

    public bool StaffSuccessfullyAuthenticated { get; private set; } = false;

    private void linkLabel_SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        this.Hide();
        using var customerSignUpForm = new CustomerSignUpForm();
        customerSignUpForm.Show();
        this.Close();
    }

    private void btnCustomerLogin_MouseEnter(object sender, EventArgs e)
    {
        this.btnCustomerLogin.BackColor = Color.FromArgb(11, 9, 120);
        this.btnCustomerLogin.ForeColor = Color.White;
    }

    private void btnCustomerLogin_MouseLeave(object sender, EventArgs e)
    {
        this.btnCustomerLogin.BackColor = Color.Black;
        this.btnCustomerLogin.ForeColor = Color.White;
    }

    private void btnExit_MouseEnter(object sender, EventArgs e)
    {
        this.btnExit.BackColor = Color.FromArgb(11, 9, 120);
        this.btnExit.ForeColor = Color.White;
    }

    private void btnExit_MouseLeave(object sender, EventArgs e)
    {
        this.btnExit.BackColor = SystemColors.Control;
        this.btnExit.ForeColor = Color.Black;
    }

    private void cbCustomerShowPassword_CheckedChanged(object sender, EventArgs e)
    {
        if (!this.cbCustomerShowPassword.Checked)
        {
            this.txtCustomerPassword.UseSystemPasswordChar = true;
            this.cbCustomerShowPassword.BackgroundImage = Resources.hide;
        }
        else
        {
            this.txtCustomerPassword.UseSystemPasswordChar = false;
            this.cbCustomerShowPassword.BackgroundImage = Resources.show;
        }

    }

    private void btnCustomerLogin_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.txtCustomerUsername.Text.IsNullOrEmpty())
            {
                MessageBox.Show(this, Properties.Resources.UsernameBlankWarningString, Properties.Resources.WarningTitleString,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (this.txtCustomerPassword.Text.IsNullOrEmpty())
            {
                MessageBox.Show(this, Properties.Resources.PasswordBlankWarningString, Properties.Resources.WarningTitleString,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                switch (CustomerAccounts.Login(new LoginInfo
                {
                    Username = this.txtCustomerUsername.Text,
                    Password = this.txtCustomerPassword.Text,
                }))
                {
                    case CustomerAccounts.LoginResult.Success:
                        this.UserSuccessfullyAuthenticated = true;
                        this.Close();
                        break;

                    case CustomerAccounts.LoginResult.PasswordError:
                        MessageBox.Show(this, Properties.Resources.PasswordIncorrectWarningString, Properties.Resources.WarningTitleString,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;

                    case CustomerAccounts.LoginResult.UsernameError:
                        MessageBox.Show(this, Properties.Resources.UsernameNotFoundWarningString, Properties.Resources.WarningTitleString,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;

                    case CustomerAccounts.LoginResult.Disabled:
                        MessageBox.Show(this, Properties.Resources.AccountDisabledErrorString, Properties.Resources.ErrorTitleString,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;

                    default:
                        MessageBox.Show(this, Properties.Resources.UnknownErrorString, Properties.Resources.ErrorTitleString,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void cbCustomerRememberInfo_CheckedChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(this.txtCustomerUsername.Text) && !string.IsNullOrEmpty(this.txtCustomerPassword.Text))
        {
            if (this.cbCustomerRememberInfo.Checked)
            {
                Settings.Default.AcUsername = this.txtCustomerUsername.Text;
                Settings.Default.AcPassword = this.txtCustomerPassword.Text;
                Settings.Default.Save();
            }
            else
            {
                Settings.Default.AcUsername = string.Empty;
                Settings.Default.AcPassword = string.Empty;
                Settings.Default.Save();
            }
        }
    }

    private void LoginForm_Load(object sender, EventArgs e)
    {
        this.UserSuccessfullyAuthenticated = false;
        CustomerAccounts.LogOut();
        this.txtCustomerUsername.Text = Settings.Default.AcUsername;
        this.txtCustomerPassword.Text = Settings.Default.AcPassword;
        this.cbCustomerRememberInfo.Checked = !Settings.Default.AcUsername.IsNullOrEmpty();

        // Show password checkbox custom
        this.cbCustomerShowPassword.Appearance = Appearance.Button;
        this.cbCustomerShowPassword.FlatStyle = FlatStyle.Flat;
        this.cbCustomerShowPassword.FlatAppearance.BorderSize = 0;
        this.cbCustomerShowPassword.BackgroundImage = Resources.hide;

        this.StaffSuccessfullyAuthenticated = false;
        StaffAccounts.LogOut();
        this.txtStaffUsername.Text = Settings.Default.StaffUsername;
        this.txtStaffPassword.Text = Settings.Default.StaffPassword;
        this.cbStaffRemeberInfo.Checked = !Settings.Default.StaffUsername.IsNullOrEmpty();

        // Show password checkbox custom
        this.cbStaffShowPassword.Appearance = Appearance.Button;
        this.cbStaffShowPassword.FlatStyle = FlatStyle.Flat;
        this.cbStaffShowPassword.FlatAppearance.BorderSize = 0;
        this.cbStaffShowPassword.BackgroundImage = Resources.hide;
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Form bg = new Form();
        CloseWindow logOut = new CloseWindow();
        logOut.Text = "Exit";
        logOut.Confirm.Text = "Exit";
        logOut.Notification.Text = "Do you want to exit?";
        using (logOut)
        {
            bg.StartPosition = FormStartPosition.Manual;
            bg.FormBorderStyle = FormBorderStyle.None;
            bg.BackColor = Color.Black;
            bg.Opacity = 0.7d;
            bg.Size = this.Size;
            bg.Location = this.Location;
            bg.ShowInTaskbar = false;
            bg.Show(this);
            logOut.Owner = bg;
            logOut.ShowDialog(bg);
            bg.Dispose();
        }
        if (!logOut.IsNotClosed)
        {
            this.Close();
        }
    }

    private void cbStaffShowPassword_CheckedChanged(object sender, EventArgs e)
    {
        if (!this.cbStaffShowPassword.Checked)
        {
            this.txtStaffPassword.UseSystemPasswordChar = true;
            this.cbStaffShowPassword.BackgroundImage = Resources.hide;
        }
        else
        {
            this.txtStaffPassword.UseSystemPasswordChar = false;
            this.cbStaffShowPassword.BackgroundImage = Resources.show;
        }
    }

    private void cbStaffRemeberInfo_CheckedChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(this.txtStaffUsername.Text) && !string.IsNullOrEmpty(this.txtStaffPassword.Text))
        {
            if (this.cbStaffRemeberInfo.Checked)
            {
                Settings.Default.StaffUsername = this.txtStaffUsername.Text;
                Settings.Default.StaffPassword = this.txtStaffPassword.Text;
                Settings.Default.Save();
            }
            else
            {
                Settings.Default.StaffUsername = string.Empty;
                Settings.Default.StaffPassword = string.Empty;
                Settings.Default.Save();
            }
        }
    }

    private void btnStaffLogin_MouseEnter(object sender, EventArgs e)
    {
        this.btnStaffLogin.BackColor = Color.FromArgb(11, 9, 120);
        this.btnStaffLogin.ForeColor = Color.White;
    }

    private void btnStaffLogin_MouseLeave(object sender, EventArgs e)
    {
        this.btnStaffLogin.BackColor = Color.Black;
        this.btnStaffLogin.ForeColor = Color.White;
    }

    private void btnStaffExit_MouseEnter(object sender, EventArgs e)
    {
        this.btnStaffExit.BackColor = Color.FromArgb(11, 9, 120);
        this.btnStaffExit.ForeColor = Color.White;
    }

    private void btnStaffExit_MouseLeave(object sender, EventArgs e)
    {
        this.btnStaffExit.BackColor = SystemColors.Control;
        this.btnStaffExit.ForeColor = Color.Black;
    }

    private void btnStaffExit_Click(object sender, EventArgs e)
    {
        Form bg = new Form();
        CloseWindow logOut = new CloseWindow();
        logOut.Text = "Exit";
        logOut.Confirm.Text = "Exit";
        logOut.Notification.Text = "Do you want to exit?";
        using (logOut)
        {
            bg.StartPosition = FormStartPosition.Manual;
            bg.FormBorderStyle = FormBorderStyle.None;
            bg.BackColor = Color.Black;
            bg.Opacity = 0.7d;
            bg.Size = this.Size;
            bg.Location = this.Location;
            bg.ShowInTaskbar = false;
            bg.Show(this);
            logOut.Owner = bg;
            logOut.ShowDialog(bg);
            bg.Dispose();
        }
        if (!logOut.IsNotClosed)
        {
            this.Close();
        }
    }

    private void btnStaffLogin_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.txtStaffUsername.Text.IsNullOrEmpty())
            {
                MessageBox.Show(this, Properties.Resources.UsernameBlankWarningString, Properties.Resources.WarningTitleString,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (this.txtStaffPassword.Text.IsNullOrEmpty())
            {
                MessageBox.Show(this, Properties.Resources.PasswordBlankWarningString, Properties.Resources.WarningTitleString,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                switch (StaffAccounts.Login(new LoginInfo
                {
                    Username = this.txtStaffUsername.Text,
                    Password = this.txtStaffPassword.Text,
                }))
                {
                    case StaffAccounts.LoginResult.Success:
                        this.StaffSuccessfullyAuthenticated = true;
                        this.Close();
                        break;

                    case StaffAccounts.LoginResult.PasswordError:
                        MessageBox.Show(this, Properties.Resources.PasswordIncorrectWarningString, Properties.Resources.WarningTitleString,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;

                    case StaffAccounts.LoginResult.UsernameError:
                        MessageBox.Show(this, Properties.Resources.UsernameNotFoundWarningString, Properties.Resources.WarningTitleString,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;

                    default:
                        MessageBox.Show(this, Properties.Resources.UnknownErrorString, Properties.Resources.ErrorTitleString,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
