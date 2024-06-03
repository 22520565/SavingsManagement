using System;
using System.Windows.Forms;
using Business;
using GraphicalUserInterface.Properties;

namespace GraphicalUserInterface
{
    public partial class PasswordChangingForm : Form
    {
        public PasswordChangingForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                string oldPassword = this.txtOldPass.Text;
                string newPassword = this.txtNewPass.Text;
                string confirmPassword = this.txtConfrimNew.Text;
                if (!confirmPassword.Equals(newPassword, StringComparison.Ordinal))
                {
                    MessageBox.Show(this, Resources.ConfirmationPasswordNotMatchedString, Resources.ErrorTitleString,
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    switch (CustomerAccounts.ChangePassword(oldPassword, newPassword))
                    {
                        case CustomerAccounts.PasswordChangingResult.Success:
                            MessageBox.Show(this, Resources.PasswordChangingSuccessfullyString, Resources.NotificationTitleString,
                                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            this.Close();
                            break;

                        case CustomerAccounts.PasswordChangingResult.EmptyOldPassword:
                            MessageBox.Show(this, Resources.OldPasswordEmptyString, Resources.NotificationTitleString,
                                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            break;

                        case CustomerAccounts.PasswordChangingResult.InvalidNewPassword:
                            MessageBox.Show(this, Resources.NewPasswordInvalidString, Resources.NotificationTitleString,
                                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            break;

                        case CustomerAccounts.PasswordChangingResult.WrongOldPassword:
                            MessageBox.Show(this, Resources.OldPasswordIncorrectString, Resources.NotificationTitleString,
                                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            break;

                        default:
                            MessageBox.Show(this, Resources.UnknownErrorString, Resources.ErrorTitleString,
                                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, ex.Source,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
