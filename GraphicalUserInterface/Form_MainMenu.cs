using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Entity;

namespace GraphicalUserInterface
{
    public partial class Form_MainMenu : Form
    {
        Account account;
        BUS_Account bus_account;

        public Form_MainMenu(Account accountLogin, BUS_Account bus_accountLogin)
        {
            InitializeComponent();
            this.account = accountLogin;
            this.bus_account = bus_accountLogin;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Do you want to log out?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                this.Hide();
                Form_Login login = new Form_Login();
                login.ShowDialog();
                this.Close();
            }
        }

        private void Form_MainMenu_Load(object sender, EventArgs e)
        {
            string main_menu = bus_account.checkAccountPermission(account);

            switch (main_menu)
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
            Form_AccountInformation accountInformation = new Form_AccountInformation();
            accountInformation.ShowDialog();
        }

        private void accountManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AccountManagement accountManagement = new Form_AccountManagement();
            accountManagement.ShowDialog();
        }

        private void customerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_PersonalInformation personalInformation = new Form_PersonalInformation();
            personalInformation.ShowDialog();
        }
    }
}
