namespace GraphicalUserInterface;

using System;
using System.Windows.Forms;

public partial class MainMenuForm : Form
{
    public bool GoingBackToLoginForm { get; private set; } = false;

    public MainMenuForm()
    {
        InitializeComponent();
    }

    private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show(
                Properties.Resources.LogOutConfirmationString,
                Properties.Resources.NotificationTitleString,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)
            == DialogResult.Yes)
        {
            this.GoingBackToLoginForm = true;
            this.Close();
        }
    }

    // FIXME
    private void Form_MainMenu_Load(object sender, EventArgs e)
    {
        this.GoingBackToLoginForm = false;

        switch (string.Empty)
        {
            case "error":
                MessageBox.Show("User authorization error!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            case "admin":
                break;
            case "staff":
                accountManagementToolStripMenuItem.Enabled = false;
                changeRegulationsToolStripMenuItem.Enabled = false;
                break;
            case "customer":
                accountManagementToolStripMenuItem.Enabled = false;
                statisticalToolStripMenuItem.Enabled = false;
                changeRegulationsToolStripMenuItem.Enabled = false;
                break;
        }
    }

    private void accountInformationToolStripMenuItem_Click(object sender, EventArgs e)
    {
        new AccountInfoForm().ShowDialog(this);
    }

    private void accountManagementToolStripMenuItem_Click(object sender, EventArgs e)
    {
        new AccountManagementForm().ShowDialog(this);
    }

    private void customerInformationToolStripMenuItem_Click(object sender, EventArgs e)
    {
        new PersonalInfoForm().ShowDialog(this);
    }

    private void savingToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using var savingForm = new SavingForm();
        savingForm.ShowDialog(this);
    }
}
