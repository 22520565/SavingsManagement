using Business;
using DataAccess;
using GraphicalUserInterface.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalUserInterface
{
	public partial class StaffChangeInfo : Form {
		public StaffChangeInfo() {
			InitializeComponent();
			LoadUI();
			LoadingAccountInfo();
		}

		private void LoadUI() {
			this.BackColor = Color.FromArgb(247, 253, 255);
			this.panelAvt.BackColor = Color.FromArgb(211, 245, 255);
		}

		public void LoadingAccountInfo() {
			try {
				StaffAccount? staffAccount = StaffAccounts.CurrentStaffAccount;
				if (staffAccount is not null) {
					this.staffNameTextBox.Text = staffAccount.Name;
					this.lbStaffName.Text = staffAccount.Name;
					if (staffAccount.IsMale) {
						rbMale.Checked = true;
					} else {
						rbFemale.Checked = true;
					}
					this.staffPositionTextBox.Text = staffAccount.Position;
					this.staffBirthDateTimePicker.Text = staffAccount.BirthDate.ToString(CultureInfo.CurrentCulture);
					this.staffPhoneNumberTextBox.Text = staffAccount.PhoneNumber;
					this.staffEmailTextBox.Text = staffAccount.Email;
					this.staffAddressTextBox.Text = staffAccount.Address;
					this.staffUsernameTextBox.Text = staffAccount.Username;
				} else {
					MessageBox.Show(this, Resources.FailedLoadingCustomerInfoString, Resources.ErrorTitleString,
						MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				}
			} catch (Exception ex) {
				MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void staffChangeInfoButton_Click(object sender, EventArgs e) {
			bool isValid = IsValidPhoneNumber(staffPhoneNumberTextBox.Text);
			bool isValidEmail = IsValidEmail(staffEmailTextBox.Text);
			if (isValid) {
				if (isValidEmail) {
					StaffAccount staffAccount = new StaffAccount();
					string gender = this.rbMale.Checked ? this.rbMale.Text : this.rbFemale.Text;
					if (gender == Resources.MaleString) {
						staffAccount.IsMale = true;
					} else {
						staffAccount.IsMale = false;
					}
					staffAccount.Name = staffNameTextBox.Text;
					staffAccount.Position = staffPositionTextBox.Text;
					staffAccount.BirthDate = new DateOnly(staffBirthDateTimePicker.Value.Year, staffBirthDateTimePicker.Value.Month, staffBirthDateTimePicker.Value.Day);
					staffAccount.PhoneNumber = staffPhoneNumberTextBox.Text;
					staffAccount.Address = staffAddressTextBox.Text;
					staffAccount.Email = staffEmailTextBox.Text;
					staffAccount.Username = staffUsernameTextBox.Text;
					StaffAccounts.UpdateStaff(staffAccount);
					MessageBox.Show(this, "Change Infomation successfully", Resources.NotificationTitleString,
										   MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
					this.Close();
				} else {
					MessageBox.Show(this, "Invalid format Email.\nPlease try again!", Resources.WarningTitleString,
						MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				}
			} else {
				MessageBox.Show(this, "Phone number has at least 10 to 11 digit and begin with 0.\nPlease try again!", Resources.WarningTitleString,
							MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
			}
		}

		private static bool IsValidEmail(string email) {
			try {
				// Khởi tạo đối tượng MailAddress với chuỗi email
				var mailAddress = new MailAddress(email);
				return true; // Nếu không ném ra ngoại lệ, email hợp lệ
			} catch (FormatException) {
				return false; // Nếu ném ra ngoại lệ FormatException, email không hợp lệ
			}
		}

		private static bool IsValidPhoneNumber(string phoneNumber) {
			if (string.IsNullOrWhiteSpace(phoneNumber))
				return false;
			string pattern = @"^0[0-9]{9,10}$";
			return Regex.IsMatch(phoneNumber, pattern);
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void staffNameTextBox_TextChanged(object sender, EventArgs e) {
			this.lbStaffName.Text = staffNameTextBox.Text;
		}
	}
}
