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
    }
}
