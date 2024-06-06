namespace GraphicalUserInterface;

using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Business;
using DataAccess;
using GraphicalUserInterface.Properties;
using OfficeOpenXml;

public partial class CustomerMenuForm : Form
{
    public bool GoingBackToLoginForm { get; private set; } = false;
    DataTable dt;
    private SavingOpeningInfo? savingDepositInfo = new SavingOpeningInfo();
    private SavingWithdrawInfo? savingWithdrawInfo = new SavingWithdrawInfo();

    public CustomerMenuForm()
    {
        InitializeComponent();
        InitializeStatistical();
        InitializeSavings();
        InitializeSystem();
    }

    #region System
    private void InitializeSystem()
    {
        LoadingAccountInfo();
    }

    public void LoadingAccountInfo()
    {
        try
        {
            CustomerAccount? customerAccount = CustomerAccounts.CurrentCustomerAccount;
            if (customerAccount is not null)
            {
                this.customerIdTextBox.Text = customerAccount.Id.ToString(CultureInfo.CurrentCulture);
                this.customerNameTextBox.Text = customerAccount.Name;
                this.customerGenderTextBox.Text = customerAccount.IsMale ? Resources.MaleString : Resources.FemaleString;
                this.customerCicNumberTextBox.Text = customerAccount.CicNumber;
                this.customerBirthdayTextBox.Text = customerAccount.BirthDate.ToString(CultureInfo.CurrentCulture);
                this.customerPhoneNumberTextBox.Text = customerAccount.PhoneNumber;
                this.customerEmailTextBox.Text = customerAccount.Email;
                this.customerAddressTextBox.Text = customerAccount.Address;
                this.customerUsernameTextBox.Text = customerAccount.Username;
                this.customerBalanceTextBox.Text = customerAccount.Balance.ToString(Resources.CurrencyStringFormat, CultureInfo.CurrentCulture);
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
    private void customerChangePasswordButton_Click(object sender, EventArgs e)
    {
        using var form = new PasswordChangingForm("Customer");
        form.ShowDialog();
    }

    #endregion
    #region Savings
    private void InitializeSavings()
    {
        this.LoadSavingTab();
    }

    private void LoadSavingTab()
    {
        try
        {
            var customerBalance = CustomerAccounts.CurrentCustomerBalance;
            this.balanceOpeningTextBox.Text = customerBalance?.ToString(
                Resources.CurrencyStringFormat, CultureInfo.InvariantCulture)
                ?? decimal.Zero.ToString(
                Resources.CurrencyStringFormat, CultureInfo.InvariantCulture);
            this.amountOpeningNumeric.Maximum = customerBalance is decimal balance
                ? Math.Round(balance, this.amountOpeningNumeric.DecimalPlaces, MidpointRounding.ToZero)
                : decimal.Zero;

            this.savingDetailsComboBox.SelectedItem = null;
            this.savingClosingComboBox.SelectedItem = null;
            this.periodOpeningComboBox.SelectedItem = null;

            this.savingDetailsComboBox.Items.Clear();
            this.savingClosingComboBox.Items.Clear();
            foreach (object id in Savings.SavingsId)
            {
                this.savingDetailsComboBox.Items.Add(id);
                this.savingClosingComboBox.Items.Add(id);
            }

            this.periodOpeningComboBox.Items.Clear();
            foreach (var period in SavingInterestRates.Periods)
            {
                this.periodOpeningComboBox.Items.Add(period);
            }

            this.savingTabControl.SelectedTab = this.detailsTabPage;
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }
    }

    private void savingDetailsComboBox_SelectedValueChanged(object sender, EventArgs e)
    {
        if (this.savingDetailsComboBox.SelectedItem is null)
        {
            this.balanceDetailsTextBox.Text = string.Empty;
            this.periodDetailsTextBox.Text = string.Empty;
            this.interestDetailsTextBox.Text = string.Empty;
            this.openDayDetailsTextBox.Text = string.Empty;
            this.maturityDayDetailsTextBox.Text = string.Empty;

            this.exportDetailsButton.Enabled = false;
            this.closeSavingDetailsButton.Enabled = false;
        }
        else if (this.savingDetailsComboBox.SelectedItem is int savingId)
        {
            try
            {
                Saving saving = Savings.GetSaving(savingId);
                this.balanceDetailsTextBox.Text = saving.Balance.ToString(
                    Resources.CurrencyStringFormat, CultureInfo.InvariantCulture);
                this.periodDetailsTextBox.Text = saving.PeriodInMonths.ToString(CultureInfo.CurrentCulture);
                this.interestDetailsTextBox.Text = saving.AnnualInterestRate.ToString(
                    Resources.InterestTextFormatString, CultureInfo.InvariantCulture);
                this.openDayDetailsTextBox.Text = DateOnly.FromDateTime(saving.OpeningDateTime.LocalDateTime)
                    .ToString(CultureInfo.CurrentCulture);
                this.maturityDayDetailsTextBox.Text = Savings.GetMaturityDate(saving.OpeningDateTime, saving.PeriodInMonths)
                    .ToString(CultureInfo.CurrentCulture);

                this.exportDetailsButton.Enabled = true;
                this.closeSavingDetailsButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.LoadSavingTab();
            }
        }
        else
        {
            MessageBox.Show(this, Properties.Resources.UnknownErrorString, Properties.Resources.ErrorTitleString,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.LoadSavingTab();
        }
    }

    private void periodDepositComboBox_SelectedValueChanged(object sender, EventArgs e)
    {
        if (this.periodOpeningComboBox.SelectedItem is null)
        {
            this.savingDepositInfo = null;

            this.interestOpeningTextBox.Text = string.Empty;
            this.maturityDayOpeningTextBox.Text = string.Empty;
            this.amountOpeningNumeric.Value = this.amountOpeningNumeric.Minimum;

            this.openingSavingOpeningButton.Enabled = false;
        }
        else if (this.periodOpeningComboBox.SelectedItem is int period)
        {
            try
            {
                this.savingDepositInfo = new SavingOpeningInfo
                {
                    PeriodInMonths = period,
                    AnnualInterestRate = SavingInterestRates.GetInterest(period),
                };

                this.interestOpeningTextBox.Text = this.savingDepositInfo.AnnualInterestRate.ToString(
                    Resources.InterestTextFormatString, CultureInfo.InvariantCulture);
                this.maturityDayOpeningTextBox.Text = DateOnly.FromDateTime(DateTimeOffset.Now.LocalDateTime)
                                                        .AddMonths(this.savingDepositInfo.PeriodInMonths)
                                                        .ToString(CultureInfo.CurrentCulture);

                this.openingSavingOpeningButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.LoadSavingTab();
            }
        }
        else
        {
            MessageBox.Show(this, Properties.Resources.UnknownErrorString, Properties.Resources.ErrorTitleString,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.LoadSavingTab();
        }
    }

    private void openingSavingOpeningButton_Click(object sender, EventArgs e)
    {
        try
        {
            ArgumentNullException.ThrowIfNull(this.savingDepositInfo);

            this.savingDepositInfo.Balance = this.amountOpeningNumeric.Value;

            if (MessageBox.Show(this, string.Format(CultureInfo.CurrentCulture, Properties.Resources.OpeningSavingConfirmationStringFormat,
                this.savingDepositInfo.PeriodInMonths, this.savingDepositInfo.AnnualInterestRate, this.savingDepositInfo.Balance),
                Properties.Resources.ConfirmationTitleString, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                Savings.Open(this.savingDepositInfo);
                MessageBox.Show(this, Properties.Resources.OpeningSavingSuccessfullyString, Properties.Resources.InformationTitleString,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LoadSavingTab();
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.LoadSavingTab();
        }
    }

    private void exportDetailsButton_Click(object sender, EventArgs e)
    {
        if (this.savingDetailsComboBox.SelectedItem is int savingId)
        {
            using var savingReportForm = new SavingReportForm(Savings.GetSaving(savingId));
            savingReportForm.ShowDialog(this);
        }
        else
        {
            MessageBox.Show(
                Resources.UnknownErrorString,
                Resources.ErrorTitleString,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
        }
    }

    private void closingSavingDetailsButton_Click(object sender, EventArgs e)
    {
        this.savingClosingComboBox.SelectedItem = this.savingDetailsComboBox.SelectedItem;
        this.savingTabControl.SelectedTab = this.closingTabPage;
    }


    private void savingClosingComboBox_SelectedValueChanged(object sender, EventArgs e)
    {
        if (this.savingClosingComboBox.SelectedItem is null)
        {
            this.savingWithdrawInfo = null;

            this.balanceClosingTextBox.Text = string.Empty;
            this.maturityDayClosingTextBox.Text = string.Empty;
            this.amountToGetClosingTextBox.Text = string.Empty;

            this.closingSavingClosingButton.Enabled = false;
        }
        else if (this.savingClosingComboBox.SelectedItem is int savingId)
        {
            try
            {
                this.savingWithdrawInfo = Savings.GetWithdrawInfo(savingId);
                this.balanceClosingTextBox.Text = savingWithdrawInfo.Balance.ToString(
                    Resources.CurrencyStringFormat, CultureInfo.InvariantCulture);
                this.maturityDayClosingTextBox.Text = savingWithdrawInfo.MaturityDate.ToString(CultureInfo.CurrentCulture);
                this.amountToGetClosingTextBox.Text = savingWithdrawInfo.AmountToGet.ToString(
                    Resources.CurrencyStringFormat, CultureInfo.InvariantCulture);

                this.closingSavingClosingButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.LoadSavingTab();
            }
        }
        else
        {
            MessageBox.Show(this, Properties.Resources.UnknownErrorString, Properties.Resources.ErrorTitleString,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.LoadSavingTab();
        }
    }

    private void closingSavingClosingButton_Click(object sender, EventArgs e)
    {
        try
        {
            ArgumentNullException.ThrowIfNull(this.savingWithdrawInfo);

            if (this.savingWithdrawInfo.MaturityDate <= DateOnly.FromDateTime(DateTime.Now) ||
                (MessageBox.Show(this, Properties.Resources.ClosingSavingBeforeMaturityDayWarningString, Properties.Resources.WarningTitleString,
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                == DialogResult.Yes))
            {
                Savings.Close(this.savingWithdrawInfo.Id);
                MessageBox.Show(this, Properties.Resources.ClosingSavingSuccessfullyString, Properties.Resources.InformationTitleString,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        this.LoadSavingTab();
    }
    #endregion
    #region Statistical

    private void InitializeStatistical()
    {
        LoadingScene();
        LoadingTransactionList();
    }

    public void LoadingScene()
    {
        panelSavings.LeftColor = Color.FromArgb(0, 221, 176);
        panelSavings.RightColor = Color.FromArgb(0, 221, 176);
        panelExpenses.LeftColor = Color.FromArgb(244, 132, 132);
        panelExpenses.RightColor = Color.FromArgb(244, 132, 132);

        groupBoxTransactionList.BackColor = Color.FromArgb(1, 242, 240, 245);
        groupBoxStats.BackColor = Color.FromArgb(1, 242, 240, 245);
        groupBoxFunction.BackColor = Color.FromArgb(1, 242, 240, 245);
    }

    public void LoadingTransactionList()
    {
        dt = new DataTable();
        dt.Columns.AddRange(new[] { new DataColumn("Amount", typeof(string)),
                        new DataColumn("Transaction Time", typeof(string)),
            new DataColumn("Content", typeof(string))});
        int? currentCustomerId = CustomerAccounts.CurrentCustomerId;
        if (currentCustomerId.HasValue)
        {
            decimal expenses = decimal.Zero;
            decimal savings = decimal.Zero;
            var cashFlows = CashFlows.GetCashFlowsByCustomerId(currentCustomerId.Value);
            foreach (var cashFlow in cashFlows)
            {
                AddCashFlowEntry(cashFlow);
                if (cashFlow.BalanceChanging < decimal.Zero)
                {
                    expenses -= cashFlow.BalanceChanging;
                }
                else
                {
                    savings += cashFlow.BalanceChanging;
                }
            }
            lbExpenses.Text = expenses.ToString(Resources.CurrencyStringFormat, CultureInfo.InvariantCulture);
            lbSavings.Text = savings.ToString(Resources.CurrencyStringFormat, CultureInfo.InvariantCulture);
        }
        else
        {
            MessageBox.Show(Resources.NoCustomerLoggingInString);
        }

    }

    private void AddCashFlowEntry(CashFlow cashFlow)
    {
        dt.Rows.Add(cashFlow.BalanceChanging.ToString(Resources.CurrencyStringFormat, CultureInfo.InvariantCulture),
            cashFlow.Time.ToString(Resources.DateTimeStringFormat, CultureInfo.CurrentCulture),
            cashFlow.Content);
        this.data_Transactions.DataSource = dt;
        data_Transactions.Columns[0].ReadOnly = false;
        for (int k = 1; k < data_Transactions.Columns.Count; k++)
        {
            data_Transactions.Columns[k].ReadOnly = true;
        }
        this.data_Transactions.AllowUserToAddRows = false;
    }

    private void btnExport_Click(object sender, EventArgs e)
    {
        try
        {
            using SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = Resources.SavingExcelFileFilter;
            if (data_Transactions.Rows.Count > 0 && saveFile.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(saveFile.FileName);
                if (fileInfo.Exists)
                {
                    fileInfo.Delete();
                }
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using ExcelPackage pck = new ExcelPackage(fileInfo);
                ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Sheet1");
                for (int i = 0; i < data_Transactions.Columns.Count; i++)
                {
                    ws.Cells[1, i + 1].Value = data_Transactions.Columns[i].HeaderText.ToUpper(CultureInfo.InvariantCulture);
                    for (int j = 0; j < data_Transactions.Columns.Count; j++)
                    {
                        ws.Cells[i + 2, j + 1].Value = data_Transactions.Rows[i].Cells[j].Value;
                    }
                }
                pck.Save();

                using FileStream fs = File.Open(saveFile.FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                MessageBox.Show(Resources.ExportingFileSuccessfullyString,
                    Resources.InformationTitleString,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
    }

    #endregion

    // FIXME
    private void Form_MainMenu_Load(object sender, EventArgs e)
    {
        this.GoingBackToLoginForm = false;
    }

    private void accountInformationToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using var accountInfoForm = new AccountInfoForm();
        accountInfoForm.ShowDialog(this);
    }

    private void accountManagementToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using var accountManagementForm = new AccountManagementForm();
        accountManagementForm.ShowDialog(this);
    }

    private void customerInformationToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using var personalInfoForm = new PersonalInfoForm();
        personalInfoForm.ShowDialog(this);
    }

    private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
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
}
