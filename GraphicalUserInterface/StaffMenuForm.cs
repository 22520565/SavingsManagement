namespace GraphicalUserInterface;

using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Business;
using DataAccess;
using GraphicalUserInterface.Properties;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using MiniExcelLibs;
using MiniExcelLibs.OpenXml;
using Excel = Microsoft.Office.Interop.Excel;

public partial class StaffMenuForm : Form
{
    public bool GoingBackToLoginForm { get; private set; } = false;

    DataTable dt;

    private static readonly PasswordHasher<String> PasswordHasher = new();

    private ImageList imageList = new ImageList();

    public StaffMenuForm()
    {
        InitializeComponent();
        InitializeInfo();
        loadCustomer();
        loadStaff();
        loadDeposit();
        loadWithdraw();
        loadDailyReport();
        customerIdTextBox.ReadOnly = true;
        customerBalanceTextBox.ReadOnly = true;
        dataGridViewCustomer.ReadOnly = true;
        staffIdTextBox.ReadOnly = true;
        dataGridViewStaff.ReadOnly = true;
        rbDaily.Checked = true;
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
        CurrentForm.SetSelectedForm(CurrentForm.OpenForm.Login);
        e.Cancel = logOut.IsNotClosed;
    }

    // FIXME
    private void StaffMenuForm_Load(object sender, EventArgs e)
    {
        this.GoingBackToLoginForm = false;

        this.imageList = new ImageList();
        this.imageList.ImageSize = new Size(40, 40);
        this.imageList.ColorDepth = ColorDepth.Depth32Bit;

        this.imageList.Images.Add("Information", GraphicalUserInterface.Properties.Resources.info);
        this.imageList.Images.Add("Deposit", GraphicalUserInterface.Properties.Resources.deposit);
        this.imageList.Images.Add("Withdraw", GraphicalUserInterface.Properties.Resources.withdrawal);
        this.imageList.Images.Add("Customer", GraphicalUserInterface.Properties.Resources.customermanagement);
        this.imageList.Images.Add("Staff", GraphicalUserInterface.Properties.Resources.staffmanagement);
        this.imageList.Images.Add("Report", GraphicalUserInterface.Properties.Resources.seo_report);
        this.imageList.Images.Add("Regulation", GraphicalUserInterface.Properties.Resources.regulation);

        this.tabControlStaffMenu.ImageList = this.imageList;
        this.tabPageInformation.ImageKey = "Information";
        this.tabPageDeposit.ImageKey = "Deposit";
        this.tabPageWithdraw.ImageKey = "Withdraw";
        this.tabPageManageCustomers.ImageKey = "Customer";
        this.tabPageManageStaffs.ImageKey = "Staff";
        this.tabPageFinancialReport.ImageKey = "Report";
        this.tabPageChangeRegulations.ImageKey = "Regulation";

        using var context = new SavingsManagementContext();
        switch (context.StaffAccounts.Find(StaffAccounts.CurrentStaffId)?.PermissionId)
        {
            case 1:
                break;
            case 2:
                tabControlStaffMenu.TabPages.Remove(tabPageManageStaffs);
                tabControlStaffMenu.TabPages.Remove(tabPageChangeRegulations);
                break;
            default:
                MessageBox.Show("No permission found for your staff account.");
                break;

        }


    }

    #region Information
    private void InitializeInfo()
    {
        LoadingAccountInfo();
        LoadUI();
        LoadingRateList();
    }

