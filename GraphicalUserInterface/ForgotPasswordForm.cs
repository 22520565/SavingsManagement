using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using DataAccess;
using Business;

namespace GraphicalUserInterface
{
    public partial class ForgotPasswordForm : Form
    {
        private Random random = new Random();
        private int otp;
        private bool confirmOTP = false;

        public ForgotPasswordForm()
        {
            InitializeComponent();
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
                if (!IsEmailExists(txtEmail.Text))
                {
                    MessageBox.Show("Email is not registered, please enter another email!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                otp = random.Next(100000, 1000000);
                var fromAddres = new MailAddress("truongdacdien2004@gmail.com");
                var toAddress = new MailAddress(txtEmail.Text);
                const string frompass = "jcbm wgxh pyub gfbf";
                const string subject = "OTP code";
                string body = "[RESET PASSWORD]\n" + "\nThis is the OTP code to verify your password reset, please do not share it with anyone!\n" +
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
                confirmOTP = false;
            }
        }

        private bool IsEmailExists(string email)
        {
            using (var context = new SavingsManagementContext())
            {
                return context.CustomerAccounts.Any(c => c.Email == email);
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtOTP.Text))
            {
                MessageBox.Show("Please fill in all blanks!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (confirmOTP == false)
            {
                MessageBox.Show("Please enter the OTP sent to your email to reset your password!", "OTP Verification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {

                using (var context = new SavingsManagementContext())
                {
                    var customer = context.CustomerAccounts.FirstOrDefault(c => c.Email == txtEmail.Text);
                    if (customer != null)
                    {
                        this.Hide();
                        ResetPasswordForm resetPasswordForm = new ResetPasswordForm(customer.Id);
                        resetPasswordForm.ShowDialog();
                        this.Close();
                    }
                }
                confirmOTP = false;
            }
        }

        private void btnResetPassword_MouseEnter(object sender, EventArgs e)
        {
            btnResetPassword.BackColor = Color.FromArgb(11, 9, 120);
            btnResetPassword.ForeColor = Color.White;
        }

        private void btnResetPassword_MouseLeave(object sender, EventArgs e)
        {
            btnResetPassword.BackColor = Color.Black;
            btnResetPassword.ForeColor = Color.White;
        }
    }
}
