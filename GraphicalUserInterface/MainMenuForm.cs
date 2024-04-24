namespace Gui;

using System;
using System.Windows.Forms;

public partial class MainMenuForm : Form
{
    public MainMenuForm()
    {
        InitializeComponent();
    }

    private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show(
                Resources.LogOutConfirmationString,
                Resources.NotificationTitleString,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)
            == DialogResult.Yes)
        {
            this.Hide();
            new LoginForm().ShowDialog();
            this.Close();
        }
    }

    // FIXME
    private void Form_MainMenu_Load(object sender, EventArgs e)
    {
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
        new Form_AccountInformation().ShowDialog(this);
    }

    private void accountManagementToolStripMenuItem_Click(object sender, EventArgs e)
    {
        new Form_AccountManagement().ShowDialog(this);
    }

    private void customerInformationToolStripMenuItem_Click(object sender, EventArgs e)
    {
        new Form_PersonalInformation().ShowDialog(this);
    }
}
