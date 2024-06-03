using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using Business;
using DataAccess;
using System.Data.SqlClient;
using System.Data;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Identity;
using System.Security.Cryptography;

namespace GraphicalUserInterface
{
    public partial class StaffMenuForm : Form
    {
        public bool GoingBackToLoginForm { get; private set; } = false;

        private static readonly PasswordHasher<String> PasswordHasher = new();

        SqlConnection connection;
        SqlCommand command;
        String sql = @"Data Source=DESKTOP-O6AO007\SQLEXPRESS;Initial Catalog=SavingsManagement;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tableCustomer = new DataTable();

        public void Connection()
        {
            connection = new SqlConnection(sql);
            connection.Open();
            loadCustomer();
        }

        public StaffMenuForm()
        {
            InitializeComponent();
            Connection();
            customerIdTextBox.Enabled = false;
            customerBalanceTextBox.Enabled = false;
            dataGridViewCustomer.ReadOnly = true;
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

        # region Custome Management
        private void loadCustomer()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM CustomerAccounts";
            adapter.SelectCommand = command;
            tableCustomer.Clear();
            adapter.Fill(tableCustomer);
            dataGridViewCustomer.DataSource = tableCustomer;
            dataGridViewCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridViewCustomer.CurrentRow.Index;
            customerIdTextBox.Text = dataGridViewCustomer.Rows[i].Cells[0].Value.ToString();
            customerNameTextBox.Text = dataGridViewCustomer.Rows[i].Cells[1].Value.ToString();
            customerMaleCheckBox.Checked = Convert.ToBoolean(dataGridViewCustomer.Rows[i].Cells[2].Value);
            customerCicNumberTextBox.Text = dataGridViewCustomer.Rows[i].Cells[3].Value.ToString();
            // Chuyển đổi giá trị ngày tháng từ chuỗi thành kiểu DateTime trước khi gán cho DateTimePicker
            if (DateTime.TryParse(dataGridViewCustomer.Rows[i].Cells[4].Value.ToString(), out DateTime birthDate))
            {
                customerBirthDatePicker.Value = birthDate;
            }
            customerPhoneNumberTextBox.Text = dataGridViewCustomer.Rows[i].Cells[5].Value.ToString();
            customerAddressTextBox.Text = dataGridViewCustomer.Rows[i].Cells[6].Value.ToString();
            customerEmailTextBox.Text = dataGridViewCustomer.Rows[i].Cells[7].Value.ToString();
            customerUsernameTextBox.Text = dataGridViewCustomer.Rows[i].Cells[8].Value.ToString();
            customerHashedPasswordTextBox.Text = dataGridViewCustomer.Rows[i].Cells[9].Value.ToString();
            customerBalanceTextBox.Text = dataGridViewCustomer.Rows[i].Cells[10].Value.ToString();
            customerDisableCheckBox.Checked = Convert.ToBoolean(dataGridViewCustomer.Rows[i].Cells[11].Value);
        }

