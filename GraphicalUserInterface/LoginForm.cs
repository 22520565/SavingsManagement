﻿namespace Gui;

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
        using var passwordRecoveryForm = new Form_ForgotPassword();
        this.Hide();
        passwordRecoveryForm.ShowDialog(this);
        this.Show();
    }

    private void linkLabel_SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        this.Hide();
        new Form_SignUp().ShowDialog();
        this.Close();
    }

    private void btnLogin_MouseEnter(object sender, EventArgs e)
    {
        btnCustomerLogin.BackColor = Color.Blue;
        btnCustomerLogin.ForeColor = Color.White;
    }

    private void btnLogin_MouseLeave(object sender, EventArgs e)
    {
        btnCustomerLogin.BackColor = SystemColors.Control;
        btnCustomerLogin.ForeColor = SystemColors.ControlText;
    }

    private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
    {
        txtCustomerPassword.UseSystemPasswordChar = !cbCustomerShowPassword.Checked;
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtCustomerUsername.Text.IsNullOrEmpty())
            {
                MessageBox.Show(this, Resources.UsernameBlankWarningString, Resources.WarningTitleString,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtCustomerPassword.Text.IsNullOrEmpty())
            {
                MessageBox.Show(this, Resources.PasswordBlankWarningString, Resources.WarningTitleString,
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
        if (!string.IsNullOrEmpty(txtCustomerUsername.Text) && !string.IsNullOrEmpty(txtCustomerPassword.Text))
        {
            if (cbCustomerRememberInfo.Checked)
            {
                Settings.Default.AcUsername = txtCustomerUsername.Text;
                Settings.Default.AcPassword = txtCustomerPassword.Text;
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
        this.UserSuccessfullyAuthenticated = false;
        txtCustomerUsername.Text = Settings.Default.AcUsername;
        txtCustomerPassword.Text = Settings.Default.AcPassword;
        if (!string.IsNullOrEmpty(Settings.Default.AcUsername))
        {
            cbCustomerRememberInfo.Checked = true;
        }
    }
}
