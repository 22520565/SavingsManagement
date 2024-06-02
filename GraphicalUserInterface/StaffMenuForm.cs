namespace GraphicalUserInterface;

using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Business;
using DataAccess;
using GraphicalUserInterface.Properties;
using Microsoft.IdentityModel.Tokens;

public partial class StaffMenuForm : Form
{
    public bool GoingBackToLoginForm { get; private set; } = false;

    public StaffMenuForm()
    {
        InitializeComponent();
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

        if (!this.customerDepositIdTextBox.Text.IsNullOrEmpty() &&
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
        }
        else
        {
            this.customerDepositNameTextBox.Text = customerAccount.Name;
            this.customerDepositCicNumberTextBox.Text = customerAccount.CicNumber;
            this.customerDepositAmountNumeric.Enabled = true;
            this.customerDepositContentTextBox.Enabled = true;
            this.customerDepositButton.Enabled = !this.customerDepositContentTextBox.Text.IsNullOrEmpty();
        }
    }

    private void customerDepositContentTextBox_TextChanged(object sender, EventArgs e)
    {
        this.customerDepositButton.Enabled = !this.customerDepositContentTextBox.Text.IsNullOrEmpty()
            && !this.customerDepositIdTextBox.Text.IsNullOrEmpty();
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
}
