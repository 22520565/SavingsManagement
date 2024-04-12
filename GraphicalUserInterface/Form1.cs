namespace Gui
{
    using System;
    using System.Data;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (DataRow dataRow in DataAccess.CustomerAccounts.GetDataTable(string.Empty).Rows)
            {
                this.customersDataGridView.Rows.Add(dataRow.ItemArray);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.customerIdTextBox.Enabled = false;
            this.customerNameTextBox.Enabled = true;
            this.customerMaleCheckBox.Enabled = true;
            this.customerCicNumberTextBox.Enabled = true;
            this.customerBirthDatePicker.Enabled = true;
            this.customerPhoneNumberTextBox.Enabled = true;
            this.customerAddressTextBox.Enabled = true;
            this.customerUsernameTextBox.Enabled = true;
            this.customerHashedPasswordTextBox.Enabled = true;
            this.customerBalanceNumeric.Enabled = true;

            this.customerIdTextBox.Text = string.Empty;
            this.customerNameTextBox.Text = string.Empty;
            this.customerMaleCheckBox.Checked = true;
            this.customerCicNumberTextBox.Text = string.Empty;
            this.customerBirthDatePicker.Checked = false;
            this.customerPhoneNumberTextBox.Text = string.Empty;
            this.customerAddressTextBox.Text = string.Empty;
            this.customerUsernameTextBox.Text = string.Empty;
            this.customerHashedPasswordTextBox.Text = string.Empty;
            this.customerBalanceNumeric.Value = decimal.Zero;

            this.addButton.Enabled = false;
            this.saveButton.Enabled = true;
            this.editButton.Enabled = false;
            this.deleteButton.Enabled = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Entity.CustomerAccount customerAccount = new Entity.CustomerAccount
            {
                Id = this.customersDataGridView.ColumnCount,
                Name = this.customerNameTextBox.Text,
                IsMale = this.customerMaleCheckBox.Checked,
                CicNumber = this.customerCicNumberTextBox.Text,
                BirthDate = DateOnly.FromDateTime(this.customerBirthDatePicker.Value),
                PhoneNumber = this.customerPhoneNumberTextBox.Text,
                Address = this.customerAddressTextBox.Text,
                Username = this.customerUsernameTextBox.Text,
                HashedPassword = this.customerHashedPasswordTextBox.Text,
                Balance = this.customerBalanceNumeric.Value,
            };
            DataAccess.CustomerAccounts.AddData(customerAccount);

            this.customersDataGridView.Rows.Clear();
            foreach (DataRow dataRow in DataAccess.CustomerAccounts.GetDataTable(string.Empty).Rows)
            {
                this.customersDataGridView.Rows.Add(dataRow.ItemArray);
            }
        }
    }
}
