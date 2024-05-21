namespace GraphicalUserInterface;

using System;
using System.Globalization;
using System.Windows.Forms;
using Business;
using DataAccess;

public partial class SavingForm : Form
{
    private const string InterestTextFormat = "{0:#,0.00#%}/year";
    private const string BalanceTextFormat = "{0:#,0.00##}";
    private SavingDepositInfo? savingDepositInfo = new SavingDepositInfo();
    private SavingWithdrawInfo? savingWithdrawInfo = new SavingWithdrawInfo();

    public SavingForm()
    {
        this.InitializeComponent();
    }

    private void LoadForm()
    {
        try
        {
            var customerBalance = CustomerAccounts.CurrentCustomerBalance;
            this.balanceDepositTextBox.Text = string.Format(
                CultureInfo.CurrentCulture, BalanceTextFormat, customerBalance);
            this.amountDepositNumeric.Maximum = customerBalance is decimal balance ? balance : decimal.Zero;

            this.savingDetailsComboBox.SelectedItem = null;
            this.savingWithdrawComboBox.SelectedItem = null;
            this.periodDepositComboBox.SelectedItem = null;

            this.savingDetailsComboBox.Items.Clear();
            this.savingWithdrawComboBox.Items.Clear();
            foreach (object id in Savings.SavingsId)
            {
                this.savingDetailsComboBox.Items.Add(id);
                this.savingWithdrawComboBox.Items.Add(id);
            }

            this.periodDepositComboBox.Items.Clear();
            foreach (var period in SavingInterestRates.Periods)
            {
                this.periodDepositComboBox.Items.Add(period);
            }

            this.savingTabControl.SelectedTab = this.detailsTabPage;
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }
    }

    private void SavingsForm_Load(object sender, EventArgs e)
    {
        this.LoadForm();
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

            this.withdrawDetailsButton.Enabled = false;
        }
        else if (this.savingDetailsComboBox.SelectedItem is int savingId)
        {
            try
            {
                Saving saving = Savings.GetSaving(savingId);
                this.balanceDetailsTextBox.Text = string.Format(
                    CultureInfo.CurrentCulture, BalanceTextFormat, saving.Balance);
                this.periodDetailsTextBox.Text = saving.PeriodInMonths.ToString(CultureInfo.CurrentCulture);
                this.interestDetailsTextBox.Text = string.Format(
                    CultureInfo.InvariantCulture, InterestTextFormat, saving.AnnualInterestRate);
                this.openDayDetailsTextBox.Text = DateOnly.FromDateTime(saving.OpeningDateTime.LocalDateTime)
                    .ToString(CultureInfo.CurrentCulture);
                this.maturityDayDetailsTextBox.Text = Savings.GetMaturityDate(saving.OpeningDateTime, saving.PeriodInMonths)
                    .ToString(CultureInfo.CurrentCulture);

                this.withdrawDetailsButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.LoadForm();
            }
        }
        else
        {
            MessageBox.Show(this, Properties.Resources.UnknownErrorString, Properties.Resources.ErrorTitleString,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.LoadForm();
        }
    }

