namespace GraphicalUserInterface;

using System;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Business;
using DataAccess;
using GraphicalUserInterface.Properties;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using MiniExcelLibs;
using MiniExcelLibs.OpenXml;

public partial class StaffMenuForm : Form
{
    public bool GoingBackToLoginForm { get; private set; } = false;

    DataTable dt;

    private static readonly PasswordHasher<String> PasswordHasher = new();

    public StaffMenuForm()
    {
        InitializeComponent();
        InitializeInfo();
        loadCustomer();
        loadStaff();
        loadDeposit();
        loadWithdraw();
        customerIdTextBox.ReadOnly = true;
        customerBalanceTextBox.ReadOnly = true;
        dataGridViewCustomer.ReadOnly = true;
        staffIdTextBox.ReadOnly = true;
        dataGridViewStaff.ReadOnly = true;
    }

    #region Information
    private void InitializeInfo()
    {
        LoadingAccountInfo();
        LoadingRateList();
    }

    public void LoadingAccountInfo()
    {
        try
        {
            StaffAccount? staffAccount = StaffAccounts.CurrentStaffAccount;
            if (staffAccount is not null)
            {
                this.staffIdtxt.Text = staffAccount.Id.ToString(CultureInfo.CurrentCulture);
                this.staffnametxt.Text = staffAccount.Name;
                this.staffgendertxt.Text = staffAccount.IsMale ? Resources.MaleString : Resources.FemaleString;
                this.staffpositiontxt.Text = staffAccount.Position;
                this.staffusernametxt.Text = staffAccount.Username;
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

    private void staffChangePasswordButton_Click(object sender, EventArgs e)
    {
        using var form = new PasswordChangingForm("Staff");
        form.ShowDialog();
    }

    public void LoadingRateList()
    {
        dt = new DataTable();
        dt.Columns.AddRange(new[] { new DataColumn("PeriodInMonths", typeof(string)),
                        new DataColumn("AnnualInterestRate", typeof(string))});
        int? currentStaffId = StaffAccounts.CurrentStaffId;
        if (currentStaffId.HasValue)
        {
            var interestRates = SavingInterestRates.Collection;
            foreach (var interestRate in interestRates)
            {
                AddRateEntry(interestRate);
            }
        }
        else
        {
            MessageBox.Show(Resources.NoCustomerLoggingInString);
        }

    }

    private void AddRateEntry(SavingInterestRate interestRate)
    {
        dt.Rows.Add(interestRate.PeriodInMonths.ToString(),
            interestRate.AnnualInterestRate.ToString(Resources.InterestTextFormatString, CultureInfo.InvariantCulture));
        this.data_rate.DataSource = dt;
        data_rate.Columns[0].ReadOnly = false;
        this.data_rate.AllowUserToAddRows = false;
    }

    private void data_rate_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            DataGridViewRow selectedRow = data_rate.Rows[e.RowIndex];
            string months = selectedRow.Cells["PeriodInMonths"].Value.ToString();
            string rates = selectedRow.Cells["AnnualInterestRate"].Value.ToString();

            int month = int.Parse(months);
            string[] rate = rates.Split("%");

            this.monthtxt.Text = month.ToString();
            this.ratetxt.Text = rate[0];
        }
    }

    private void saveRate_Click(object sender, EventArgs e)
    {
        int month = int.Parse(this.monthtxt.Text);
        decimal rate = decimal.Parse(this.ratetxt.Text);
        rate = rate / 100;
        SavingInterestRates.SetInterest(month, rate);
        LoadingRateList();
        MessageBox.Show("Successful", "Save change successfully", MessageBoxButtons.OK);
    }

    #endregion

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {

        // Kiểm tra tab đang được chọn là tabPageManageCustomers
        if (tabControl1.SelectedTab == tabPageManageCustomers)
        {
            customerIdTextBox.Text = "";
            customerNameTextBox.Text = "";
            customerMaleCheckBox.Checked = false;
            customerCicNumberTextBox.Text = "";
            customerBirthDateTimePicker.Value = DateTime.Now.Date;
            customerPhoneNumberTextBox.Text = "";
            customerAddressTextBox.Text = "";
            customerEmailTextBox.Text = "";
            customerUsernameTextBox.Text = "";
            customerHashedPasswordTextBox.Text = "";
            customerBalanceTextBox.Text = "";
            customerDisableCheckBox.Checked = false;
            customerSearchTextBox.Text = "";
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
            staffPermissionIdComboBox.SelectedItem = staffPermissionIdComboBox.Items[0];
            staffDisableCheckBox.Checked = false;
            staffSearchTextBox.Text = "";
        }
    }

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

    // FIXME
    private void StaffMenuForm_Load(object sender, EventArgs e)
    {
        this.GoingBackToLoginForm = false;

        using var context = new SavingsManagementContext();
        switch (context.StaffAccounts.Find(StaffAccounts.CurrentStaffId)?.PermissionId)
        {
            case 1:
                break;
            case 2:
                tabControl1.TabPages.Remove(tabPageManageStaffs);
                tabControl1.TabPages.Remove(tabPageChangeRegulations);
                break;
            default:
                MessageBox.Show("No permission found for your staff account.");
                break;

        }
    }

    #region Deposit
    public void loadDeposit()
    {
        using (var context = new SavingsManagementContext())
        {
            var deposits = context.CashFlows
                                .Where(d => d.BalanceChanging > 0)
                                .Select(d => new
                                {
                                    d.Id,
                                    d.CustomerId,
                                    CustomerName = context.CustomerAccounts
                                                           .Where(c => c.Id == d.CustomerId)
                                                           .Select(c => c.Name)
                                                           .FirstOrDefault(),
                                    d.Time,
                                    d.BalanceChanging,
                                    d.Content,
                                })
                                .ToList();

            dataGridViewDeposit.DataSource = deposits;
            dataGridViewDeposit.Columns["CustomerName"].HeaderText = "Customer Name";
            dataGridViewDeposit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }

    private void customerDepositIdTextBox_Enter(object sender, EventArgs e)
    {
        this.customerDepositNameTextBox.Text = string.Empty;
        this.customerDepositCicNumberTextBox.Text = string.Empty;
        this.customerDepositAmountNumeric.Enabled = false;
        this.customerDepositContentTextBox.Enabled = false;
        this.customerDepositButton.Enabled = false;
        this.customerPrintButton.Enabled = false;
    }

    private void customerDepositIdTextBox_Leave(object sender, EventArgs e)
    {
        CustomerAccount? customerAccount = null;

        if (!string.IsNullOrWhiteSpace(this.customerDepositIdTextBox.Text) &&
            int.TryParse(this.customerDepositIdTextBox.Text, CultureInfo.CurrentCulture, out var customerDepositId))
        {
            customerAccount = CustomerAccounts.GetCustomerAccount(customerDepositId);
        }

        if (customerAccount is null)
        {
            this.customerDepositNameTextBox.Text = string.Empty;
            this.customerDepositCicNumberTextBox.Text = string.Empty;
            this.customerDepositAmountNumeric.Enabled = false;
            this.customerDepositContentTextBox.Enabled = false;
            this.customerDepositButton.Enabled = false;
            this.customerPrintButton.Enabled = false;
        }
        else
        {
            this.customerDepositNameTextBox.Text = customerAccount.Name;
            this.customerDepositCicNumberTextBox.Text = customerAccount.CicNumber;
            this.customerDepositAmountNumeric.Enabled = true;
            this.customerDepositContentTextBox.Enabled = true;
            this.customerDepositButton.Enabled = !string.IsNullOrWhiteSpace(this.customerDepositContentTextBox.Text);
            this.customerPrintButton.Enabled = !string.IsNullOrWhiteSpace(this.customerDepositContentTextBox.Text);
        }
    }

    private void customerDepositContentTextBox_TextChanged(object sender, EventArgs e)
    {
        this.customerDepositButton.Enabled = !string.IsNullOrWhiteSpace(this.customerDepositContentTextBox.Text)
            && !string.IsNullOrWhiteSpace(this.customerDepositIdTextBox.Text);
        this.customerPrintButton.Enabled = !string.IsNullOrWhiteSpace(this.customerDepositContentTextBox.Text)
            && !string.IsNullOrWhiteSpace(this.customerDepositIdTextBox.Text);
    }

    private void customerDepositButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (!int.TryParse(this.customerDepositIdTextBox.Text, CultureInfo.CurrentCulture, out var customerDepositId))
            {
                MessageBox.Show(this, Resources.InvalidCustomerIdString, Resources.ErrorTitleString,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else if (this.customerDepositContentTextBox.Text.Length <= 0)
            {
                MessageBox.Show(this, Resources.ErrorEmptyContentString, Resources.ErrorTitleString,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                CashFlows.Deposit(customerDepositId, this.customerDepositAmountNumeric.Value, this.customerDepositContentTextBox.Text);
                MessageBox.Show(this, Resources.DepositSuccessfullyString, Resources.InformationTitleString,
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
            MessageBox.Show(this, ex.Message, ex.Source,
                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
    }

    public string PATH_TEMPLATE = Application.StartupPath + "\\Certificate1.xlsx";
    public string PATH_EXPORT = Application.StartupPath + "\\Certificate1Export.xlsx";

    private async void customerPrintButton_Click(object sender, EventArgs e)
    {
        var config = new OpenXmlConfiguration()
        {
            IgnoreTemplateParameterMissing = false,
        };

        var value = new
        {
            name = customerDepositNameTextBox.Text,
            money = customerDepositAmountNumeric.Text,
            content = customerDepositContentTextBox.Text
        };

        await MiniExcel.SaveAsByTemplateAsync(PATH_EXPORT, PATH_TEMPLATE, value, config);
        MessageBox.Show("Export successful");
    }
    #endregion

    #region Withdraw
    public void loadWithdraw()
    {
        using (var context = new SavingsManagementContext())
        {
            var deposits = context.CashFlows
                                .Where(d => d.BalanceChanging < 0)
                                .Select(d => new
                                {
                                    d.Id,
                                    d.CustomerId,
                                    CustomerName = context.CustomerAccounts
                                                           .Where(c => c.Id == d.CustomerId)
                                                           .Select(c => c.Name)
                                                           .FirstOrDefault(),
                                    d.Time,
                                    d.BalanceChanging,
                                    d.Content,
                                })
                                .ToList();

            dataGridViewWithdraw.DataSource = deposits;
            dataGridViewWithdraw.Columns["CustomerName"].HeaderText = "Customer Name";
            dataGridViewWithdraw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
        this.withdrawPrintButton.Enabled = false;
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
            this.withdrawPrintButton.Enabled = false;
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
            this.withdrawPrintButton.Enabled = !string.IsNullOrWhiteSpace(this.customerWithdrawContentTextBox.Text);
        }
    }

    private void customerWithdrawContentTextBox_TextChanged(object sender, EventArgs e)
    {
        this.customerWithdrawButton.Enabled = !string.IsNullOrWhiteSpace(this.customerWithdrawContentTextBox.Text)
            && !string.IsNullOrWhiteSpace(this.customerWithdrawIdTextBox.Text);
        this.withdrawPrintButton.Enabled = !string.IsNullOrWhiteSpace(this.customerWithdrawContentTextBox.Text)
            && !string.IsNullOrWhiteSpace(this.customerWithdrawIdTextBox.Text);
    }

    private void customerWithdrawButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (!int.TryParse(this.customerWithdrawIdTextBox.Text, CultureInfo.CurrentCulture, out var customerWithdrawId))
            {
                MessageBox.Show(this, Resources.InvalidCustomerIdString, Resources.ErrorTitleString,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else if (this.customerWithdrawContentTextBox.Text.Length <= 0)
            {
                MessageBox.Show(this, Resources.ErrorEmptyContentString, Resources.ErrorTitleString,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                CashFlows.Withdraw(customerWithdrawId, this.customerWithdrawAmountNumeric.Value, this.customerWithdrawContentTextBox.Text);
                MessageBox.Show(this, Resources.WithdrawSuccessfullyString, Resources.InformationTitleString,
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
            MessageBox.Show(this, ex.Message, ex.Source,
                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
    }
    
    public string PATH_WITHDRAW = Application.StartupPath + "\\Certificate2.xlsx";
    public string PATH_EXPORTWD = Application.StartupPath + "\\Certificate2Export.xlsx";
    private async void withdrawPrintButton_Click(object sender, EventArgs e)
    {
        var config = new OpenXmlConfiguration()
        {
            IgnoreTemplateParameterMissing = false,
        };

        var value = new
        {
            name = customerWithdrawNameTextBox.Text,
            money = customerWithdrawAmountNumeric.Text,
            content = customerWithdrawContentTextBox.Text
        };

        await MiniExcel.SaveAsByTemplateAsync(PATH_EXPORTWD, PATH_WITHDRAW, value, config);
        MessageBox.Show("Export successful");
    }
    #endregion

    #region Custome Management
    private void loadCustomer()
    {
        using (var context = new SavingsManagementContext())
        {
            var customers = context.CustomerAccounts.Select(c => new
            {
                c.Id,
                c.Name,
                c.IsMale,
                c.CicNumber,
                c.BirthDate,
                c.PhoneNumber,
                c.Address,
                c.Email,
                c.Username,
                c.HashedPassword,
                c.Balance,
                c.IsDisabled,
            }).ToList();
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
            customerBirthDateTimePicker.Value = birthDate;
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

    private void addCustomerBtn_Click(object sender, EventArgs e)
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
                Balance = Decimal.Zero,
                IsDisabled = false
            };

            context.CustomerAccounts.Add(customer);
            context.SaveChanges();
            loadCustomer();
            MessageBox.Show("New customer successfully added, please update information!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void disableCustomerBtn_Click(object sender, EventArgs e)
    {
        if (dataGridViewCustomer.CurrentRow.Index.Equals(null))
        {
            MessageBox.Show("Please select a customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (customerDisableCheckBox.Checked)
        {
            MessageBox.Show("Account has been disabled, please choose another account!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Customer account successfully deactivated!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    private void saveCustomerBtn_Click(object sender, EventArgs e)
    {
        if (dataGridViewCustomer.CurrentRow.Index.Equals(null))
        {
            MessageBox.Show("Please select a customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

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

        int customerId = Convert.ToInt32(customerIdTextBox.Text);

        using (var context = new SavingsManagementContext())
        {
            var customer = context.CustomerAccounts.FirstOrDefault(c => c.Id == customerId);
            if (customer != null)
            {
                if (customer.IsDisabled)
                {
                    MessageBox.Show("Please activate current account if you want to change information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                customer.Name = customerNameTextBox.Text;
                customer.IsMale = customerMaleCheckBox.Checked;
                customer.CicNumber = customerCicNumberTextBox.Text;
                customer.BirthDate = new DateOnly(customerBirthDateTimePicker.Value.Year, customerBirthDateTimePicker.Value.Month, customerBirthDateTimePicker.Value.Day);
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

    private void clearScreenCustomerBtn_Click(object sender, EventArgs e)
    {
        customerIdTextBox.Text = "";
        customerNameTextBox.Text = "";
        customerMaleCheckBox.Checked = false;
        customerCicNumberTextBox.Text = "";
        customerBirthDateTimePicker.Value = DateTime.Now.Date;
        customerPhoneNumberTextBox.Text = "";
        customerAddressTextBox.Text = "";
        customerEmailTextBox.Text = "";
        customerUsernameTextBox.Text = "";
        customerHashedPasswordTextBox.Text = "";
        customerBalanceTextBox.Text = "";
        customerDisableCheckBox.Checked = false;
        customerSearchTextBox.Text = "";
        MessageBox.Show("Screen cleared successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void customerHashedPasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
        {
            customerHashedPasswordTextBox.Text = PasswordHasher.HashPassword(null!, customerHashedPasswordTextBox.Text);
        }
    }
    private void enableCustomerBtn_Click(object sender, EventArgs e)
    {
        if (dataGridViewCustomer.CurrentRow.Index.Equals(null))
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
                customer.IsDisabled = false;
                context.SaveChanges();
                loadCustomer();
                MessageBox.Show("Customer account has been successfully activated!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    private void customerSearchTextBox_TextChanged(object sender, EventArgs e)
    {
        string search = customerSearchTextBox.Text.Trim();
        if (search == "")
        {
            loadCustomer();
        }
        else
        {
            using (var context = new SavingsManagementContext())
            {
                DateOnly searchDate;
                bool isDate = DateOnly.TryParse(search, out searchDate);
                var customers = context.CustomerAccounts
                                       .Where(c =>
                                           c.Id.ToString().Contains(search) ||
                                           c.Name.Contains(search) ||
                                           c.IsMale.ToString().Contains(search) ||
                                           c.CicNumber.Contains(search) ||
                                           c.PhoneNumber.Contains(search) ||
                                           c.Address.Contains(search) ||
                                           c.Email.Contains(search) ||
                                           c.Username.Contains(search) ||
                                           c.HashedPassword.Contains(search) ||
                                           (isDate && c.BirthDate == searchDate) ||
                                           c.Balance.ToString().Contains(search) ||
                                           c.IsDisabled.ToString().Contains(search))
                                       .Select(c => new
                                       {
                                           c.Id,
                                           c.Name,
                                           c.IsMale,
                                           c.CicNumber,
                                           c.BirthDate,
                                           c.PhoneNumber,
                                           c.Address,
                                           c.Email,
                                           c.Username,
                                           c.HashedPassword,
                                           c.Balance,
                                           c.IsDisabled,
                                       })
                                       .ToList();
                dataGridViewCustomer.DataSource = customers;
                dataGridViewCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
    }
    #endregion

    #region Staff Management
    private void loadStaff()
    {
        using (var context = new SavingsManagementContext())
        {
            var staffs = context.StaffAccounts.Select(c => new
            {
                c.Id,
                c.Name,
                c.IsMale,
                c.Position,
                c.Username,
                c.HashedPassword,
                c.PermissionId,
                c.IsDisabled,
            }).ToList();
            dataGridViewStaff.DataSource = staffs;
            dataGridViewStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        using (var context = new SavingsManagementContext())
        {
            var staffPermissions = context.StaffPermissions.ToList();
            var formattedPermissions = staffPermissions.Select(p => new
            {
                Display = $"{p.Id} - {p.Name}",
                p.Id
            }).ToList();
            staffPermissionIdComboBox.DataSource = formattedPermissions;
            staffPermissionIdComboBox.DisplayMember = "Display";
            staffPermissionIdComboBox.ValueMember = "Id";
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
    private void staffHashedPasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
        {
            staffHashedPasswordTextBox.Text = PasswordHasher.HashPassword(null!, staffHashedPasswordTextBox.Text);
        }
    }

    private void addStaffBtn_Click(object sender, EventArgs e)
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

    private void saveStaffBtn_Click(object sender, EventArgs e)
    {
        if (dataGridViewStaff.CurrentRow.Index.Equals(null))
        {
            MessageBox.Show("Please select a staff!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (staffNameTextBox.Text.IsNullOrEmpty() ||
            staffPositionTextBox.Text.IsNullOrEmpty() ||
            staffUsernameTextBox.Text.IsNullOrEmpty() ||
            staffHashedPasswordTextBox.Text.IsNullOrEmpty())
        {
            MessageBox.Show("Please fill in all blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        int staffId = Convert.ToInt32(staffIdTextBox.Text);

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
                if (staff.IsDisabled)
                {
                    MessageBox.Show("Please activate current account if you want to change information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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

    private void disableStaffBtn_Click(object sender, EventArgs e)
    {
        if (dataGridViewStaff.CurrentRow.Index.Equals(null))
        {
            MessageBox.Show("Please select a staff!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (staffDisableCheckBox.Checked)
        {
            MessageBox.Show("Account has been disabled, please choose another account!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        int staffId = Convert.ToInt32(staffIdTextBox.Text);

        using (var context = new SavingsManagementContext())
        {
            var staff = context.StaffAccounts.FirstOrDefault(s => s.Id == staffId);
            var staffPermission = context.StaffPermissions.FirstOrDefault(sp => sp.Id == staff.PermissionId);
            if (staffPermission.Name.Equals("Admin"))
            {
                MessageBox.Show("Can't disable admin account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (staff != null)
            {
                staff.IsDisabled = true;
                context.SaveChanges();
                loadStaff();
                MessageBox.Show("Staff account successfully deactivated!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    private void clearScreenStaffBtn_Click(object sender, EventArgs e)
    {
        staffIdTextBox.Text = "";
        staffNameTextBox.Text = "";
        staffMaleCheckBox.Checked = false;
        staffPositionTextBox.Text = "";
        staffUsernameTextBox.Text = "";
        staffHashedPasswordTextBox.Text = "";
        staffPermissionIdComboBox.SelectedItem = staffPermissionIdComboBox.Items[0];
        staffDisableCheckBox.Checked = false;
        staffSearchTextBox.Text = "";
        MessageBox.Show("Screen cleared successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void enableStaffBtn_Click(object sender, EventArgs e)
    {
        if (dataGridViewStaff.CurrentRow.Index.Equals(null))
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
                staff.IsDisabled = false;
                context.SaveChanges();
                loadStaff();
                MessageBox.Show("Staff account has been successfully activated!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    private void staffSearchTextBox_TextChanged(object sender, EventArgs e)
    {
        string search = staffSearchTextBox.Text.Trim();
        if (search == "")
        {
            loadStaff();
        }
        else
        {
            using (var context = new SavingsManagementContext())
            {
                var staffs = context.StaffAccounts
                                   .Where(s =>
                                       s.Id.ToString().Contains(search) ||
                                       s.Name.Contains(search) ||
                                       s.IsMale.ToString().Contains(search) ||
                                       s.Position.Contains(search) ||
                                       s.Username.Contains(search) ||
                                       s.HashedPassword.Contains(search) ||
                                       s.PermissionId.ToString().Contains(search) ||
                                       s.IsDisabled.ToString().Contains(search))
                                   .Select(s => new
                                   {
                                       s.Id,
                                       s.Name,
                                       s.IsMale,
                                       s.Position,
                                       s.Username,
                                       s.HashedPassword,
                                       s.PermissionId,
                                       s.IsDisabled,
                                   })
                                   .ToList();
                dataGridViewStaff.DataSource = staffs;
                dataGridViewStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
    }
    #endregion

    
}
