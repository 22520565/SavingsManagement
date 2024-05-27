namespace GraphicalUserInterface;

using System;
using System.Drawing;
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
		Form bg = new Form();
		CloseWindow logOut = new CloseWindow();
		using (logOut) {
            logOut.Notification.Text = "Do you want to log out?";
            logOut.Text = "Log out";
            logOut.Confirm.Text = "Log out";
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
		if (logOut.IsNotClosed == false) {
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

    private void savingToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using var savingForm = new SavingForm();
        savingForm.ShowDialog(this);
    }

    private void statisticalToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using var statistic = new StatisticForm();
        statistic.ShowDialog(this);
    }
}