    private void LoadUI()
    {
        this.tabPageInformation.BackColor = Color.FromArgb(221, 228, 244);

        this.button1.BackColor = Color.FromArgb(23, 33, 175);
        this.staffChangePasswordButton.BackColor = Color.FromArgb(23, 33, 175);

        this.gbPersonal.BackColor = Color.FromArgb(191, 212, 252);
        this.gbFunction.BackColor = Color.FromArgb(191, 212, 252);
        this.gbAccount.BackColor = Color.FromArgb(191, 212, 252);
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
                this.staffBirthdayTxt.Text = staffAccount.BirthDate.ToString(CultureInfo.CurrentCulture);
                this.staffPhoneTxt.Text = staffAccount.PhoneNumber;
                this.staffAddressTxt.Text = staffAccount.Address;
                this.staffEmailTxt.Text = staffAccount.Email;
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
        PasswordChangingForm form = new PasswordChangingForm("Staff");
        Form bg = new Form();
        using (form)
        {
            bg.StartPosition = FormStartPosition.Manual;
            bg.FormBorderStyle = FormBorderStyle.None;
            bg.BackColor = Color.Black;
            bg.Opacity = 0.7d;
            bg.Size = this.Size;
            bg.Location = this.Location;
            bg.ShowInTaskbar = false;
            bg.Show(this);
            form.Owner = bg;
            form.ShowDialog(bg);
            bg.Dispose();
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Form bg = new Form();
        StaffChangeInfo form = new StaffChangeInfo();
        using (form)
        {
            bg.StartPosition = FormStartPosition.Manual;
            bg.FormBorderStyle = FormBorderStyle.None;
            bg.BackColor = Color.Black;
            bg.Opacity = 0.7d;
            bg.Size = this.Size;
            bg.Location = this.Location;
            bg.ShowInTaskbar = false;
            bg.Show(this);
            form.Owner = bg;
            form.ShowDialog(bg);
            bg.Dispose();
        }
        LoadingAccountInfo();
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
        data_rate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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

    #region Reload Screen
    public void ReloadCustomerScreen()
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
        customerBalanceTextBox.Text = "";
        customerDisableCheckBox.Checked = false;
        customerSearchTextBox.Text = "";
    }

    public void ReloadStaffScreen()
    {
        staffIdTextBox.Text = "";
        staffNameTextBox.Text = "";
        staffMaleCheckBox.Checked = false;
        staffBirthDateTimePicker.Value = DateTime.Now.Date;
        staffPhoneTextBox.Text = "";
        staffAddressTextBox.Text = "";
        staffEmailTextBox.Text = "";
        staffPositionTextBox.Text = "";
        staffUsernameTextBox.Text = "";
        staffPermissionIdComboBox.SelectedItem = staffPermissionIdComboBox.Items[0];
        staffDisableCheckBox.Checked = false;
        staffSearchTextBox.Text = "";
    }

    public void ReloadDepositScreen()
    {
        customerDepositIdTextBox.Text = "";
        customerDepositNameTextBox.Text = "";
        customerDepositCicNumberTextBox.Text = "";
        customerDepositAmountNumeric.Value = customerDepositAmountNumeric.Minimum;
        customerDepositContentTextBox.Text = "";
    }

    public void ReloadWithdrawScreen()
    {
        customerWithdrawIdTextBox.Text = "";
        customerWithdrawNameTextBox.Text = "";
        customerWithdrawCicNumberTextBox.Text = "";
        customerWithdrawBalanceTextBox.Text = "";
        customerWithdrawAmountNumeric.Value = customerDepositAmountNumeric.Minimum;
        customerWithdrawContentTextBox.Text = "";
    }

    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (tabControlStaffMenu.SelectedTab == tabPageManageCustomers)
        {
            ReloadCustomerScreen();
            loadCustomer();
        }
        else if (tabControlStaffMenu.SelectedTab == tabPageManageStaffs)
        {
            ReloadStaffScreen();
            loadStaff();
        }
        else if (tabControlStaffMenu.SelectedTab == tabPageDeposit)
        {
            ReloadDepositScreen();
            loadDeposit();
        }
        else if (tabControlStaffMenu.SelectedTab == tabPageWithdraw)
        {
            ReloadWithdrawScreen();
            loadWithdraw();
        }
        else if (tabControlStaffMenu.SelectedTab == tabPageFinancialReport)
        {
            dailyReportDateTimePicker.Value = DateTime.Now.Date;
            loadDailyReport();
        }
    }
    #endregion

    #region Deposit
    // FIXME
    public void loadDeposit()
    {
        using var context = new SavingsManagementContext();
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

    private void dataGridViewDeposit_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        int i = e.RowIndex;
        int customerId;
        if (int.TryParse(dataGridViewDeposit.Rows[i].Cells[1].Value.ToString(), out customerId))
        {
            customerDepositIdTextBox.Text = customerId.ToString();
        }
        customerDepositNameTextBox.Text = dataGridViewDeposit.Rows[i].Cells[2].Value.ToString();
        using (var context = new SavingsManagementContext())
        {
            var customer = context.CustomerAccounts.FirstOrDefault(c => c.Id == customerId); // Use == for comparison
            if (customer != null)
            {
                customerDepositCicNumberTextBox.Text = customer.CicNumber;
            }
        }
        decimal amount;
        if (decimal.TryParse(dataGridViewDeposit.Rows[i].Cells[4].Value.ToString(), out amount))
        {
            customerDepositAmountNumeric.Value = amount;
        }
        customerDepositContentTextBox.Text = dataGridViewDeposit.Rows[i].Cells[5].Value.ToString();
    }


