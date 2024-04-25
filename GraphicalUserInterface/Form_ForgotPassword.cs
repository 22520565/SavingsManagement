namespace Gui;

using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public partial class Form_ForgotPassword : Form
{
    public Form_ForgotPassword()
    {
        InitializeComponent();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        this.Hide();
        LoginForm login = new LoginForm();
        login.ShowDialog();
        this.Close();
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

    private void btnPasswordRetrieval_MouseEnter(object sender, EventArgs e)
    {
        btnPasswordRetrieval.BackColor = Color.Blue;
        btnPasswordRetrieval.ForeColor = Color.White;
    }

    private void btnPasswordRetrieval_MouseLeave(object sender, EventArgs e)
    {
        btnPasswordRetrieval.BackColor = SystemColors.Control;
        btnPasswordRetrieval.ForeColor = SystemColors.ControlText;
    }

    public bool checkEmail(string email) //check email
    {
        //Phải có ký tự @
        //Ký tự @ không nằm ở vị trí đầu
        //Phải có ít nhất một dấu . trong địa chỉ mail
        //Phải có ít nhất 1 ký tự giữa @ và dấu . cuối cùng
        //Phải có ít nhất một ký tự sau dấu . cuối cùng
        //Không có khoảng trắng trong địa chỉ mail
        return Regex.IsMatch(email, @"^[^\.]([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
    }

    private void btnPasswordRetrieval_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
        {
            MessageBox.Show("Please enter your registration email!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (!checkEmail(txtEmail.Text))
        {
            MessageBox.Show("Email format is incorrect: \n" +
                            "  - Must have @ character \n" +
                            "  - The @ character is not at the beginning \n" +
                            "  - Must have at least one . in the email address\n" +
                            "  - There must be at least 1 character between @ and . final\n" +
                            "  - There must be at least one character after the last mark\n" +
                            "  - There are no spaces in the email address", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        /*account.AcEmail = txtEmail.Text;

        string forgotpassword = bus_account.CheckForgotPassword(account);

        switch (forgotpassword)
        {
            case "not_registered":
                txtResult.BackColor = SystemColors.Control;
                txtResult.ForeColor = Color.Red;
                txtResult.Text = "Email is not registered!";
                break;
            default:
                txtResult.BackColor = Color.Black;
                txtResult.ForeColor = Color.White;
                txtResult.Text = forgotpassword;
                break;
        }*/
    }
}

