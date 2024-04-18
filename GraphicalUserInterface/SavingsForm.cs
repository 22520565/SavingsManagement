namespace GraphicalUserInterface;

using System;
using System.Globalization;
using System.Windows.Forms;
using Business;
using Entity;

public partial class SavingsForm : Form
{
    private const string InterestTextFormat = "{0:#,0.00#%}/year";
    private const string BalanceTextFormat = "{0:#,0.00#}";
    private int periodSelected = 0;
    private decimal interestRateSelected = 0.0M;

    public SavingsForm()
    {
        this.InitializeComponent();
    }

    private void SavingsForm_Load(object sender, EventArgs e)
    {
        try
        {
            var customerAccount = CustomerAccounts.GetCustomerAccount(CurrentUser.Id);
            this.balanceDepositTextBox.Text = string.Format(
                CultureInfo.CurrentCulture, BalanceTextFormat, customerAccount.Balance);
            this.amountDepositNumeric.Maximum = customerAccount.Balance;

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

    private void savingComboBox_Click(object sender, EventArgs e)
    {
        try
        {
            this.savingDetailsComboBox.Items.Clear();
            foreach (object id in Savings.SavingsId)
            {
                this.savingDetailsComboBox.Items.Add(id);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void savingComboBox_SelectionChangeCommitted(object sender, EventArgs e)
    {
        if (this.savingDetailsComboBox.SelectedItem is int savingId)
        {
            try
            {
                Saving saving = Savings.GetSaving(savingId);
                this.balanceDetailsTextBox.Text = string.Format(
                    CultureInfo.CurrentCulture, BalanceTextFormat, saving.Balance);
                this.periodDetailsTextBox.Text = saving.PeriodInMonths.ToString(CultureInfo.CurrentCulture);
                this.interestDetailsTextBox.Text = string.Format(
                    CultureInfo.InvariantCulture, InterestTextFormat, saving.AnnualInterestRate);
                this.openDateDetailsTextBox.Text = DateOnly.FromDateTime(saving.OpenDate.LocalDateTime)
                                                            .ToString(CultureInfo.CurrentCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            MessageBox.Show(this, "An error occurred! Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void periodDepositComboBox_SelectionChangeCommitted(object sender, EventArgs e)
    {
        try
        {
            SavingInterestRate savingInterestRate = SavingInterestRates.Collection[this.periodDepositComboBox.SelectedIndex];
            this.periodSelected = savingInterestRate.PeriodInMonths;
            this.interestRateSelected = savingInterestRate.AnnualInterestRate;
            this.interestDepositTextBox.Text = string.Format(
                CultureInfo.InvariantCulture, InterestTextFormat, this.interestRateSelected);
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void depositButton_Click(object sender, EventArgs e)
    {
        try
        {
            Savings.Deposit(this.periodSelected, this.interestRateSelected, this.amountDepositNumeric.Value);
            MessageBox.Show(this, "Successfully depositing savings", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.SavingsForm_Load(null, EventArgs.Empty);
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
