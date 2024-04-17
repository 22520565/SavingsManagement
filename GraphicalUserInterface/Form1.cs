namespace Gui
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        private bool inEditMode = false;

        public Form1()
        {
            this.InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.ClearAllField();
            this.AllowEdit();
            this.inEditMode = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.inEditMode)
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
                Business.CustomerAccounts.EditData(customerAccount);
            }
            else
            {
                Entity.CustomerAccount customerAccount = new Entity.CustomerAccount
                {
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

        private void AllowEdit()
        {
            this.customerIdNumeric.Enabled = false;
            this.customerNameTextBox.ReadOnly = false;
            this.customerMaleCheckBox.Enabled = true;
            this.customerCicNumberTextBox.ReadOnly = false;
            this.customerBirthDatePicker.Enabled = true;
            this.customerPhoneNumberTextBox.ReadOnly = false;
            this.customerAddressTextBox.ReadOnly = false;
            this.customerUsernameTextBox.ReadOnly = false;
            this.customerHashedPasswordTextBox.ReadOnly = false;
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
            this.customerNameTextBox.ReadOnly = true;
            this.customerMaleCheckBox.Enabled = false;
            this.customerCicNumberTextBox.ReadOnly = true;
            this.customerBirthDatePicker.Enabled = false;
            this.customerPhoneNumberTextBox.ReadOnly = true;
            this.customerAddressTextBox.ReadOnly = true;
            this.customerUsernameTextBox.ReadOnly = true;
            this.customerHashedPasswordTextBox.ReadOnly = true;
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
            this.DisallowEdit();
        }
    }
}
