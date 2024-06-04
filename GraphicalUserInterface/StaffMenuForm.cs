namespace GraphicalUserInterface;

using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Business;
using DataAccess;
using System.Data.SqlClient;
using System.Data;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Identity;
using System.Security.Cryptography;
<<<<<<< HEAD
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
=======
using GraphicalUserInterface.Properties;
using GraphicalUserInterface.Properties;
>>>>>>> 761f28668e4e3d928a34d62b37f47919fabdafbe

public partial class StaffMenuForm : Form
{

    public StaffMenuForm()
    {
        this.InitializeComponent();
    }
    
    public bool GoingBackToLoginForm { get; private set; } = false;

        private static readonly PasswordHasher<String> PasswordHasher = new();

        public void Connection()
        {
            using (var context = new SavingsManagementContext())
            {
                loadCustomer();
                loadStaff();
            }
        }

        public StaffMenuForm()
        {
            InitializeComponent();
            Connection();
            customerIdTextBox.ReadOnly = true;
            customerBalanceTextBox.ReadOnly = true;
            dataGridViewCustomer.ReadOnly = true;
<<<<<<< HEAD
            staffIdTextBox.ReadOnly = true;
            dataGridViewStaff.ReadOnly = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra tab đang được chọn là tabPageManageCustomers
            if (tabControl1.SelectedTab == tabPageManageCustomers)
            {
                customerIdTextBox.Text = "";
                customerNameTextBox.Text = "";
                customerMaleCheckBox.Checked = false;
                customerCicNumberTextBox.Text = "";
                customerBirthDatePicker.Value = DateTime.Now.Date;
                customerPhoneNumberTextBox.Text = "";
                customerAddressTextBox.Text = "";
                customerEmailTextBox.Text = "";
                customerUsernameTextBox.Text = "";
                customerHashedPasswordTextBox.Text = "";
                customerBalanceTextBox.Text = "";
                customerDisableCheckBox.Checked = false;
            }
            // Kiểm tra tab đang được chọn là tabPageManageStaffs
            else if (tabControl1.SelectedTab == tabPageManageStaffs)
            {
                staffIdTextBox.Text = "";
                staffNameTextBox.Text = "";
                staffMaleCheckBox.Checked = false;
                staffPositionTextBox.Text = "";
                staffUsernameTextBox.Text = "";
                staffHashedPasswordTextBox.Text = "";
                staffPermissionIdComboBox.Text = "";
                customerDisableCheckBox.Checked = false;
            }
=======

    private void StaffMenuForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        Form bg = new Form();
        CloseWindow logOut = new CloseWindow();
        using (logOut)
        {
            logOut.Notification.Text = Resources.LogOutConfirmationString;
            logOut.Text = Resources.LogOutString;
            logOut.Confirm.Text = Resources.LogOutString;
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
        this.GoingBackToLoginForm = !logOut.IsNotClosed;
        e.Cancel = logOut.IsNotClosed;
    }

    // FIXME: Magic number shall not be used. Use enum or bool instead!
    private void StaffMenuForm_Load(object sender, EventArgs e)
    {
        this.GoingBackToLoginForm = false;

        using var context = new SavingsManagementContext();
        switch (context.StaffAccounts.Find(StaffAccounts.CurrentStaffId)?.PermissionId)
        {
            case 1:
                break;
            case 2:
                this.tabControl1.TabPages.Remove(this.tabPageManageStaffs);
                this.tabControl1.TabPages.Remove(this.tabPageChangeRegulations);
                break;
            default:
                MessageBox.Show("No permission found for your staff account.");
                break;
        }
    }

    private void customerDepositIdTextBox_Enter(object sender, EventArgs e)
    {
        this.customerDepositNameTextBox.Text = string.Empty;
        this.customerDepositCicNumberTextBox.Text = string.Empty;
        this.customerDepositAmountNumeric.Enabled = false;
        this.customerDepositContentTextBox.Enabled = false;
        this.customerDepositButton.Enabled = false;
    }

    private void customerDepositIdTextBox_Leave(object sender, EventArgs e)
    {
        CustomerAccount? customerAccount = null;

        if (!string.IsNullOrWhiteSpace(this.customerDepositIdTextBox.Text) &&
            int.TryParse(this.customerDepositIdTextBox.Text, CultureInfo.CurrentCulture, out var customerDepositId))
        {
            customerAccount = CustomerAccounts.GetCustomerAccount(customerDepositId);
>>>>>>> 761f28668e4e3d928a34d62b37f47919fabdafbe
        }

        if (customerAccount is null)
        {
            this.customerDepositNameTextBox.Text = string.Empty;
            this.customerDepositCicNumberTextBox.Text = string.Empty;
            this.customerDepositAmountNumeric.Enabled = false;
            this.customerDepositContentTextBox.Enabled = false;
            this.customerDepositButton.Enabled = false;
        }
        else
        {
            this.customerDepositNameTextBox.Text = customerAccount.Name;
            this.customerDepositCicNumberTextBox.Text = customerAccount.CicNumber;
            this.customerDepositAmountNumeric.Enabled = true;
            this.customerDepositContentTextBox.Enabled = true;
            this.customerDepositButton.Enabled = !string.IsNullOrWhiteSpace(this.customerDepositContentTextBox.Text);
        }
    }

    private void customerDepositContentTextBox_TextChanged(object sender, EventArgs e)
    {
        this.customerDepositButton.Enabled = !string.IsNullOrWhiteSpace(this.customerDepositContentTextBox.Text)
            && !string.IsNullOrWhiteSpace(this.customerDepositIdTextBox.Text);
    }

    private void customerDepositButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (!int.TryParse(this.customerDepositIdTextBox.Text, CultureInfo.CurrentCulture, out var customerDepositId))
            {
                MessageBox.Show(
                    this,
                    Resources.InvalidCustomerIdString,
                    Resources.ErrorTitleString,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            else if (this.customerDepositContentTextBox.Text.Length <= 0)
            {
                MessageBox.Show(
                    this,
                    Resources.ErrorEmptyContentString,
                    Resources.ErrorTitleString,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                CashFlows.Deposit(customerDepositId, this.customerDepositAmountNumeric.Value, this.customerDepositContentTextBox.Text);
                MessageBox.Show(
                    this,
                    Resources.DepositSuccessfullyString,
                    Resources.InformationTitleString,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                if (this.customerDepositIdTextBox.Focus())
                {
                    this.customerDepositIdTextBox.Text = string.Empty;
                }
                this.customerDepositIdTextBox.Text = string.Empty;
                this.customerDepositAmountNumeric.Value = this.customerDepositAmountNumeric.Minimum;
                this.customerDepositContentTextBox.Text = string.Empty;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(this,
                ex.Message,
                ex.Source,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
        }
    }

    private void customerWithdrawIdTextBox_Enter(object sender, EventArgs e)
    {
        this.customerWithdrawNameTextBox.Text = string.Empty;
        this.customerWithdrawCicNumberTextBox.Text = string.Empty;
        this.customerWithdrawBalanceTextBox.Text = string.Empty;
        this.customerWithdrawAmountNumeric.Enabled = false;
        this.customerWithdrawContentTextBox.Enabled = false;
        this.customerWithdrawAmountNumeric.Maximum = decimal.Zero;
        this.customerWithdrawButton.Enabled = false;
    }

    private void customerWithdrawIdTextBox_Leave(object sender, EventArgs e)
    {
        CustomerAccount? customerAccount = null;

        if (!string.IsNullOrWhiteSpace(this.customerWithdrawIdTextBox.Text) &&
            int.TryParse(this.customerWithdrawIdTextBox.Text, CultureInfo.CurrentCulture, out var customerWithdrawId))
        {
            customerAccount = CustomerAccounts.GetCustomerAccount(customerWithdrawId);
        }

        if (customerAccount is null)
        {
            this.customerWithdrawNameTextBox.Text = string.Empty;
            this.customerWithdrawCicNumberTextBox.Text = string.Empty;
            this.customerWithdrawBalanceTextBox.Text = string.Empty;
            this.customerWithdrawAmountNumeric.Enabled = false;
            this.customerWithdrawAmountNumeric.Maximum = decimal.Zero;
            this.customerWithdrawContentTextBox.Enabled = false;
            this.customerWithdrawButton.Enabled = false;
        }
        else
        {
            this.customerWithdrawNameTextBox.Text = customerAccount.Name;
            this.customerWithdrawCicNumberTextBox.Text = customerAccount.CicNumber;
            this.customerWithdrawBalanceTextBox.Text = customerAccount.Balance.ToString(
                Resources.CurrencyStringFormat, CultureInfo.CurrentCulture);
            this.customerWithdrawAmountNumeric.Enabled = true;
            this.customerWithdrawAmountNumeric.Maximum = Math.Round(customerAccount.Balance, this.customerWithdrawAmountNumeric.DecimalPlaces, MidpointRounding.ToZero);
            this.customerWithdrawContentTextBox.Enabled = true;
            this.customerWithdrawButton.Enabled = !string.IsNullOrWhiteSpace(this.customerWithdrawContentTextBox.Text);
        }
    }

    private void customerWithdrawContentTextBox_TextChanged(object sender, EventArgs e)
    {
        this.customerWithdrawButton.Enabled = !string.IsNullOrWhiteSpace(this.customerWithdrawContentTextBox.Text)
            && !string.IsNullOrWhiteSpace(this.customerWithdrawIdTextBox.Text);
    }

    private void customerWithdrawButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (!int.TryParse(this.customerWithdrawIdTextBox.Text, CultureInfo.CurrentCulture, out var customerWithdrawId))
            {
                MessageBox.Show(
                    this,
                    Resources.InvalidCustomerIdString,
                    Resources.ErrorTitleString,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            else if (this.customerWithdrawContentTextBox.Text.Length <= 0)
            {
                MessageBox.Show(
                    this,
                    Resources.ErrorEmptyContentString,
                    Resources.ErrorTitleString,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                CashFlows.Withdraw(customerWithdrawId, this.customerWithdrawAmountNumeric.Value, this.customerWithdrawContentTextBox.Text);
                MessageBox.Show(
                    this,
                    Resources.WithdrawSuccessfullyString,
                    Resources.InformationTitleString,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                if (this.customerWithdrawIdTextBox.Focus())
                {
                    this.customerWithdrawIdTextBox.Text = string.Empty;
                }
                this.customerWithdrawIdTextBox.Text = string.Empty;
                this.customerWithdrawAmountNumeric.Value = this.customerWithdrawAmountNumeric.Minimum;
                this.customerWithdrawContentTextBox.Text = string.Empty;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                this,
                ex.Message,
                ex.Source,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
        }

        # region Custome Management
        private void loadCustomer()
        {
            using (var context = new SavingsManagementContext())
            {
                var customers = context.CustomerAccounts.ToList();
                dataGridViewCustomer.DataSource = customers;
                dataGridViewCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridViewCustomer.CurrentRow.Index;
            customerIdTextBox.Text = dataGridViewCustomer.Rows[i].Cells[0].Value.ToString();
            customerNameTextBox.Text = dataGridViewCustomer.Rows[i].Cells[1].Value.ToString();
            customerMaleCheckBox.Checked = Convert.ToBoolean(dataGridViewCustomer.Rows[i].Cells[2].Value);
            customerCicNumberTextBox.Text = dataGridViewCustomer.Rows[i].Cells[3].Value.ToString();
            // Chuyển đổi giá trị ngày tháng từ chuỗi thành kiểu DateTime trước khi gán cho DateTimePicker
            if (DateTime.TryParse(dataGridViewCustomer.Rows[i].Cells[4].Value.ToString(), out DateTime birthDate))
            {
                customerBirthDatePicker.Value = birthDate;
            }
            customerPhoneNumberTextBox.Text = dataGridViewCustomer.Rows[i].Cells[5].Value.ToString();
            customerAddressTextBox.Text = dataGridViewCustomer.Rows[i].Cells[6].Value.ToString();
            customerEmailTextBox.Text = dataGridViewCustomer.Rows[i].Cells[7].Value.ToString();
            customerUsernameTextBox.Text = dataGridViewCustomer.Rows[i].Cells[8].Value.ToString();
            customerHashedPasswordTextBox.Text = dataGridViewCustomer.Rows[i].Cells[9].Value.ToString();
            customerBalanceTextBox.Text = dataGridViewCustomer.Rows[i].Cells[10].Value.ToString();
            customerDisableCheckBox.Checked = Convert.ToBoolean(dataGridViewCustomer.Rows[i].Cells[11].Value);
        }

        private bool IsEmailExists(string email)
        {
            using (var context = new SavingsManagementContext())
            {
                return context.CustomerAccounts.Any(c => c.Email == email);
            }
        }

        private string GenerateUniqueEmail()
        {
            string email;
            do
            {
                // Tạo một số ngẫu nhiên có độ dài 6
                string randomNumber = new Random().Next(100000, 999999).ToString();
                // Kết hợp số ngẫu nhiên với địa chỉ email cơ sở
                email = $"user{randomNumber}@example.com";
            }
            while (IsEmailExists(email)); // Kiểm tra xem địa chỉ email đã tồn tại hay chưa
            return email;
        }

        private bool IsUsernameExists(string username)
        {
            using (var context = new SavingsManagementContext())
            {
                return context.CustomerAccounts.Any(c => c.Username == username);
            }
        }

        private string GenerateUniqueUsername()
        {
            string username;
            do
            {
                // Tạo một số ngẫu nhiên có độ dài 6
                string randomNumber = new Random().Next(100000, 999999).ToString();
                // Kết hợp số ngẫu nhiên với tên user cơ sở
                username = $"user{randomNumber}";
            }
            while (IsUsernameExists(username)); // Kiểm tra xem Username đã tồn tại hay chưa
            return username;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Mã hóa mật khẩu "123"
            string hashedPassword = PasswordHasher.HashPassword(null!, "123");

            using (var context = new SavingsManagementContext())
            {
                var customer = new CustomerAccount
                {
                    Name = "Customer",
                    IsMale = false,
                    CicNumber = "0",
                    BirthDate = new DateOnly(DateTime.Now.Date.Year, DateTime.Now.Date.Month, DateTime.Now.Date.Day),
                    PhoneNumber = "0",
                    Address = "Việt Nam",
                    Email = GenerateUniqueEmail(),
                    Username = GenerateUniqueUsername(),
                    HashedPassword = hashedPassword,
                    Balance = Decimal.MinValue,
                    IsDisabled = false
                };

                context.CustomerAccounts.Add(customer);
                context.SaveChanges();
                loadCustomer();
                MessageBox.Show("New customer successfully added, please update information!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewCustomer.CurrentRow.Index.Equals(0))
            {
                MessageBox.Show("Please select a customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int customerId = Convert.ToInt32(customerIdTextBox.Text);

            using (var context = new SavingsManagementContext())
            {
                var customer = context.CustomerAccounts.FirstOrDefault(c => c.Id == customerId);
                if (customer != null)
                {
                    customer.IsDisabled = true;
                    context.SaveChanges();
                    loadCustomer();
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewCustomer.CurrentRow.Index.Equals(0))
            {
                MessageBox.Show("Please select a customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int customerId = Convert.ToInt32(customerIdTextBox.Text);

            if (customerNameTextBox.Text.IsNullOrEmpty() ||
                customerCicNumberTextBox.Text.IsNullOrEmpty() ||
                customerPhoneNumberTextBox.Text.IsNullOrEmpty() ||
                customerAddressTextBox.Text.IsNullOrEmpty() ||
                customerEmailTextBox.Text.IsNullOrEmpty() ||
                customerUsernameTextBox.Text.IsNullOrEmpty() ||
                customerHashedPasswordTextBox.Text.IsNullOrEmpty() ||
                customerBalanceTextBox.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please fill in all blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new SavingsManagementContext())
            {
                var customer = context.CustomerAccounts.FirstOrDefault(c => c.Id == customerId);
                if (customer != null)
                {
                    customer.Name = customerNameTextBox.Text;
                    customer.IsMale = customerMaleCheckBox.Checked;
                    customer.CicNumber = customerCicNumberTextBox.Text;
                    customerBirthDatePicker.Value =  DateTime.Now.Date;
                    customer.PhoneNumber = customerPhoneNumberTextBox.Text;
                    customer.Address = customerAddressTextBox.Text;
                    customer.Email = customerEmailTextBox.Text;
                    customer.Username = customerUsernameTextBox.Text;
                    customer.HashedPassword = customerHashedPasswordTextBox.Text;
                    customer.Balance = Convert.ToDecimal(customerBalanceTextBox.Text);
                    customer.IsDisabled = customerDisableCheckBox.Checked;

                    context.SaveChanges();
                    loadCustomer();
                    MessageBox.Show("Updated customer information successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void customerHashedPasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                customerHashedPasswordTextBox.Text = PasswordHasher.HashPassword(null!, customerHashedPasswordTextBox.Text);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            customerIdTextBox.Text = "";
            customerNameTextBox.Text = "";
            customerMaleCheckBox.Checked = false;
            customerCicNumberTextBox.Text = "";
            customerBirthDatePicker.Value = DateTime.Now.Date;
            customerPhoneNumberTextBox.Text = "";
            customerAddressTextBox.Text = "";
            customerEmailTextBox.Text = "";
            customerUsernameTextBox.Text = "";
            customerHashedPasswordTextBox.Text = "";
            customerBalanceTextBox.Text = "";
            customerDisableCheckBox.Checked = false;
            MessageBox.Show("Screen cleared successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
        #region Staff Management
        private void loadStaff()
        {
            using (var context = new SavingsManagementContext())
            {
                var staffs = context.StaffAccounts.ToList();
                dataGridViewStaff.DataSource = staffs;
                dataGridViewStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }


        private void dataGridViewStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int i = dataGridViewStaff.CurrentRow.Index;
            staffIdTextBox.Text = dataGridViewStaff.Rows[i].Cells[0].Value.ToString();
            staffNameTextBox.Text = dataGridViewStaff.Rows[i].Cells[1].Value.ToString();
            staffMaleCheckBox.Checked = Convert.ToBoolean(dataGridViewStaff.Rows[i].Cells[2].Value);
            staffPositionTextBox.Text = dataGridViewStaff.Rows[i].Cells[3].Value.ToString();
            staffUsernameTextBox.Text = dataGridViewStaff.Rows[i].Cells[4].Value.ToString();
            staffHashedPasswordTextBox.Text = dataGridViewStaff.Rows[i].Cells[5].Value.ToString();
            switch (dataGridViewStaff.Rows[i].Cells[6].Value)
            {
                case 1:
                    staffPermissionIdComboBox.Text = "1 - Admin";
                    break;
                case 2:
                    staffPermissionIdComboBox.Text = "2 - Staff";
                    break;
                default:
                    MessageBox.Show("Can not find type of staff!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            staffDisableCheckBox.Checked = Convert.ToBoolean(dataGridViewStaff.Rows[i].Cells[7].Value);
        }

        private bool IsStaffUsernameExists(string username)
        {
            using (var context = new SavingsManagementContext())
            {
                return context.StaffAccounts.Any(s => s.Username == username);
            }
        }

        private string GenerateUniqueStaffUsername()
        {
            string username;
            do
            {
                // Tạo một số ngẫu nhiên có độ dài 6
                string randomNumber = new Random().Next(100000, 999999).ToString();
                // Kết hợp số ngẫu nhiên với tên user cơ sở
                username = $"staff{randomNumber}";
            }
            while (IsStaffUsernameExists(username)); // Kiểm tra xem Username đã tồn tại hay chưa
            return username;
        }

        private void addStaff_Click(object sender, EventArgs e)
        {
            // Mã hóa mật khẩu "123"
            string hashedPassword = PasswordHasher.HashPassword(null!, "123");

            using (var context = new SavingsManagementContext())
            {
                var staff = new StaffAccount
                {
                    Name = "Staff",
                    IsMale = false,
                    Position = "Staff",
                    Username = GenerateUniqueStaffUsername(),
                    HashedPassword = hashedPassword,
                    PermissionId = 2,
                    IsDisabled = false
                };

                context.StaffAccounts.Add(staff);
                context.SaveChanges();
                loadStaff();
                MessageBox.Show("New staff successfully added, please update information!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void disableStaff_Click(object sender, EventArgs e)
        {
            if (dataGridViewStaff.CurrentRow.Index.Equals(0))
            {
                MessageBox.Show("Please select a staff!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int staffId = Convert.ToInt32(staffIdTextBox.Text);

            using (var context = new SavingsManagementContext())
            {
                var staff = context.StaffAccounts.FirstOrDefault(s => s.Id == staffId);
                if (staff != null)
                {
                    staff.IsDisabled = true;
                    context.SaveChanges();
                    loadStaff();
                }
            }
        }

        private void saveStaff_Click(object sender, EventArgs e)
        {
            if (dataGridViewStaff.CurrentRow.Index.Equals(0))
            {
                MessageBox.Show("Please select a staff!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int staffId = Convert.ToInt32(staffIdTextBox.Text);

            if (staffNameTextBox.Text.IsNullOrEmpty() ||
                staffPositionTextBox.Text.IsNullOrEmpty() ||
                staffUsernameTextBox.Text.IsNullOrEmpty() ||
                staffHashedPasswordTextBox.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please fill in all blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int permissionId = 0;
            int indexOfDash = staffPermissionIdComboBox.Text.IndexOf('-');
            if (indexOfDash != -1)
            {
                permissionId = Int32.Parse(staffPermissionIdComboBox.Text.Substring(0, indexOfDash).Trim());
            }

            using (var context = new SavingsManagementContext())
            {
                var staff = context.StaffAccounts.FirstOrDefault(s => s.Id == staffId);
                if (staff != null)
                {
                    staff.Name = staffNameTextBox.Text;
                    staff.IsMale = staffMaleCheckBox.Checked;
                    staff.Position = staffPositionTextBox.Text;
                    staff.Username = staffUsernameTextBox.Text;
                    staff.HashedPassword = staffHashedPasswordTextBox.Text;
                    staff.PermissionId = permissionId;
                    staff.IsDisabled = staffDisableCheckBox.Checked;

                    context.SaveChanges();
                    loadStaff();
                    MessageBox.Show("Updated staff information successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void staffHashedPasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                staffHashedPasswordTextBox.Text = PasswordHasher.HashPassword(null!, staffHashedPasswordTextBox.Text);
            }
        }

        private void clearScreen_Click(object sender, EventArgs e)
        {
            staffIdTextBox.Text = "";
            staffNameTextBox.Text = "";
            staffMaleCheckBox.Checked = false;
            staffPositionTextBox.Text = "";
            staffUsernameTextBox.Text = "";
            staffHashedPasswordTextBox.Text = "";
            staffPermissionIdComboBox.Text = "";
            customerDisableCheckBox.Checked = false;
            MessageBox.Show("Screen cleared successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
