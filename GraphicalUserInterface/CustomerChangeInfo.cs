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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalUserInterface
{
	public partial class CustomerChangeInfo : Form {
		public CustomerChangeInfo() {
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
				CustomerAccount? customerAccount = CustomerAccounts.CurrentCustomerAccount;
				if (customerAccount is not null) {
					this.customerNameTextBox.Text = customerAccount.Name;
					this.lbCustomerName.Text = customerAccount.Name;
					if (customerAccount.IsMale) {
						rbMale.Checked = true;
					} else {
						rbFemale.Checked = true;
					}
					this.customerCicNumberTextBox.Text = customerAccount.CicNumber;
					this.customerBirthDateTimePicker.Text = customerAccount.BirthDate.ToString(CultureInfo.CurrentCulture);
					this.customerPhoneNumberTextBox.Text = customerAccount.PhoneNumber;
					this.customerEmailTextBox.Text = customerAccount.Email;
					this.customerAddressTextBox.Text = customerAccount.Address;
					this.customerUsernameTextBox.Text = customerAccount.Username;
				} else {
					MessageBox.Show(this, Resources.FailedLoadingCustomerInfoString, Resources.ErrorTitleString,
						MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
				}
			} catch (Exception ex) {
				MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void customerChangeInfoButton_Click(object sender, EventArgs e) {
			CustomerAccount customerAccount = new CustomerAccount();
			string gender = this.rbMale.Checked ? this.rbMale.Text : this.rbFemale.Text;
			if (gender == Resources.MaleString) {
				customerAccount.IsMale = true;
			} else {
				customerAccount.IsMale = false;
			}
			customerAccount.Name = customerNameTextBox.Text;
			customerAccount.CicNumber = customerCicNumberTextBox.Text;
			customerAccount.BirthDate = new DateOnly(customerBirthDateTimePicker.Value.Year, customerBirthDateTimePicker.Value.Month, customerBirthDateTimePicker.Value.Day);
			customerAccount.PhoneNumber = customerPhoneNumberTextBox.Text;
			customerAccount.Address = customerAddressTextBox.Text;
			customerAccount.Email = customerEmailTextBox.Text;
			customerAccount.Username = customerUsernameTextBox.Text;
			CustomerAccounts.UpdateCustomer(customerAccount);
			MessageBox.Show(this, "Change Infomation successfully", Resources.NotificationTitleString,
								   MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void customerNameTextBox_TextChanged(object sender, EventArgs e) {
			this.lbCustomerName.Text = customerNameTextBox.Text;
		}
	}
}
