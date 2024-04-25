namespace GraphicalUserInterface;

using System;
using System.Drawing;
using System.Windows.Forms;
using Business;
using Microsoft.IdentityModel.Tokens;

public partial class LoginForm : Form
{
    public bool UserSuccessfullyAuthenticated { get; private set; } = false;

    public LoginForm()
    {
        InitializeComponent();
    }

    private void linkLabel_ForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        using var passwordRecoveryForm = new ForgotPasswordForm();
        this.Hide();
        passwordRecoveryForm.ShowDialog(this);
        this.Show();
    }

    private void linkLabel_SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        this.Hide();
        new CustomerSignUpForm().ShowDialog();
        this.Close();
    }

    private void btnCustomerLogin_MouseEnter(object sender, EventArgs e)
    {
        btnCustomerLogin.BackColor = Color.Blue;
        btnCustomerLogin.ForeColor = Color.White;
    }

    private void btnCustomerLogin_MouseLeave(object sender, EventArgs e)
    {
        btnCustomerLogin.BackColor = SystemColors.Control;
        btnCustomerLogin.ForeColor = SystemColors.ControlText;
    }

    private void cbCustomerShowPassword_CheckedChanged(object sender, EventArgs e)
    {
        txtCustomerPassword.UseSystemPasswordChar = !cbCustomerShowPassword.Checked;
    }

    private void btnCustomerLogin_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtCustomerUsername.Text.IsNullOrEmpty())
            {
                MessageBox.Show(this, Properties.Resources.UsernameBlankWarningString, Properties.Resources.WarningTitleString,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtCustomerPassword.Text.IsNullOrEmpty())
            {
                MessageBox.Show(this, Properties.Resources.PasswordBlankWarningString, Properties.Resources.WarningTitleString,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                switch (CustomerAccounts.Login(new LoginInfo
                {
                    Username = txtCustomerUsername.Text,
                    Password = txtCustomerPassword.Text,
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
        if (!string.IsNullOrEmpty(txtCustomerUsername.Text) && !string.IsNullOrEmpty(txtCustomerPassword.Text))
        {
            if (cbCustomerRememberInfo.Checked)
            {
                Properties.Settings.Default.AcUsername = txtCustomerUsername.Text;
                Properties.Settings.Default.AcPassword = txtCustomerPassword.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Reset();
            }
        }
    }

    private void LoginForm_Load(object sender, EventArgs e)
    {
        this.UserSuccessfullyAuthenticated = false;
        CustomerAccounts.LogOut();
        txtCustomerUsername.Text = Properties.Settings.Default.AcUsername;
        txtCustomerPassword.Text = Properties.Settings.Default.AcPassword;
        cbCustomerRememberInfo.Checked = !Properties.Settings.Default.AcUsername.IsNullOrEmpty();
    }

    private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (!this.UserSuccessfullyAuthenticated &&
            MessageBox.Show(Properties.Resources.ExitConfirmationString, Properties.Resources.NotificationTitleString,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            != DialogResult.Yes)
        {
            e.Cancel = true;
        }
    }
}
