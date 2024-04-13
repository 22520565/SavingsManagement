namespace Gui
{
    using System;
    using System.Data;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        private bool inEditMode = false;

        public Form1()
        {
            this.InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (DataRow dataRow in Business.CustomerAccounts.GetDataTable(string.Empty).Rows)
            {
                this.customersDataGridView.Rows.Add(dataRow.ItemArray);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.ClearAllField();
            this.AllowEdit();
            this.inEditMode = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Entity.CustomerAccount customerAccount = new Entity.CustomerAccount
            {
                Id = (int)this.customerIdNumeric.Value,
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

            if (this.inEditMode)
            {
                Business.CustomerAccounts.EditData(customerAccount);
            }
            else
            {
                Business.CustomerAccounts.AddData(customerAccount);
            }

            this.RefreshDataGridView();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            this.AllowEdit();
            this.inEditMode = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Entity.CustomerAccount customerAccount = new Entity.CustomerAccount
            {
                Id = (int)this.customerIdNumeric.Value,
            };
            Business.CustomerAccounts.DeleteData(customerAccount);

            this.RefreshDataGridView();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DisallowEdit();
            this.ClearAllField();
        }

        private void customersDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.customerIdNumeric.Value = this.customersDataGridView[0, e.RowIndex].Value is int customerId ? customerId : 0;
                this.customerNameTextBox.Text = this.customersDataGridView[1, e.RowIndex].Value as string ?? string.Empty;
                this.customerMaleCheckBox.Checked = this.customersDataGridView[2, e.RowIndex].Value is not bool customerIsMale || customerIsMale;
                this.customerCicNumberTextBox.Text = this.customersDataGridView[3, e.RowIndex].Value as string ?? string.Empty;
                this.customerBirthDatePicker.Value = this.customersDataGridView[4, e.RowIndex].Value is DateTime customerBirthDate ? customerBirthDate : DateTime.Now;
                this.customerPhoneNumberTextBox.Text = this.customersDataGridView[5, e.RowIndex].Value as string ?? string.Empty;
                this.customerAddressTextBox.Text = this.customersDataGridView[6, e.RowIndex].Value as string ?? string.Empty;
                this.customerUsernameTextBox.Text = this.customersDataGridView[7, e.RowIndex].Value as string ?? string.Empty;
                this.customerHashedPasswordTextBox.Text = this.customersDataGridView[8, e.RowIndex].Value as string ?? string.Empty;
                this.customerBalanceNumeric.Value = this.customersDataGridView[9, e.RowIndex].Value is decimal customerBalance ? customerBalance : 0;
            }
        }

        private void AllowEdit()
        {
            this.customerIdNumeric.Enabled = false;
            this.customerNameTextBox.Enabled = true;
            this.customerMaleCheckBox.Enabled = true;
            this.customerCicNumberTextBox.Enabled = true;
            this.customerBirthDatePicker.Enabled = true;
            this.customerPhoneNumberTextBox.Enabled = true;
            this.customerAddressTextBox.Enabled = true;
            this.customerUsernameTextBox.Enabled = true;
            this.customerHashedPasswordTextBox.Enabled = true;
            this.customerBalanceNumeric.Enabled = true;

            this.addButton.Enabled = false;
            this.saveButton.Enabled = true;
            this.editButton.Enabled = false;
            this.deleteButton.Enabled = false;
            this.cancelButton.Enabled = true;
        }

        private void DisallowEdit()
        {
            this.customerIdNumeric.Enabled = false;
            this.customerNameTextBox.Enabled = false;
            this.customerMaleCheckBox.Enabled = false;
            this.customerCicNumberTextBox.Enabled = false;
            this.customerBirthDatePicker.Enabled = false;
            this.customerPhoneNumberTextBox.Enabled = false;
            this.customerAddressTextBox.Enabled = false;
            this.customerUsernameTextBox.Enabled = false;
            this.customerHashedPasswordTextBox.Enabled = false;
            this.customerBalanceNumeric.Enabled = false;

            this.addButton.Enabled = true;
            this.saveButton.Enabled = false;
            this.editButton.Enabled = true;
            this.deleteButton.Enabled = true;
            this.cancelButton.Enabled = false;
        }

        private void ClearAllField()
        {
            this.customerIdNumeric.Text = string.Empty;
            this.customerNameTextBox.Text = string.Empty;
            this.customerMaleCheckBox.Checked = true;
            this.customerCicNumberTextBox.Text = string.Empty;
            this.customerBirthDatePicker.Checked = false;
            this.customerPhoneNumberTextBox.Text = string.Empty;
            this.customerAddressTextBox.Text = string.Empty;
            this.customerUsernameTextBox.Text = string.Empty;
            this.customerHashedPasswordTextBox.Text = string.Empty;
            this.customerBalanceNumeric.Value = decimal.Zero;
        }

        private void RefreshDataGridView()
        {
            this.customersDataGridView.Rows.Clear();
            foreach (DataRow dataRow in Business.CustomerAccounts.GetDataTable(string.Empty).Rows)
            {
                this.customersDataGridView.Rows.Add(dataRow.ItemArray);
            }

            this.DisallowEdit();
        }
    }
}
