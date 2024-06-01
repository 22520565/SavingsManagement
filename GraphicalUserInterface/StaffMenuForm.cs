using System;
using System.Drawing;
using System.Windows.Forms;
using Business;
using DataAccess;

namespace GraphicalUserInterface
{
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
            this.GoingBackToLoginForm = !logOut.IsNotClosed;
            e.Cancel = logOut.IsNotClosed;
        }

        private void StaffMenuForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.GoingBackToLoginForm = false;

                using var context = new SavingsManagementContext();
                switch (context.StaffAccounts.Find(StaffAccounts.CurrentStaffId)?.PermissionId)
                {
                    case 0:
                        tabControl1.TabPages.Add(tabPageManageAccounts); // Use descriptive names
                        tabControl1.TabPages.Add(tabPageChangeRegulations);
                        break;

                    case 1:
                        tabControl1.TabPages.Remove(tabPageManageAccounts);
                        tabControl1.TabPages.Remove(tabPageChangeRegulations);
                        break;

                    default:
                        MessageBox.Show("No permission found for your staff account.");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void StaffMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CurrentUser.StaffId = 0;
        }
    }
}
