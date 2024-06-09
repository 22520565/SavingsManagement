using System;
using System.Windows.Forms;
using System.Drawing;
using Business;
using GraphicalUserInterface.Properties;

namespace GraphicalUserInterface
{
	public partial class PasswordChangingForm : Form {
		private string accounttype;
		public PasswordChangingForm(string accounttype) {
			this.InitializeComponent();
			this.SetUpToggle();
			this.accounttype = accounttype;

			this.btnConfirm.BackColor = Color.FromArgb(23, 33, 175);
		}

		private void btnConfirm_Click(object sender, EventArgs e) {
			try {
				string oldPassword = this.txtOldPass.Text;
				string newPassword = this.txtNewPass.Text;
				string confirmPassword = this.txtConfirmNew.Text;
				if (!confirmPassword.Equals(newPassword, StringComparison.Ordinal)) {
					MessageBox.Show(this, Resources.ConfirmationPasswordNotMatchedString, Resources.ErrorTitleString,
						MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				} else {
					if (accounttype == "Customer") {
						switch (CustomerAccounts.ChangePassword(oldPassword, newPassword)) {
							case CustomerAccounts.PasswordChangingResult.Success:
								MessageBox.Show(this, Resources.PasswordChangingSuccessfullyString, Resources.NotificationTitleString,
									MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
								this.Close();
								break;

							case CustomerAccounts.PasswordChangingResult.EmptyOldPassword:
								MessageBox.Show(this, Resources.OldPasswordEmptyString, Resources.NotificationTitleString,
									MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
								break;

							case CustomerAccounts.PasswordChangingResult.InvalidNewPassword:
								MessageBox.Show(this, "Please enter a password of at least 8 characters, at least one uppercase letter, at least one lowercase letter, at least one number and at least one special character!", Resources.NotificationTitleString,
									MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
								break;

							case CustomerAccounts.PasswordChangingResult.WrongOldPassword:
								MessageBox.Show(this, Resources.OldPasswordIncorrectString, Resources.NotificationTitleString,
									MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
								break;

							default:
								MessageBox.Show(this, Resources.UnknownErrorString, Resources.ErrorTitleString,
									MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
								break;
						}
					} else if (accounttype == "Staff") {
						switch (StaffAccounts.ChangePassword(oldPassword, newPassword)) {
							case StaffAccounts.PasswordChangingResult.Success:
								MessageBox.Show(this, Resources.PasswordChangingSuccessfullyString, Resources.NotificationTitleString,
									MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
								this.Close();
								break;

							case StaffAccounts.PasswordChangingResult.EmptyOldPassword:
								MessageBox.Show(this, Resources.OldPasswordEmptyString, Resources.NotificationTitleString,
									MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
								break;

							case StaffAccounts.PasswordChangingResult.InvalidNewPassword:
								MessageBox.Show(this, "Please enter a password of at least 8 characters, at least one uppercase letter, at least one lowercase letter, at least one number and at least one special character!", Resources.NotificationTitleString,
									MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
								break;

							case StaffAccounts.PasswordChangingResult.WrongOldPassword:
								MessageBox.Show(this, Resources.OldPasswordIncorrectString, Resources.NotificationTitleString,
									MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
								break;

							default:
								MessageBox.Show(this, Resources.UnknownErrorString, Resources.ErrorTitleString,
									MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
								break;
						}
					}
				}
			} catch (Exception ex) {
				MessageBox.Show(this, ex.Message, ex.Source,
					MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
			}
		}

		private void SetUpToggle() {
			cbShowPassword.Appearance = Appearance.Button;
			cbShowPassword.FlatStyle = FlatStyle.Flat;
			cbShowPassword.FlatAppearance.BorderSize = 0;
			cbShowPassword.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\hide.png");

			cbShowNewPassword.Appearance = Appearance.Button;
			cbShowNewPassword.FlatStyle = FlatStyle.Flat;
			cbShowNewPassword.FlatAppearance.BorderSize = 0;
			cbShowNewPassword.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\hide.png");

			cbShowConfirmPassword.Appearance = Appearance.Button;
			cbShowConfirmPassword.FlatStyle = FlatStyle.Flat;
			cbShowConfirmPassword.FlatAppearance.BorderSize = 0;
			cbShowConfirmPassword.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\hide.png");
		}

		private void cbShowPassword_CheckedChanged(object sender, EventArgs e) {
			if (!cbShowPassword.Checked) {
				txtOldPass.UseSystemPasswordChar = true;
				cbShowPassword.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\hide.png");
			} else {
				txtOldPass.UseSystemPasswordChar = false;
				cbShowPassword.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\show.png");
			}
		}

		private void cbShowNewPassword_CheckedChanged(object sender, EventArgs e) {
			if (!cbShowNewPassword.Checked) {
				txtNewPass.UseSystemPasswordChar = true;
				cbShowNewPassword.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\hide.png");
			} else {
				txtNewPass.UseSystemPasswordChar = false;
				cbShowNewPassword.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\show.png");
			}
		}

		private void cbShowConfirmPassword_CheckedChanged(object sender, EventArgs e) {
			if (!cbShowConfirmPassword.Checked) {
				txtConfirmNew.UseSystemPasswordChar = true;
				cbShowConfirmPassword.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\hide.png");
			} else {
				txtConfirmNew.UseSystemPasswordChar = false;
				cbShowConfirmPassword.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\show.png");
			}
		}
	}
}
