namespace Gui;

using System;
using System.Drawing;
using System.Windows.Forms;
using Business;
using Microsoft.IdentityModel.Tokens;

public partial class LoginForm : Form
{

    public LoginForm()
    {
        InitializeComponent();
    }

    private void btnExit_MouseEnter(object sender, EventArgs e)
    {
        btnExit.BackColor = Color.Red;
        btnExit.ForeColor = Color.White;
    }

    private void btnExit_MouseLeave(object sender, EventArgs e)
    {
        btnExit.BackColor = SystemColors.Control;
        btnExit.ForeColor = SystemColors.ControlText;
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show(Resources.ExitConfirmationString, Resources.NotificationTitleString,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == DialogResult.Yes)
        {
            Application.Exit();
        }
    }

    private void linkLabel_ForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        this.Hide();
        new Form_ForgotPassword().ShowDialog();
        this.Close();
    }

    private void linkLabel_SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        this.Hide();
        new Form_SignUp().ShowDialog();
        this.Close();
    }

    private void btnLogin_MouseEnter(object sender, EventArgs e)
    {
        btnLogin.BackColor = Color.Blue;
        btnLogin.ForeColor = Color.White;
    }

    private void btnLogin_MouseLeave(object sender, EventArgs e)
    {
        btnLogin.BackColor = SystemColors.Control;
        btnLogin.ForeColor = SystemColors.ControlText;
    }

    private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
    {
        if (cbShowPassword.Checked)
        {
            txtPassword.UseSystemPasswordChar = false;
        }
        if (!cbShowPassword.Checked)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtUsername.Text.IsNullOrEmpty())
            {
                MessageBox.Show(this, Resources.UsernameBlankWarningString, Resources.WarningTitleString,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPassword.Text.IsNullOrEmpty())
            {
                MessageBox.Show(this, Resources.PasswordBlankWarningString, Resources.WarningTitleString,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                switch (CustomerAccounts.Login(new LoginInfo
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                }))
                {
                    case CustomerAccounts.LoginResult.Success:
                        new Form_MainMenu().Show();
                        this.Close();
                        break;

                    case CustomerAccounts.LoginResult.PasswordError:
                        MessageBox.Show(this, Resources.PasswordIncorrectWarningString, Resources.WarningTitleString,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;

                    case CustomerAccounts.LoginResult.UsernameError:
                        MessageBox.Show(this, Resources.UsernameNotFoundWarningString, Resources.WarningTitleString,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;

                    case CustomerAccounts.LoginResult.MultiUsernameError:
                        MessageBox.Show(this, Resources.UnknownErrorString, Resources.ErrorTitleString,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;

                    default:
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void cbRememberInfo_CheckedChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
        {
            if (cbRememberInfo.Checked)
            {
                Settings.Default.AcUsername = txtUsername.Text;
                Settings.Default.AcPassword = txtPassword.Text;
                Settings.Default.Save();
            }
            else
            {
                Settings.Default.Reset();
            }
        }
    }

    private void LoginForm_Load(object sender, EventArgs e)
    {
        txtUsername.Text = Settings.Default.AcUsername;
        txtPassword.Text = Settings.Default.AcPassword;
        if (!string.IsNullOrEmpty(Settings.Default.AcUsername))
        {
            cbRememberInfo.Checked = true;
        }
    }
}