    private void periodDepositComboBox_SelectedValueChanged(object sender, EventArgs e)
    {
        if (this.periodDepositComboBox.SelectedItem is null)
        {
            this.savingDepositInfo = null;

            this.interestDepositTextBox.Text = string.Empty;
            this.maturityDayDepositTextBox.Text = string.Empty;
            this.amountDepositNumeric.Value = this.amountDepositNumeric.Minimum;

            this.depositButton.Enabled = false;
        }
        else if (this.periodDepositComboBox.SelectedItem is int period)
        {
            try
            {
                this.savingDepositInfo = new SavingDepositInfo
                {
                    PeriodInMonths = period,
                    AnnualInterestRate = SavingInterestRates.GetInterest(period),
                };

                this.interestDepositTextBox.Text = string.Format(
                    CultureInfo.InvariantCulture, InterestTextFormat, this.savingDepositInfo.AnnualInterestRate);
                this.maturityDayDepositTextBox.Text = DateOnly.FromDateTime(DateTimeOffset.Now.LocalDateTime)
                                                        .AddMonths(this.savingDepositInfo.PeriodInMonths)
                                                        .ToString(CultureInfo.CurrentCulture);

                this.depositButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.LoadForm();
            }
        }
        else
        {
            MessageBox.Show(this, Properties.Resources.UnknownErrorString, Properties.Resources.ErrorTitleString,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.LoadForm();
        }
    }

    private void depositButton_Click(object sender, EventArgs e)
    {
        try
        {
            ArgumentNullException.ThrowIfNull(this.savingDepositInfo);

            const string confirmationFormatText = "Please confirm the following information of depositing saving before processing:\n" +
                                                    "- Periods (months): {0}\n" +
                                                    "- Annual interest rate: {1:#,0.00##%}/year\n" +
                                                    "- Ammount: {2:#,0.00##}\n";
            this.savingDepositInfo.Balance = this.amountDepositNumeric.Value;

            if (MessageBox.Show(this, string.Format(CultureInfo.CurrentCulture, confirmationFormatText,
                this.savingDepositInfo.PeriodInMonths, this.savingDepositInfo.AnnualInterestRate, this.savingDepositInfo.Balance),
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                Savings.Deposit(this.savingDepositInfo);
                MessageBox.Show(this, "Successfully depositing savings", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LoadForm();
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.LoadForm();
        }
    }

    private void withdrawDetailsButton_Click(object sender, EventArgs e)
    {
        this.savingWithdrawComboBox.SelectedItem = this.savingDetailsComboBox.SelectedItem;
        this.savingTabControl.SelectedTab = this.withdrawTabPage;
    }

    private void savingWithdrawComboBox_SelectedValueChanged(object sender, EventArgs e)
    {
        if (this.savingWithdrawComboBox.SelectedItem is null)
        {
            this.savingWithdrawInfo = null;

            this.balanceWithdrawTextBox.Text = string.Empty;
            this.maturityDayWithdrawTextBox.Text = string.Empty;
            this.amountToGetWithdrawTextBox.Text = string.Empty;

            this.withdrawWithdrawButton.Enabled = false;
        }
        else if (this.savingWithdrawComboBox.SelectedItem is int savingId)
        {
            try
            {
                this.savingWithdrawInfo = Savings.GetWithdrawInfo(savingId);
                this.balanceWithdrawTextBox.Text = string.Format(
                    CultureInfo.CurrentCulture, BalanceTextFormat, savingWithdrawInfo.Balance);
                this.maturityDayWithdrawTextBox.Text = savingWithdrawInfo.MaturityDate.ToString(CultureInfo.CurrentCulture);
                this.amountToGetWithdrawTextBox.Text = string.Format(
                    CultureInfo.CurrentCulture, BalanceTextFormat, savingWithdrawInfo.AmountToGet);

                this.withdrawWithdrawButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.LoadForm();
            }
        }
        else
        {
            MessageBox.Show(this, Properties.Resources.UnknownErrorString, Properties.Resources.ErrorTitleString,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.LoadForm();
        }
    }

    private void withdrawWithdrawButton_Click(object sender, EventArgs e)
    {
        try
        {
            ArgumentNullException.ThrowIfNull(this.savingWithdrawInfo);

            const string warningWithdrawBeforeMaturityDayText = "You are about to withdraw your saving before its maturity day. " +
                "You will receive only non-term savings interest. " +
                "Are you sure you want to proceed this?";
            if (this.savingWithdrawInfo.MaturityDate <= DateOnly.FromDateTime(DateTime.Now) ||
                (MessageBox.Show(this, warningWithdrawBeforeMaturityDayText, "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                == DialogResult.Yes))
            {
                Savings.Withdraw(this.savingWithdrawInfo.Id);
                MessageBox.Show(this, "Successfully withdrawing savings", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        this.LoadForm();
    }
}
