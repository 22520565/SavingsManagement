namespace GraphicalUserInterface;

using System;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Business;
using DataAccess;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

public partial class CustomerSignUpForm : Form
{
    private static readonly PasswordHasher<String> PasswordHasher = new();

    public CustomerSignUpForm()
    {
        InitializeComponent();
        InitializeCbShowPassword();
        InitializeCbShowConfirmPassword();
		btnSignUp.BackColor = Color.FromArgb(23, 33, 175);
        typeAccountComboBox.SelectedIndex = 0;
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

    private void btnSignUp_MouseEnter(object sender, EventArgs e)
    {
        btnSignUp.BackColor = Color.FromArgb(74, 131, 248);
	}

    private void btnSignUp_MouseLeave(object sender, EventArgs e)
    {
        btnSignUp.BackColor = Color.FromArgb(23, 33, 175);
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

    private bool IsUsernameExists(string username)
    {
        using (var context = new SavingsManagementContext())
        {
            return context.CustomerAccounts.Any(c => c.Username == username);
        }
    }

    private bool IsEmailExists(string email)
    {
        using (var context = new SavingsManagementContext())
        {
            return context.CustomerAccounts.Any(c => c.Email == email);
        }
    }
    private bool IsStaffUsernameExists(string username)
    {
        using (var context = new SavingsManagementContext())
        {
            return context.StaffAccounts.Any(s => s.Username == username);
        }
    }

    private bool IsStaffEmailExists(string email)
    {
        using (var context = new SavingsManagementContext())
        {
            return context.StaffAccounts.Any(c => c.Email == email);
        }
    }

    private void CreateAccount()
    {
        Cursor.Current = Cursors.WaitCursor;
        // Mã hóa mật khẩu
        string hashedPassword = PasswordHasher.HashPassword(null!, txtConfirmPassword.Text);
        if (typeAccountComboBox.SelectedItem == typeAccountComboBox.Items[0])
        {
            using (var context = new SavingsManagementContext())
            {
                var customer = new CustomerAccount
                {
                    Name = "Customer",
                    IsMale = false,
                    CicNumber = "0",
                    BirthDate = new DateOnly(DateTime.Now.Date.Year, DateTime.Now.Date.Month, DateTime.Now.Date.Day),
                    PhoneNumber = "0123456789",
                    Address = "Việt Nam",
                    Email = txtEmail.Text,
                    Username = txtUsername.Text,
                    HashedPassword = hashedPassword,
                    Balance = Decimal.Zero,
                    IsDisabled = false
                };
                context.CustomerAccounts.Add(customer);
                context.SaveChanges();
                MessageBox.Show("Successfully registered account!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        else
        {
            using (var context = new SavingsManagementContext())
            {
                var staff = new StaffAccount
                {
                    Name = "Staff",
                    IsMale = false,
                    Position = "Staff",
                    BirthDate = new DateOnly(DateTime.Now.Date.Year, DateTime.Now.Date.Month, DateTime.Now.Date.Day),
                    PhoneNumber = "0123456789",
                    Address = "Việt Nam",
                    Email = txtEmail.Text,
                    Username = txtUsername.Text,
                    HashedPassword = hashedPassword,
                    PermissionId = 2,
                    IsDisabled = false
                };

                context.StaffAccounts.Add(staff);
                context.SaveChanges();
                MessageBox.Show("Successfully registered account!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    private void btnSignUp_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text)
        || string.IsNullOrEmpty(txtEmail.Text))
        {
            MessageBox.Show("Please fill in all blanks!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!checkUsername(txtUsername.Text))
        {
            MessageBox.Show("Please enter a username that is 3-24 characters long, including lowercase letters, uppercase letters, and numbers!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

		if (IsUsernameExists(txtUsername.Text) || IsStaffUsernameExists(txtUsername.Text)) {
			MessageBox.Show("Username already exists, please register another username!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return;
		}

		if (IsEmailExists(txtEmail.Text) || IsStaffEmailExists(txtEmail.Text)) {
			MessageBox.Show("Email has been registered, please register another email!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return;
		}

		if (!checkEmail(txtEmail.Text)) {
			MessageBox.Show("Email format is incorrect: \n" +
							"  - Must have @ character \n" +
							"  - The @ character is not at the beginning \n" +
							"  - Must have at least one . in the email address\n" +
							"  - There must be at least 1 character between @ and . final\n" +
							"  - There must be at least one character after the last mark\n" +
							"  - There are no spaces in the email address", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return;
		}

		if (!checkPasssword(txtPassword.Text))
        {
            MessageBox.Show("Please enter a password of at least 8 characters, at least one uppercase letter, at least one lowercase letter, at least one number and at least one special character of {@,$,!,%,*,?,& } !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (txtConfirmPassword.Text != txtPassword.Text)
        {
            MessageBox.Show("Confirmation password is not correct!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

		CreateAccount();
		this.Hide();
		LoginForm login = new LoginForm();
		login.ShowDialog();
		this.Close();
	}
}