    private void reportDepositBtn_Click(object sender, EventArgs e)
    {
        int depositId;
        int i = dataGridViewDeposit.CurrentRow.Index;
        if (int.TryParse(dataGridViewDeposit.Rows[i].Cells[0].Value.ToString(), out depositId))
        {
            ReportDepositForm reportDepositForm = new ReportDepositForm(depositId);
            reportDepositForm.ShowDialog();
        }
    }

    private void customerDepositIdTextBox_Enter(object sender, EventArgs e)
    {
        this.customerDepositNameTextBox.Text = string.Empty;
        this.customerDepositCicNumberTextBox.Text = string.Empty;
        this.customerDepositAmountNumeric.Enabled = false;
        this.customerDepositAmountNumeric.Maximum = decimal.Zero;
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
            this.customerDepositAmountNumeric.Maximum = decimal.Zero;
            this.customerDepositContentTextBox.Enabled = false;
            this.customerDepositButton.Enabled = false;
            this.customerPrintButton.Enabled = false;
        }
        else
        {
            this.customerDepositNameTextBox.Text = customerAccount.Name;
            this.customerDepositCicNumberTextBox.Text = customerAccount.CicNumber;
            this.customerDepositAmountNumeric.Enabled = true;
            this.customerDepositAmountNumeric.Maximum = Configurations.MaxAmountDepositing;
            this.customerDepositAmountNumeric.Minimum = Configurations.MinAmountDepositing;
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
            loadDeposit();
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, ex.Message, ex.Source,
                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
    }

