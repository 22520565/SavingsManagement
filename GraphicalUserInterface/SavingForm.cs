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
    private SavingOpeningInfo? savingDepositInfo = new SavingOpeningInfo();
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
            this.balanceOpeningTextBox.Text = string.Format(
                CultureInfo.CurrentCulture, BalanceTextFormat, customerBalance);
            this.amountOpeningNumeric.Maximum = customerBalance is decimal balance ? balance : decimal.Zero;

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

            this.closeSavingDetailsButton.Enabled = false;
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

                this.closeSavingDetailsButton.Enabled = true;
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

                this.interestOpeningTextBox.Text = string.Format(
                    CultureInfo.InvariantCulture, InterestTextFormat, this.savingDepositInfo.AnnualInterestRate);
                this.maturityDayOpeningTextBox.Text = DateOnly.FromDateTime(DateTimeOffset.Now.LocalDateTime)
                                                        .AddMonths(this.savingDepositInfo.PeriodInMonths)
                                                        .ToString(CultureInfo.CurrentCulture);

                this.openingSavingOpeningButton.Enabled = true;
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
                this.LoadForm();
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.LoadForm();
        }
    }

    private void closingSavingDetailsButton_Click(object sender, EventArgs e)
    {
        this.savingClosingComboBox.SelectedItem = this.savingDetailsComboBox.SelectedItem;
        this.savingTabControl.SelectedTab = this.withdrawTabPage;
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
                this.balanceClosingTextBox.Text = string.Format(
                    CultureInfo.CurrentCulture, BalanceTextFormat, savingWithdrawInfo.Balance);
                this.maturityDayClosingTextBox.Text = savingWithdrawInfo.MaturityDate.ToString(CultureInfo.CurrentCulture);
                this.amountToGetClosingTextBox.Text = string.Format(
                    CultureInfo.CurrentCulture, BalanceTextFormat, savingWithdrawInfo.AmountToGet);

                this.closingSavingClosingButton.Enabled = true;
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
        this.LoadForm();
    }
}