        // Hàm kiểm tra xem một địa chỉ email đã tồn tại trong cơ sở dữ liệu hay chưa
        private bool IsEmailExists(string email)
        {
            bool result = false;
            // Tạo câu lệnh SQL để kiểm tra xem địa chỉ email đã tồn tại hay chưa
            string query = "SELECT COUNT(*) FROM CustomerAccounts WHERE Email = @Email";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", email);
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    result = true;
                }
            }
            return result;
        }

        // Hàm tạo một địa chỉ email duy nhất
        private string GenerateUniqueEmail()
        {
            string email;
            do
            {
                // Tạo một số ngẫu nhiên có độ dài 6
                string randomNumber = new Random().Next(100000, 999999).ToString();
                // Kết hợp số ngẫu nhiên với địa chỉ email cơ sở
                email = $"user{randomNumber}@example.com";
            }
            while (IsEmailExists(email)); // Kiểm tra xem địa chỉ email đã tồn tại hay chưa
            return email;
        }

        // Hàm kiểm tra xem một Username đã tồn tại trong cơ sở dữ liệu hay chưa
        private bool IsUsernameExists(string username)
        {
            bool result = false;
            // Tạo câu lệnh SQL để kiểm tra xem địa chỉ email đã tồn tại hay chưa
            string query = "SELECT COUNT(*) FROM CustomerAccounts WHERE Username = @Username";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    result = true;
                }
            }
            return result;
        }

        // Hàm tạo một Username duy nhất
        private string GenerateUniqueUsername()
        {
            string username;
            do
            {
                // Tạo một số ngẫu nhiên có độ dài 6
                string randomNumber = new Random().Next(100000, 999999).ToString();
                // Kết hợp số ngẫu nhiên với tên user cơ sở
                username = $"user{randomNumber}";
            }
            while (IsUsernameExists(username)); // Kiểm tra xem Username đã tồn tại hay chưa
            return username;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Mã hóa mật khẩu "123"
            string hashedPassword = PasswordHasher.HashPassword(null!, "123");

            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO CustomerAccounts VALUES(@Name, @IsMale, @CicNumber, @BirthDate, @PhoneNumber, @Address, @Email, @Username, @HashedPassword, @Balance, @IsDisabled)";
            command.Parameters.AddWithValue("@Name", "Customer");
            command.Parameters.AddWithValue("@IsMale", false);
            command.Parameters.AddWithValue("@CicNumber", 0);
            command.Parameters.AddWithValue("@BirthDate", DateTime.Now.Date); 
            command.Parameters.AddWithValue("@PhoneNumber", 0);
            command.Parameters.AddWithValue("@Address", "Việt Nam");
            command.Parameters.AddWithValue("@Email", GenerateUniqueEmail());
            command.Parameters.AddWithValue("@Username", GenerateUniqueUsername());
            command.Parameters.AddWithValue("@HashedPassword", hashedPassword);
            command.Parameters.AddWithValue("@Balance", 0.0);
            command.Parameters.AddWithValue("@IsDisabled", false);
            command.ExecuteNonQuery();
            loadCustomer();
            MessageBox.Show("New customer successfully added, please update information!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewCustomer.CurrentRow.Index.Equals(0))
            {
                MessageBox.Show("Please select a customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            command = connection.CreateCommand();
            command.CommandText = "UPDATE CustomerAccounts SET IsDisabled = @IsDisabled WHERE Id = @CustomerId";
            command.Parameters.AddWithValue("@IsDisabled", true);
            command.Parameters.AddWithValue("@CustomerId", Int32.Parse(customerIdTextBox.Text));
            command.ExecuteNonQuery();
            loadCustomer();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewCustomer.CurrentRow.Index.Equals(0))
            {
                MessageBox.Show("Please select a customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (customerNameTextBox.Text.IsNullOrEmpty() ||
                customerCicNumberTextBox.Text.IsNullOrEmpty() ||
                customerPhoneNumberTextBox.Text.IsNullOrEmpty() ||
                customerAddressTextBox.Text.IsNullOrEmpty() ||
                customerEmailTextBox.Text.IsNullOrEmpty() ||
                customerUsernameTextBox.Text.IsNullOrEmpty() ||
                customerHashedPasswordTextBox.Text.IsNullOrEmpty() ||
                customerBalanceTextBox.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please fill in all blanks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                command = connection.CreateCommand();
                command.CommandText = "UPDATE CustomerAccounts SET Name = @Name, IsMale = @IsMale, CicNumber = @CicNumber, BirthDate = @BirthDate, " +
                                  "PhoneNumber = @PhoneNumber, Address = @Address, Email = @Email, Username = @Username, HashedPassword = @HashedPassword, " +
                                  "IsDisabled = @IsDisabled WHERE Id = @CustomerId";
                command.Parameters.AddWithValue("@Name", customerNameTextBox.Text);
                command.Parameters.AddWithValue("@IsMale", customerMaleCheckBox.Checked);
                command.Parameters.AddWithValue("@CicNumber", customerCicNumberTextBox.Text);
                command.Parameters.AddWithValue("@BirthDate", customerBirthDatePicker.Value);
                command.Parameters.AddWithValue("@PhoneNumber", customerPhoneNumberTextBox.Text);
                command.Parameters.AddWithValue("@Address", customerAddressTextBox.Text);
                command.Parameters.AddWithValue("@Email", customerEmailTextBox.Text);
                command.Parameters.AddWithValue("@Username", customerUsernameTextBox.Text);
                command.Parameters.AddWithValue("@HashedPassword", customerHashedPasswordTextBox.Text);
                command.Parameters.AddWithValue("@IsDisabled", customerDisableCheckBox.Checked);
                command.Parameters.AddWithValue("@CustomerId", Int32.Parse(customerIdTextBox.Text));
                command.ExecuteNonQuery();
                loadCustomer();
                MessageBox.Show("Updated customer information successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void customerHashedPasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                customerHashedPasswordTextBox.Text = PasswordHasher.HashPassword(null!, customerHashedPasswordTextBox.Text);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            customerIdTextBox.Text = "";
            customerNameTextBox.Text = "";
            customerMaleCheckBox.Checked = false;
            customerCicNumberTextBox.Text = "";
            customerBirthDatePicker.Value = DateTime.Now.Date;
            customerPhoneNumberTextBox.Text = "";
            customerAddressTextBox.Text = "";
            customerEmailTextBox.Text = "";
            customerUsernameTextBox.Text = "";
            customerHashedPasswordTextBox.Text = "";
            customerBalanceTextBox.Text = "";
            customerDisableCheckBox.Checked = false;
            MessageBox.Show("Screen cleared successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