    public string PATH_TEMPLATE = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.StartupPath).ToString()).ToString()).ToString()) + "\\Resources\\Certificate1.xlsx";
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
        export_Open(PATH_EXPORT);
    }
    #endregion

    #region Withdraw
    public void loadWithdraw()
    {
        using (var context = new SavingsManagementContext())
        {
            var deposits = (from cf in context.CashFlows
                            join ca in context.CustomerAccounts on cf.CustomerId equals ca.Id
                            where cf.BalanceChanging < 0
                            select new
                            {
                                cf.Id,
                                cf.CustomerId,
                                CustomerName = ca.Name,
                                cf.Time,
                                cf.BalanceChanging,
                                cf.Content,
                            }).ToList();

            dataGridViewWithdraw.DataSource = deposits;
            dataGridViewWithdraw.Columns["BalanceChanging"].HeaderText = "Withdraw Amount";
            dataGridViewWithdraw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }

    private void dataGridViewWithdraw_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        int i = e.RowIndex;
        int customerId;
        if (int.TryParse(dataGridViewWithdraw.Rows[i].Cells[1].Value.ToString(), out customerId))
        {
            customerWithdrawIdTextBox.Text = customerId.ToString();
        }
        customerWithdrawNameTextBox.Text = dataGridViewWithdraw.Rows[i].Cells[2].Value.ToString();
        using (var context = new SavingsManagementContext())
        {
            var customer = context.CustomerAccounts.FirstOrDefault(c => c.Id == customerId); // Use == for comparison
            if (customer != null)
            {
                customerWithdrawCicNumberTextBox.Text = customer.CicNumber;
                customerWithdrawBalanceTextBox.Text = customer.Balance.ToString();
            }
        }
        decimal amount;
        if (decimal.TryParse(dataGridViewWithdraw.Rows[i].Cells[4].Value.ToString(), out amount))
        {
            customerWithdrawAmountNumeric.Value = amount;
        }
        customerWithdrawContentTextBox.Text = dataGridViewWithdraw.Rows[i].Cells[5].Value.ToString();
    }

    private void reportWithdrawBtn_Click(object sender, EventArgs e)
    {
        int withdrawId;
        int i = dataGridViewWithdraw.CurrentRow.Index;
        if (int.TryParse(dataGridViewWithdraw.Rows[i].Cells[0].Value.ToString(), out withdrawId))
        {
            ReportWithdrawForm reportWithdrawForm = new ReportWithdrawForm(withdrawId);
            reportWithdrawForm.ShowDialog();
        }
    }

    private void customerWithdrawIdTextBox_Enter(object sender, EventArgs e)
    {
        this.customerWithdrawNameTextBox.Text = string.Empty;
        this.customerWithdrawCicNumberTextBox.Text = string.Empty;
        this.customerWithdrawBalanceTextBox.Text = string.Empty;
        this.customerWithdrawAmountNumeric.Enabled = false;
        this.customerWithdrawAmountNumeric.Maximum = decimal.Zero;
        this.amountWithdrawingErrorLabel.Visible = false;
        this.customerWithdrawContentTextBox.Enabled = false;
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
            this.amountWithdrawingErrorLabel.Visible = false;
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
            this.customerWithdrawAmountNumeric.Maximum = Math.Min(
                 Math.Round(customerAccount.Balance, this.customerWithdrawAmountNumeric.DecimalPlaces, MidpointRounding.ToZero),
                 Configurations.MaxAmountWithdrawing);
            this.customerWithdrawAmountNumeric.Minimum = Configurations.MinAmountWithdrawing;
            this.amountWithdrawingErrorLabel.Text = "The minimum amount to withdraw is "
                   + this.customerWithdrawAmountNumeric.Minimum.ToString(Resources.CurrencyStringFormat, CultureInfo.InvariantCulture);
            this.amountWithdrawingErrorLabel.Visible = customerAccount.Balance < this.customerWithdrawAmountNumeric.Minimum;
            this.customerWithdrawContentTextBox.Enabled = true;
            this.customerWithdrawButton.Enabled = !string.IsNullOrWhiteSpace(this.customerWithdrawContentTextBox.Text)
                && !this.amountWithdrawingErrorLabel.Visible;
            this.withdrawPrintButton.Enabled = !string.IsNullOrWhiteSpace(this.customerWithdrawContentTextBox.Text);
        }
    }

    private void customerWithdrawContentTextBox_TextChanged(object sender, EventArgs e)
    {
        this.customerWithdrawButton.Enabled = !string.IsNullOrWhiteSpace(this.customerWithdrawContentTextBox.Text)
            && !string.IsNullOrWhiteSpace(this.customerWithdrawIdTextBox.Text)
            && !this.amountWithdrawingErrorLabel.Visible;
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
            loadWithdraw();
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, ex.Message, ex.Source,
                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
    }

    public string PATH_WITHDRAW = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.StartupPath).ToString()).ToString()).ToString()) + "\\Resources\\Certificate2.xlsx";
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
        export_Open(PATH_EXPORTWD);
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
                c.Balance,
                c.IsDisabled,
            }).ToList();
            dataGridViewCustomer.DataSource = customers;
            dataGridViewCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }

    private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        int i = e.RowIndex;
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
        customerBalanceTextBox.Text = dataGridViewCustomer.Rows[i].Cells[9].Value.ToString();
        customerDisableCheckBox.Checked = Convert.ToBoolean(dataGridViewCustomer.Rows[i].Cells[10].Value);
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
                PhoneNumber = "0123456789",
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
        if (customerDisableCheckBox.Checked)
        {
            MessageBox.Show("Account has been disabled, please choose another account!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        int customerId;
        if (int.TryParse(customerIdTextBox.Text, out customerId))
        {
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
        else
        {
            MessageBox.Show("Please select a customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void saveCustomerBtn_Click(object sender, EventArgs e)
    {
        if (customerIdTextBox.Text.IsNullOrEmpty())
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
            customerBalanceTextBox.Text.IsNullOrEmpty())
        {
            MessageBox.Show("Please fill in all blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        int customerId;
        if (int.TryParse(customerIdTextBox.Text, out customerId))
        {
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
                    if (!IsValidEmail(customerEmailTextBox.Text))
                    {
                        MessageBox.Show(this, "Invalid format Email.\nPlease try again!", Resources.WarningTitleString,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                        return;
                    }
                    if (!IsValidPhoneNumber(customerPhoneNumberTextBox.Text))
                    {
                        MessageBox.Show(this, "Phone number has at least 10 to 11 digit and begin with 0.\nPlease try again!", Resources.WarningTitleString,
                            MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
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
                    customer.Balance = Convert.ToDecimal(customerBalanceTextBox.Text);
                    customer.IsDisabled = customerDisableCheckBox.Checked;
                    context.SaveChanges();
                    loadCustomer();
                    MessageBox.Show("Updated customer information successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }

    private static bool IsValidEmail(string email)
    {
        try
        {
            var mailAddress = new MailAddress(email);
            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }

    private static bool IsValidPhoneNumber(string phoneNumber)
    {
        if (string.IsNullOrWhiteSpace(phoneNumber))
            return false;
        string pattern = @"^0[0-9]{9,10}$";
        return Regex.IsMatch(phoneNumber, pattern);
    }

    private void clearScreenCustomerBtn_Click(object sender, EventArgs e)
    {
        ReloadCustomerScreen();
        MessageBox.Show("Screen cleared successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void enableCustomerBtn_Click(object sender, EventArgs e)
    {
        int customerId;
        if (int.TryParse(customerIdTextBox.Text, out customerId))
        {
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
        else
        {
            MessageBox.Show("Please select a customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                c.BirthDate,
                c.PhoneNumber,
                c.Address,
                c.Email,
                c.Position,
                c.Username,
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
        int i = e.RowIndex;
        staffIdTextBox.Text = dataGridViewStaff.Rows[i].Cells[0].Value.ToString();
        staffNameTextBox.Text = dataGridViewStaff.Rows[i].Cells[1].Value.ToString();
        staffMaleCheckBox.Checked = Convert.ToBoolean(dataGridViewStaff.Rows[i].Cells[2].Value);
        // Chuyển đổi giá trị ngày tháng từ chuỗi thành kiểu DateTime trước khi gán cho DateTimePicker
        if (DateTime.TryParse(dataGridViewStaff.Rows[i].Cells[3].Value.ToString(), out DateTime birthDate))
        {
            staffBirthDateTimePicker.Value = birthDate;
        }
        staffPhoneTextBox.Text = dataGridViewStaff.Rows[i].Cells[4].Value.ToString();
        staffAddressTextBox.Text = dataGridViewStaff.Rows[i].Cells[5].Value.ToString();
        staffEmailTextBox.Text = dataGridViewStaff.Rows[i].Cells[6].Value.ToString();
        staffPositionTextBox.Text = dataGridViewStaff.Rows[i].Cells[7].Value.ToString();
        staffUsernameTextBox.Text = dataGridViewStaff.Rows[i].Cells[8].Value.ToString();
        switch (dataGridViewStaff.Rows[i].Cells[9].Value)
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
        staffDisableCheckBox.Checked = Convert.ToBoolean(dataGridViewStaff.Rows[i].Cells[10].Value);
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

    private bool IsStaffEmailExists(string email)
    {
        using (var context = new SavingsManagementContext())
        {
            return context.StaffAccounts.Any(c => c.Email == email);
        }
    }

    private string GenerateUniqueStaffEmail()
    {
        string email;
        do
        {
            // Tạo một số ngẫu nhiên có độ dài 6
            string randomNumber = new Random().Next(100000, 999999).ToString();
            // Kết hợp số ngẫu nhiên với địa chỉ email cơ sở
            email = $"staff{randomNumber}@gmail.com";
        }
        while (IsStaffEmailExists(email)); // Kiểm tra xem địa chỉ email đã tồn tại hay chưa
        return email;
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
                PhoneNumber = "0",
                BirthDate = new DateOnly(DateTime.Now.Date.Year, DateTime.Now.Date.Month, DateTime.Now.Date.Day),
                Address = "Việt Nam",
                Email = GenerateUniqueStaffEmail(),
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
        if (staffIdTextBox.Text.IsNullOrEmpty())
        {
            MessageBox.Show("Please select a staff!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (staffNameTextBox.Text.IsNullOrEmpty() || staffAddressTextBox.Text.IsNullOrEmpty() || staffBirthDateTimePicker.Text.IsNullOrEmpty() ||
            staffPositionTextBox.Text.IsNullOrEmpty() || staffEmailTextBox.Text.IsNullOrEmpty() || staffPhoneTextBox.Text.IsNullOrEmpty() ||
            staffUsernameTextBox.Text.IsNullOrEmpty())
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

        int staffId;
        if (int.TryParse(staffIdTextBox.Text, out staffId))
        {
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
                    staff.BirthDate = new DateOnly(staffBirthDateTimePicker.Value.Year, staffBirthDateTimePicker.Value.Month, staffBirthDateTimePicker.Value.Day);
                    staff.PhoneNumber = staffPhoneTextBox.Text;
                    staff.Address = staffAddressTextBox.Text;
                    staff.Email = staffEmailTextBox.Text;
                    staff.Position = staffPositionTextBox.Text;
                    staff.Username = staffUsernameTextBox.Text;
                    staff.PermissionId = permissionId;
                    staff.IsDisabled = staffDisableCheckBox.Checked;

                    context.SaveChanges();
                    loadStaff();
                    MessageBox.Show("Updated staff information successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }

    private void disableStaffBtn_Click(object sender, EventArgs e)
    {
        if (staffDisableCheckBox.Checked)
        {
            MessageBox.Show("Account has been disabled, please choose another account!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        int staffId;
        if (int.TryParse(staffIdTextBox.Text, out staffId))
        {
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
        else
        {
            MessageBox.Show("Please select a staff!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void clearScreenStaffBtn_Click(object sender, EventArgs e)
    {
        ReloadStaffScreen();
        MessageBox.Show("Screen cleared successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void enableStaffBtn_Click(object sender, EventArgs e)
    {
        int staffId;
        if (int.TryParse(staffIdTextBox.Text, out staffId))
        {
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
        else
        {
            MessageBox.Show("Please select a staff!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                DateOnly searchDate;
                bool isDate = DateOnly.TryParse(search, out searchDate);
                var staffs = context.StaffAccounts
                                   .Where(s =>
                                       s.Id.ToString().Contains(search) ||
                                       s.Name.Contains(search) ||
                                       s.IsMale.ToString().Contains(search) ||
                                       s.PhoneNumber.Contains(search) ||
                                       s.Address.Contains(search) ||
                                       s.Email.Contains(search) ||
                                       (isDate && s.BirthDate == searchDate) ||
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
                                       s.BirthDate,
                                       s.PhoneNumber,
                                       s.Address,
                                       s.Email,
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

    #region Daily Report
    public class DailyReportItem
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public decimal Deposit { get; set; }
        public decimal Withdraw { get; set; }
        public decimal Profit { get; set; }
    }

    public void loadDailyReport()
    {
        DateTime selectedDate = dailyReportDateTimePicker.Value.Date;
        bool isMonthly = rbMonthly.Checked;

        using (var context = new SavingsManagementContext())
        {
            var dailys = (from cf in context.CashFlows
                          join ca in context.CustomerAccounts on cf.CustomerId equals ca.Id
                          where isMonthly ? cf.Time.Year == selectedDate.Year && cf.Time.Month == selectedDate.Month : cf.Time.Date == selectedDate
                          group cf by new { cf.CustomerId, ca.Name } into g
                          select new DailyReportItem
                          {
                              CustomerId = g.Key.CustomerId,
                              CustomerName = g.Key.Name,
                              Deposit = g.Where(cf => cf.BalanceChanging > 0).Sum(cf => cf.BalanceChanging),
                              Withdraw = g.Where(cf => cf.BalanceChanging < 0).Sum(cf => cf.BalanceChanging),
                              Profit = g.Sum(cf => cf.BalanceChanging)
                          }).ToList();

            dataGridViewDailyReport.DataSource = dailys;
            dataGridViewDailyReport.Columns["CustomerId"].HeaderText = "Customer ID";
            dataGridViewDailyReport.Columns["CustomerName"].HeaderText = "Customer Name";
            dataGridViewDailyReport.Columns["Deposit"].HeaderText = "Deposit";
            dataGridViewDailyReport.Columns["Withdraw"].HeaderText = "Withdraw";
            dataGridViewDailyReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }

    public void ExportExcel(string path)
    {
        // Tạo ứng dụng Excel và workbook mới
        Excel.Application application = new Excel.Application();
        Excel.Workbook workbook = application.Workbooks.Add(Type.Missing);
        Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1]; // Chuyển đổi kiểu dữ liệu ở đây

        // Lấy tổng số cột từ DataGridView
        int totalColumns = dataGridViewDailyReport.Columns.Count;

        bool isMonthly = rbMonthly.Checked;
        string reportTitle = isMonthly ? "Monthly Report" : "Daily Report";
        string reportDate = isMonthly ? $"Month/Year: {dailyReportDateTimePicker.Value.ToString("MM/yyyy")}" : $"Date: {dailyReportDateTimePicker.Value.ToShortDateString()}";

        // Thêm tiêu đề báo cáo ở dòng 1 và hợp nhất các cột
        Excel.Range headerRange1 = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, totalColumns]];
        headerRange1.Merge();
        headerRange1.Value = reportTitle;
        headerRange1.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
        headerRange1.Borders.LineStyle = Excel.XlLineStyle.xlContinuous; // Kẻ viền cho hàng đầu tiên
        headerRange1.Borders.Weight = Excel.XlBorderWeight.xlThin;

        // Thêm ngày được chọn từ DateTimePicker ở dòng 2 và hợp nhất các cột
        Excel.Range headerRange2 = worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, totalColumns]];
        headerRange2.Merge();
        headerRange2.Value = reportDate;
        headerRange2.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
        headerRange2.Borders.LineStyle = Excel.XlLineStyle.xlContinuous; // Kẻ viền cho hàng thứ hai
        headerRange2.Borders.Weight = Excel.XlBorderWeight.xlThin;

        // Gán tiêu đề cột từ DataGridView vào Excel, bắt đầu từ dòng thứ 3
        for (int i = 0; i < dataGridViewDailyReport.Columns.Count; i++)
        {
            worksheet.Cells[3, i + 1] = dataGridViewDailyReport.Columns[i].HeaderText;
            Excel.Range headerRange3 = (Excel.Range)worksheet.Cells[3, i + 1];
            headerRange3.Borders.LineStyle = Excel.XlLineStyle.xlContinuous; // Kẻ viền cho tiêu đề cột
            headerRange3.Borders.Weight = Excel.XlBorderWeight.xlThin;
        }

        // Gán dữ liệu từ DataGridView vào Excel, bắt đầu từ dòng thứ 4
        for (int i = 0; i < dataGridViewDailyReport.Rows.Count; i++)
        {
            for (int j = 0; j < dataGridViewDailyReport.Columns.Count; j++)
            {
                var cellValue = dataGridViewDailyReport.Rows[i].Cells[j].Value;
                if (cellValue is DateTimeOffset dto)
                {
                    cellValue = dto.ToLocalTime().Date;
                }
                worksheet.Cells[i + 4, j + 1] = cellValue; // Dữ liệu bắt đầu từ dòng thứ 4
                Excel.Range dataRange = (Excel.Range)worksheet.Cells[i + 4, j + 1];
                dataRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous; // Kẻ viền cho dữ liệu
                dataRange.Borders.Weight = Excel.XlBorderWeight.xlThin;
            }
        }

        // Điều chỉnh độ rộng cột để phù hợp với nội dung
        worksheet.Columns.AutoFit();

        // Lưu tập tin Excel
        workbook.SaveAs(path);
        workbook.Saved = true;

        // Giải phóng tài nguyên
        workbook.Close(false, Type.Missing, Type.Missing);
        application.Quit();
        System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
        System.Runtime.InteropServices.Marshal.ReleaseComObject(application);
    }

    private void dailyReportBtn_Click(object sender, EventArgs e)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Title = "Export Excel";
        saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|Excel Files (*.xls)|*.xls";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                ExportExcel(saveFileDialog.FileName);
                MessageBox.Show("Export excel file successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exporting excel file failed \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void dailyReportDateTimePicker_ValueChanged(object sender, EventArgs e)
    {
        loadDailyReport();
    }
    #endregion

    private void rbMonthly_CheckedChanged(object sender, EventArgs e)
    {
        if (rbMonthly.Checked)
        {
            dailyReportDateTimePicker.Format = DateTimePickerFormat.Custom;
            dailyReportDateTimePicker.CustomFormat = "MM/yyyy";
            dailyReportDateTimePicker.ShowUpDown = true;
            loadDailyReport();
        }
    }

    private void rbDaily_CheckedChanged(object sender, EventArgs e)
    {
        if (rbDaily.Checked)
        {
            dailyReportDateTimePicker.Format = DateTimePickerFormat.Custom;
            dailyReportDateTimePicker.CustomFormat = "dd/MM/yyyy";
            dailyReportDateTimePicker.ShowUpDown = false;
            loadDailyReport();
        }
    }

    public void export_Open(string filepath)
    {
        string fileExcel = filepath;
        Excel.Application xlapp;
        Excel.Workbook xlworkbook;
        xlapp = new Excel.Application();

        xlworkbook = xlapp.Workbooks.Open(fileExcel, 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);

        xlapp.Visible = true;
    }
}
