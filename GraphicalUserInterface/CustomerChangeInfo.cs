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
    public partial class CustomerChangeInfo : Form
    {
        public CustomerChangeInfo()
        {
            InitializeComponent();
            LoadingAccountInfo();
        }

        public void LoadingAccountInfo()
        {
            try
            {
                CustomerAccount? customerAccount = CustomerAccounts.CurrentCustomerAccount;
                if (customerAccount is not null)
                {
                    this.customerNameTextBox.Text = customerAccount.Name;
                    this.cusgenderCbx.Text = customerAccount.IsMale ? Resources.MaleString : Resources.FemaleString;
                    this.customerCicNumberTextBox.Text = customerAccount.CicNumber;
                    this.customerBirthDateTimePicker.Text = customerAccount.BirthDate.ToString(CultureInfo.CurrentCulture);
                    this.customerPhoneNumberTextBox.Text = customerAccount.PhoneNumber;
                    this.customerEmailTextBox.Text = customerAccount.Email;
                    this.customerAddressTextBox.Text = customerAccount.Address;
                    this.customerUsernameTextBox.Text = customerAccount.Username;
                }
                else
                {
                    MessageBox.Show(this, Resources.FailedLoadingCustomerInfoString, Resources.ErrorTitleString,
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void customerChangeInfoButton_Click(object sender, EventArgs e)
        {
            CustomerAccount customerAccount = new CustomerAccount();
            string gender = this.cusgenderCbx.Text;
            if (gender == Resources.MaleString)
            {
                customerAccount.IsMale = true;
            }
            else
            {
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
    }
}
