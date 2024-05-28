namespace GraphicalUserInterface;

using System;
using System.Drawing;
using System.Windows.Forms;
using Business;
using Microsoft.IdentityModel.Tokens;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

public partial class LoginForm : Form {
	public bool UserSuccessfullyAuthenticated { get; private set; } = false;

	public LoginForm() {
		InitializeComponent();
	}

	private void linkLabel_SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
		this.Hide();
		new CustomerSignUpForm().ShowDialog();
		this.Close();
	}

	private void btnCustomerLogin_MouseEnter(object sender, EventArgs e) {
		btnCustomerLogin.BackColor = Color.FromArgb(11, 9, 120);
		btnCustomerLogin.ForeColor = Color.White;
	}

	private void btnCustomerLogin_MouseLeave(object sender, EventArgs e) {
		btnCustomerLogin.BackColor = Color.Black;
		btnCustomerLogin.ForeColor = Color.White;
	}

	private void btnExit_MouseEnter(object sender, EventArgs e) {
		btnExit.BackColor = Color.FromArgb(11, 9, 120);
		btnExit.ForeColor = Color.White;
	}

	private void btnExit_MouseLeave(object sender, EventArgs e) {
		btnExit.BackColor = SystemColors.Control;
		btnExit.ForeColor = Color.Black;
	}

	private void cbCustomerShowPassword_CheckedChanged(object sender, EventArgs e) {
		if (!cbCustomerShowPassword.Checked) {
			txtCustomerPassword.UseSystemPasswordChar = true;
			cbCustomerShowPassword.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\hide.png");
		} else {
			txtCustomerPassword.UseSystemPasswordChar = false;
			cbCustomerShowPassword.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\show.png");
		}
		
	}

	private void btnCustomerLogin_Click(object sender, EventArgs e) {
		try {
			if (txtCustomerUsername.Text.IsNullOrEmpty()) {
				MessageBox.Show(this, Properties.Resources.UsernameBlankWarningString, Properties.Resources.WarningTitleString,
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else if (txtCustomerPassword.Text.IsNullOrEmpty()) {
				MessageBox.Show(this, Properties.Resources.PasswordBlankWarningString, Properties.Resources.WarningTitleString,
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
			} else {
				switch (CustomerAccounts.Login(new LoginInfo {
					Username = txtCustomerUsername.Text,
					Password = txtCustomerPassword.Text,
				})) {
					case CustomerAccounts.LoginResult.Success:
						this.UserSuccessfullyAuthenticated = true;
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
		} catch (Exception ex) {
			MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}

	private void cbCustomerRememberInfo_CheckedChanged(object sender, EventArgs e) {
		if (!string.IsNullOrEmpty(txtCustomerUsername.Text) && !string.IsNullOrEmpty(txtCustomerPassword.Text)) {
			if (cbCustomerRememberInfo.Checked) {
				Properties.Settings.Default.AcUsername = txtCustomerUsername.Text;
				Properties.Settings.Default.AcPassword = txtCustomerPassword.Text;
				Properties.Settings.Default.Save();
			} else {
				Properties.Settings.Default.Reset();
			}
		}
	}

	private void LoginForm_Load(object sender, EventArgs e) {
		this.UserSuccessfullyAuthenticated = false;
		CustomerAccounts.LogOut();
		txtCustomerUsername.Text = Properties.Settings.Default.AcUsername;
		txtCustomerPassword.Text = Properties.Settings.Default.AcPassword;
		cbCustomerRememberInfo.Checked = !Properties.Settings.Default.AcUsername.IsNullOrEmpty();

		// Show password checkbox custom
		cbCustomerShowPassword.Appearance = Appearance.Button;
		cbCustomerShowPassword.FlatStyle = FlatStyle.Flat;
		cbCustomerShowPassword.FlatAppearance.BorderSize = 0;
		cbCustomerShowPassword.BackgroundImage = Image.FromFile("..\\..\\..\\Resources\\hide.png");

	}

	private void btnExit_Click(object sender, EventArgs e) {
		Form bg = new Form();
		CloseWindow logOut = new CloseWindow();
		logOut.Text = "Exit";
		logOut.Confirm.Text = "Exit";
		logOut.Notification.Text = "Do you want to exit?";
		using (logOut) {
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
		if (logOut.IsNotClosed == false) {
			Application.Exit();
		}
	}


}
