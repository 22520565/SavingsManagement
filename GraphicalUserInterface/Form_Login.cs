using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Entity;

namespace GraphicalUserInterface
{
    public partial class Form_Login : Form
    {
        Account account = new Account();
        BUS_Account bus_account = new BUS_Account();

        public Form_Login()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
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
            DialogResult DR = MessageBox.Show("Do you want to exit?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void linkLabel_ForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form_ForgotPassword forgotPassword = new Form_ForgotPassword();
            forgotPassword.ShowDialog();
            this.Close();
        }

        private void linkLabel_SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form_SignUp signUp = new Form_SignUp();
            signUp.ShowDialog();
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
            account.AcUsername = txtUsername.Text;
            account.AcPassword = txtPassword.Text;

            string login = bus_account.CheckLogin(account);

            switch (login)
            {
                case "disable_account":
                    MessageBox.Show("Account has been disabled!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "requeid_account":
                    MessageBox.Show("User name cannot be blank!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                case "requeid_password":
                    MessageBox.Show("Password cannot be blank!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                case "incorrect_account_and_password":
                    MessageBox.Show("Username or password is incorrect!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                case "successful_login":   
                    MessageBox.Show("Logged in successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form_MainMenu menu = new Form_MainMenu(account, bus_account);
                    menu.ShowDialog();
                    break;
            }
        }

        private void cbRememberInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                if (cbRememberInfo.Checked == true)
                {
                    Properties.Settings.Default.AcUsername = txtUsername.Text;
                    Properties.Settings.Default.AcPassword = txtPassword.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Reset();
                }
            }
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Properties.Settings.Default.AcUsername;
            txtPassword.Text = Properties.Settings.Default.AcPassword;
            if (Properties.Settings.Default.AcUsername != "")
            {
                cbRememberInfo.Checked = true;
            }
        }
    }
}
