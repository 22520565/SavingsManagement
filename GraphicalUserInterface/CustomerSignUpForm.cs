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
    private Random random = new Random();
    private int otp;
    private bool confirmOTP = false;

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

    private void getOTPBtn_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtEmail.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Enter email to get OTP!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            otp = random.Next(100000, 1000000);
            var fromAddres = new MailAddress("truongdacdien2004@gmail.com");
            var toAddress = new MailAddress(txtEmail.Text);
            const string frompass = "jcbm wgxh pyub gfbf";
            const string subject = "OTP code";
            string body = "[REGISTER ACCOUNT]\n" + "\nThis is the OTP code to verify account registration, please do not share with anyone!\n" +
                          "\nYour OTP code is: " + otp.ToString();

            var smtp = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddres.Address, frompass),
                Timeout = 200000
            };
            using (var message = new MailMessage(fromAddres, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
            MessageBox.Show("OTP has been sent via your email!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void confirmOTPBtn_Click(object sender, EventArgs e)
    {
        if (otp.ToString().Equals(txtOTP.Text))
        {
            MessageBox.Show("Verify OTP successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            confirmOTP = true;
        }
        else
        {
            MessageBox.Show("OTP is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            confirmOTP= false;
        }
    }

    private void CreateAccount()
    {
        // Mã hóa mật khẩu
        string hashedPassword = PasswordHasher.HashPassword(null!, txtConfirmPassword.Text);

        using (var context = new SavingsManagementContext())
        {
            var customer = new CustomerAccount
            {
                Name = "Customer",
                IsMale = false,
                CicNumber = "0",
                BirthDate = new DateOnly(DateTime.Now.Date.Year, DateTime.Now.Date.Month, DateTime.Now.Date.Day),
                PhoneNumber = "0",
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

    private void btnSignUp_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text)
        || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtOTP.Text))
        {
            MessageBox.Show("Please fill in all blanks!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (!checkUsername(txtUsername.Text))
        {
            MessageBox.Show("Please enter a username that is 3-24 characters long, including lowercase letters, uppercase letters, and numbers!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        if (IsUsernameExists(txtUsername.Text))
        {
            MessageBox.Show("Username already exists, please register another username!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (IsEmailExists(txtEmail.Text))
        {
            MessageBox.Show("Email has been registered, please register another email!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (confirmOTP == false)
        {
            MessageBox.Show("Please enter the OTP sent to your email to complete the registration.", "OTP Verification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        else
        {
            CreateAccount();
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
            this.Close();
            confirmOTP = false;
        }
    }
}
