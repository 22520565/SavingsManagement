using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalUserInterface
{
    public partial class changePass : Form
    {
        public changePass()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            String pass = this.txtOldPass.Text.Trim();
            String newpass = this.txtNewPass.Text.Trim();
            String confirmnew = this.txtConfrimNew.Text.Trim();
            if (pass == null || newpass == null || confirmnew == null || pass.Equals("") || newpass.Equals("") || confirmnew.Equals(""))
            {
                MessageBox.Show(this, "Please enter complete infomation", "Notification", MessageBoxButtons.OK);
                this.txtOldPass.Text = String.Empty;
                this.txtNewPass.Text = String.Empty;
                this.txtConfrimNew.Text = String.Empty;
            }
            else
            {
                if (CustomerAccounts.checkPass(pass))
                {

                    if (newpass.Equals(confirmnew))
                    {
                        CustomerAccounts.updatePass(newpass);
                        MessageBox.Show(this, "Change password successfully", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(this, "Wrong confirm password, Please retry!", "Notification", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    MessageBox.Show(this, "Wrong old password. Please retry!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
