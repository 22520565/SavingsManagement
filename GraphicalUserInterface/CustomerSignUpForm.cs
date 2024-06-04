namespace GraphicalUserInterface;

using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public partial class CustomerSignUpForm : Form
{

    public CustomerSignUpForm()
    {
        InitializeComponent();
        InitializeCbShowPassword();
        InitializeCbShowConfirmPassword();
    }

    private void InitializeCbShowPassword()
    {
        cbShowPassword.Appearance = Appearance.Button;
        cbShowPassword.FlatStyle = FlatStyle.Flat;
        cbShowPassword.FlatAppearance.BorderSize = 0;
        cbShowPassword.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\hide.png");
    }

    private void InitializeCbShowConfirmPassword()
    {
        cbShowConfirmPassword.Appearance = Appearance.Button;
        cbShowConfirmPassword.FlatStyle = FlatStyle.Flat;
        cbShowConfirmPassword.FlatAppearance.BorderSize = 0;
        cbShowConfirmPassword.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\hide.png");
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
        btnExit.BackColor = Color.Transparent;
        btnExit.ForeColor = Color.Black;
    }

    private void btnSignUp_MouseEnter(object sender, EventArgs e)
    {
        btnSignUp.BackColor = Color.FromArgb(11, 9, 120);
        btnSignUp.ForeColor = Color.White;
    }

    private void btnSignUp_MouseLeave(object sender, EventArgs e)
    {
        btnSignUp.BackColor = Color.Black;
        btnSignUp.ForeColor = Color.White;
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

    private void linkLabel_Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        this.Hide();
        new LoginForm().ShowDialog();
        this.Close();
    }

    public bool checkUsername(string username)
    {
        //Tối thiểu 3 ký tự, tối đa 24 nằm trong a-z, A-Z, 0-9
        return Regex.IsMatch(username, @"^[\w]{3,24}$");
    }

    public bool checkPasssword(string password)
    {
        //Tối thiểu tám ký tự, ít nhất một chữ cái viết hoa, ít nhất một chữ cái viết thường, ít nhất một số và ít nhất một ký tự đặc biệt
        return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
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

    private void btnSignUp_Click(object sender, EventArgs e)
    {
        //if (!checkUsername(txtUsername.Text)) {
        //	MessageBox.Show("Please enter a username that is 3-24 characters long, including lowercase letters, uppercase letters, and numbers!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //	return;
        //}
        //if (!checkPasssword(txtPassword.Text)) {
        //	MessageBox.Show("Please enter a password of at least 8 characters, at least one uppercase letter, at least one lowercase letter, at least one number and at least one special character!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //	return;
        //}
        //if (txtConfirmPassword.Text != txtPassword.Text) {
        //	MessageBox.Show("Confirmation password is not correct!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //	return;
        //}
        //if (!checkEmail(txtEmail.Text)) {
        //	MessageBox.Show("Email format is incorrect: \n" +
        //					"  - Must have @ character \n" +
        //					"  - The @ character is not at the beginning \n" +
        //					"  - Must have at least one . in the email address\n" +
        //					"  - There must be at least 1 character between @ and . final\n" +
        //					"  - There must be at least one character after the last mark\n" +
        //					"  - There are no spaces in the email address", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //	return;
        //}


        //account.AcUsername = txtUsername.Text;
        //account.AcPassword = txtPassword.Text;
        //account.AcEmail = txtEmail.Text;

        //string signup = bus_account.CheckSignUp(account);

        //switch (signup) {
        //	case "available_username":
        //		MessageBox.Show("Username already exists, please register another username!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //		return;
        //	case "available_email":
        //		MessageBox.Show("Email has been registered, please register another email!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //		return;
        //	case "error":
        //		MessageBox.Show("Registration error!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //		return;
        //	case "successful_signup":
        //		MessageBox.Show("Successfully registered account!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //		break;
        //}
    }


}
