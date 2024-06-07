﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using DataAccess;
using Microsoft.AspNetCore.Identity;

namespace GraphicalUserInterface
{
    public partial class ResetPasswordForm : Form
    {
        private static readonly PasswordHasher<String> PasswordHasher = new();
        private int customerID;

        public ResetPasswordForm(int customerId)
        {
            InitializeComponent();
            this.customerID = customerId;
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
                cbShowPassword.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\hide.png");
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
                cbShowPassword.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\show.png");
            }
        }

        private void cbShowConfirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbShowConfirmPassword.Checked)
            {
                txtConfirmPassword.UseSystemPasswordChar = true;
                cbShowConfirmPassword.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\hide.png");
            }
            else
            {
                txtConfirmPassword.UseSystemPasswordChar = false;
                cbShowConfirmPassword.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\show.png");
            }
        }

        public bool checkPasssword(string password)
        {
            //Tối thiểu tám ký tự, ít nhất một chữ cái viết hoa, ít nhất một chữ cái viết thường, ít nhất một số và ít nhất một ký tự đặc biệt
            return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
        }

        private void btnConfirmPassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                MessageBox.Show("Please fill in all blanks!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!checkPasssword(txtPassword.Text))
            {
                MessageBox.Show("Please enter a password of at least 8 characters, at least one uppercase letter, at least one lowercase letter, at least one number and at least one special character!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                MessageBox.Show("Confirmation password is not correct!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mã hóa mật khẩu
            string hashedPassword = PasswordHasher.HashPassword(null!, txtConfirmPassword.Text);

            using (var context = new SavingsManagementContext())
            {
                var customer = context.CustomerAccounts.FirstOrDefault(c => c.Id == customerID);
                if (customer != null)
                {
                    customer.HashedPassword = hashedPassword;
                    context.SaveChanges();
                    MessageBox.Show("Reset password successfully, you can login now!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
            this.Close();
        }

        private void btnConfirmPassword_MouseEnter(object sender, EventArgs e)
        {
            btnConfirmPassword.BackColor = Color.FromArgb(11, 9, 120);
            btnConfirmPassword.ForeColor = Color.White;
        }

        private void btnConfirmPassword_MouseLeave(object sender, EventArgs e)
        {
            btnConfirmPassword.BackColor = Color.Black;
            btnConfirmPassword.ForeColor = Color.White;
        }
    }
}