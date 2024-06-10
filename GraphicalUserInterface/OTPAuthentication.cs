using Microsoft.IdentityModel.Tokens;
using DataAccess;
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

namespace GraphicalUserInterface {
	public partial class OTPAuthentication : Form {
		public string Email { get; set; } = "";
		public int OTP { get; set; } = 0;
		private bool confirmOTP = false;
		private Random random = new Random();

		public OTPAuthentication(string email, int otp) {
			InitializeComponent();
			Email = email;
			OTP = otp;
			this.lbEmail.Text = Email;
			this.panelStep2.BackColor = Color.FromArgb(22, 94, 240);
			this.btnOTPAuth.BackColor = Color.FromArgb(22, 94, 240);
		}

        private void btnOTPAuth_Click(object sender, EventArgs e)
        {
            CheckAuthentication();

            if (confirmOTP == false)
            {
                return;
            }
            else
            {
                using (var context = new SavingsManagementContext())
                {
                    var customer = context.CustomerAccounts.FirstOrDefault(c => c.Email == Email);
                    var staff = context.CustomerAccounts.FirstOrDefault(s => s.Email == Email);
                    this.Hide();
                    int customerId = customer != null ? customer.Id : 0;
                    int staffId = staff != null ? staff.Id : 0;
                    ResetPasswordForm resetPasswordForm = new ResetPasswordForm(customerId, staffId);
                    resetPasswordForm.ShowDialog();
                    this.Close();
                }
                confirmOTP = false;
            }
        }


        private void CheckAuthentication() {
			if (OTP.ToString().Equals(txtOTP.Text)) {
				MessageBox.Show("Verify OTP successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
				confirmOTP = true;
			} else {
				MessageBox.Show("OTP is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				confirmOTP = false;
			}
		}

		private void linkBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			this.Hide();
			LoginForm login = new LoginForm();
			login.ShowDialog();
			this.Close();
		}

		private void btnOTPAuth_MouseLeave(object sender, EventArgs e) {
			this.btnOTPAuth.BackColor = Color.FromArgb(22, 94, 240);
		}

		private void btnOTPAuth_MouseEnter(object sender, EventArgs e) {
			this.btnOTPAuth.BackColor = Color.FromArgb(74, 131, 248);
		}

		private void linkResendOTP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			try {
				Cursor.Current = Cursors.WaitCursor;
				OTP = random.Next(100000, 1000000);
				var fromAddres = new MailAddress("truongdacdien2004@gmail.com");
				var toAddress = new MailAddress(Email);
				const string frompass = "jcbm wgxh pyub gfbf";
				const string subject = "OTP code";
				string body = "[RESET PASSWORD]\n" + "\nThis is the OTP code to verify your password reset, please do not share it with anyone!\n" +
							  "\nYour OTP code is: " + OTP.ToString();

				var smtp = new SmtpClient() {
					Host = "smtp.gmail.com",
					Port = 587,
					EnableSsl = true,
					DeliveryMethod = SmtpDeliveryMethod.Network,
					UseDefaultCredentials = false,
					Credentials = new NetworkCredential(fromAddres.Address, frompass),
					Timeout = 200000
				};
				using (var message = new MailMessage(fromAddres, toAddress) {
					Subject = subject,
					Body = body
				}) {
					smtp.Send(message);
				}
				MessageBox.Show("OTP has been sent via your email!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}
	}
}
