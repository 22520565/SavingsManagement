using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

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

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-O6AO007\\SQLEXPRESS;Initial Catalog=SavingsManagement;Integrated Security=True;Trust Server Certificate=True"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT PermissionId FROM StaffAccounts WHERE StaffId = @StaffId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StaffId", CurrentUser.StaffId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Check if there's a result
                            {
                                int permissionId = reader.GetInt32(0);
                                switch (permissionId)
                                {
                                    case 1:
                                        tabControl1.TabPages.Add(tabPageManageAccounts); // Use descriptive names
                                        tabControl1.TabPages.Add(tabPageChangeRegulations);
                                        break;
                                    case 2:
                                        tabControl1.TabPages.Remove(tabPageManageAccounts);
                                        tabControl1.TabPages.Remove(tabPageChangeRegulations);
                                        break;
                                    default:
                                        // Handle other permission cases if any
                                        break;
                                }
                            }
                            else
                            {
                                // No permission found for the staff
                                MessageBox.Show("No permission found for your staff account.");
                            }
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"Database error: {sqlEx.Message}"); // More informative message
                }
            }
        }


        private void StaffMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CurrentUser.StaffId = 0;
        }
    }
}
