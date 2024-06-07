﻿using Business;
using DataAccess;
using GraphicalUserInterface.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicalUserInterface
{
    public partial class StaffChangeInfo : Form
    {
        public StaffChangeInfo()
        {
            InitializeComponent();
            LoadingAccountInfo();
        }
        public void LoadingAccountInfo()
        {
            try
            {
                StaffAccount? staffAccount = StaffAccounts.CurrentStaffAccount;
                if (staffAccount is not null)
                {
                    this.staffNameTextBox.Text = staffAccount.Name;
                    this.staffGenderCbx.Text = staffAccount.IsMale ? Resources.MaleString : Resources.FemaleString;
                    this.staffPositionTextBox.Text = staffAccount.Position;
                    this.staffUsernameTextBox.Text = staffAccount.Username;
                }
                else
                {
                    MessageBox.Show(this, Resources.FailedLoadingCustomerInfoString, Resources.ErrorTitleString,
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void staffChangeInfoButton_Click(object sender, EventArgs e)
        {
            StaffAccount staffAccount = new StaffAccount();
            string gender = this.staffGenderCbx.Text;
            if (gender == Resources.MaleString)
            {
                staffAccount.IsMale = true;
            }
            else
            {
                staffAccount.IsMale = false;
            }
            staffAccount.Name = staffNameTextBox.Text;
            staffAccount.Position = staffPositionTextBox.Text;
            staffAccount.Username = staffUsernameTextBox.Text;
            StaffAccounts.UpdateStaff(staffAccount);
            MessageBox.Show(this, "Change Infomation successfully", Resources.NotificationTitleString,
                                   MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            this.Close();
        }
    }
}
