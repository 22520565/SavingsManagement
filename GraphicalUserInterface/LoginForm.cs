﻿namespace GraphicalUserInterface;

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
        btnStaffLogin.BackColor = Color.FromArgb(23, 33, 175);
        btnCustomerLogin.BackColor = Color.FromArgb(23, 33, 175);
    }

    private void linkLabel_SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        this.Hide();
        CurrentForm.SetSelectedForm(CurrentForm.OpenForm.SignUp);
        this.Close();
    }

    private void linkLabel_ForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        this.Hide();
        CurrentForm.SetSelectedForm(CurrentForm.OpenForm.Forgot);
        this.Close();
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        this.Hide();
        CurrentForm.SetSelectedForm(CurrentForm.OpenForm.SignUp);
        this.Close();
    }

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        this.Hide();
        CurrentForm.SetSelectedForm(CurrentForm.OpenForm.Forgot);
        this.Close();
    }

    private void btnCustomerLogin_MouseEnter(object sender, EventArgs e)
    {
        btnCustomerLogin.BackColor = Color.FromArgb(74, 131, 248);
    }

    private void btnCustomerLogin_MouseLeave(object sender, EventArgs e)
    {
        btnCustomerLogin.BackColor = Color.FromArgb(23, 33, 175);
    }

    private void btnExit_MouseEnter(object sender, EventArgs e)
    {
        btnExit.BackColor = Color.FromArgb(226, 55, 52);
        btnExit.ForeColor = Color.White;
    }

    private void btnExit_MouseLeave(object sender, EventArgs e)
    {
        btnExit.BackColor = Color.White;
        btnExit.ForeColor = Color.Black;
    }

    private void cbCustomerShowPassword_CheckedChanged(object sender, EventArgs e)
    {
        if (!cbCustomerShowPassword.Checked)
        {
            txtCustomerPassword.UseSystemPasswordChar = true;
            cbCustomerShowPassword.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\hide.png");
        }
        else
        {
            txtCustomerPassword.UseSystemPasswordChar = false;
            cbCustomerShowPassword.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\show.png");
        }

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

                if (cbCustomerRememberInfo.Checked)
                {
                    Properties.Settings.Default.AcUsername = txtCustomerUsername.Text;
                    Properties.Settings.Default.AcPassword = txtCustomerPassword.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.AcUsername = string.Empty;
                    Properties.Settings.Default.AcPassword = string.Empty;
                    Properties.Settings.Default.Save();
                }

                switch (CustomerAccounts.Login(new LoginInfo
                {
                    Username = txtCustomerUsername.Text,
                    Password = txtCustomerPassword.Text,
                }))
                {
                    case CustomerAccounts.LoginResult.Success:
                        CurrentForm.SetSelectedForm(CurrentForm.OpenForm.Customer);
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
        
        
    }

    private void LoginForm_Load(object sender, EventArgs e)
    {

        CustomerAccounts.LogOut();
        txtCustomerUsername.Text = Properties.Settings.Default.AcUsername;
        txtCustomerPassword.Text = Properties.Settings.Default.AcPassword;
        cbCustomerRememberInfo.Checked = !Properties.Settings.Default.AcUsername.IsNullOrEmpty();

        // Show password checkbox custom
        cbCustomerShowPassword.Appearance = Appearance.Button;
        cbCustomerShowPassword.FlatStyle = FlatStyle.Flat;
        cbCustomerShowPassword.FlatAppearance.BorderSize = 0;
        cbCustomerShowPassword.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\hide.png");

        StaffAccounts.LogOut();
        txtStaffUsername.Text = Properties.Settings.Default.StaffUsername;
        txtStaffPassword.Text = Properties.Settings.Default.StaffPassword;
        cbStaffRemeberInfo.Checked = !Properties.Settings.Default.StaffUsername.IsNullOrEmpty();

        // Show password checkbox custom
        cbStaffShowPassword.Appearance = Appearance.Button;
        cbStaffShowPassword.FlatStyle = FlatStyle.Flat;
        cbStaffShowPassword.FlatAppearance.BorderSize = 0;
        cbStaffShowPassword.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\hide.png");
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
        if (logOut.IsNotClosed == false)
        {
            CurrentForm.SetSelectedForm(CurrentForm.OpenForm.Exit);
            this.Close();
        }
    }

    private void cbStaffShowPassword_CheckedChanged(object sender, EventArgs e)
    {
        if (!cbStaffShowPassword.Checked)
        {
            txtStaffPassword.UseSystemPasswordChar = true;
            cbStaffShowPassword.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\hide.png");
        }
        else
        {
            txtStaffPassword.UseSystemPasswordChar = false;
            cbStaffShowPassword.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\show.png");
        }
    }

    private void btnStaffLogin_MouseEnter(object sender, EventArgs e)
    {
        btnStaffLogin.BackColor = Color.FromArgb(74, 131, 248);
    }

    private void btnStaffLogin_MouseLeave(object sender, EventArgs e)
    {
        btnStaffLogin.BackColor = Color.FromArgb(23, 33, 175);
    }

    private void btnStaffExit_MouseEnter(object sender, EventArgs e)
    {
        btnStaffExit.BackColor = Color.FromArgb(226, 55, 52);
        btnStaffExit.ForeColor = Color.White;
    }

    private void btnStaffExit_MouseLeave(object sender, EventArgs e)
    {
        btnStaffExit.BackColor = Color.White;
        btnStaffExit.ForeColor = Color.Black;
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
        if (logOut.IsNotClosed == false)
        {
            CurrentForm.SetSelectedForm(CurrentForm.OpenForm.Exit);
            this.Close();
        }
    }

    private void btnStaffLogin_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtStaffUsername.Text.IsNullOrEmpty())
            {
                MessageBox.Show(this, Properties.Resources.UsernameBlankWarningString, Properties.Resources.WarningTitleString,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtStaffPassword.Text.IsNullOrEmpty())
            {
                MessageBox.Show(this, Properties.Resources.PasswordBlankWarningString, Properties.Resources.WarningTitleString,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (cbStaffRemeberInfo.Checked)
                {
                    Properties.Settings.Default.StaffUsername = txtStaffUsername.Text;
                    Properties.Settings.Default.StaffPassword = txtStaffPassword.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.StaffUsername = string.Empty;
                    Properties.Settings.Default.StaffPassword = string.Empty;
                    Properties.Settings.Default.Save();
                }
                switch (StaffAccounts.Login(new LoginInfo
                {
                    Username = txtStaffUsername.Text,
                    Password = txtStaffPassword.Text,
                }))
                {
                    case StaffAccounts.LoginResult.Success:
                        CurrentForm.SetSelectedForm(CurrentForm.OpenForm.Staff);
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

                    case StaffAccounts.LoginResult.Disabled:
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
}
