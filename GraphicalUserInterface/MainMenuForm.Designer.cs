namespace Gui
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            accountInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            accountManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            customerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openASavingsBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            sendMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            rútTiềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            statisticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            changeRegulationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { systemToolStripMenuItem, serviceToolStripMenuItem, statisticalToolStripMenuItem, searchToolStripMenuItem, changeRegulationsToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1200, 46);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { accountInformationToolStripMenuItem, accountManagementToolStripMenuItem, customerInformationToolStripMenuItem, logOutToolStripMenuItem });
            systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            systemToolStripMenuItem.Size = new System.Drawing.Size(121, 42);
            systemToolStripMenuItem.Text = "System";
            // 
            // accountInformationToolStripMenuItem
            // 
            accountInformationToolStripMenuItem.Name = "accountInformationToolStripMenuItem";
            accountInformationToolStripMenuItem.Size = new System.Drawing.Size(397, 46);
            accountInformationToolStripMenuItem.Text = "Account Information";
            accountInformationToolStripMenuItem.Click += accountInformationToolStripMenuItem_Click;
            // 
            // accountManagementToolStripMenuItem
            // 
            accountManagementToolStripMenuItem.Name = "accountManagementToolStripMenuItem";
            accountManagementToolStripMenuItem.Size = new System.Drawing.Size(397, 46);
            accountManagementToolStripMenuItem.Text = "Account Management";
            accountManagementToolStripMenuItem.Click += accountManagementToolStripMenuItem_Click;
            // 
            // customerInformationToolStripMenuItem
            // 
            customerInformationToolStripMenuItem.Name = "customerInformationToolStripMenuItem";
            customerInformationToolStripMenuItem.Size = new System.Drawing.Size(397, 46);
            customerInformationToolStripMenuItem.Text = "Personal Information";
            customerInformationToolStripMenuItem.Click += customerInformationToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new System.Drawing.Size(397, 46);
            logOutToolStripMenuItem.Text = "Log out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // serviceToolStripMenuItem
            // 
            serviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { openASavingsBookToolStripMenuItem, sendMoneyToolStripMenuItem, rútTiềnToolStripMenuItem });
            serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            serviceToolStripMenuItem.Size = new System.Drawing.Size(121, 42);
            serviceToolStripMenuItem.Text = "Service";
            // 
            // openASavingsBookToolStripMenuItem
            // 
            openASavingsBookToolStripMenuItem.Name = "openASavingsBookToolStripMenuItem";
            openASavingsBookToolStripMenuItem.Size = new System.Drawing.Size(382, 46);
            openASavingsBookToolStripMenuItem.Text = "Open a savings book";
            // 
            // sendMoneyToolStripMenuItem
            // 
            sendMoneyToolStripMenuItem.Name = "sendMoneyToolStripMenuItem";
            sendMoneyToolStripMenuItem.Size = new System.Drawing.Size(382, 46);
            sendMoneyToolStripMenuItem.Text = "Send money";
            // 
            // rútTiềnToolStripMenuItem
            // 
            rútTiềnToolStripMenuItem.Name = "rútTiềnToolStripMenuItem";
            rútTiềnToolStripMenuItem.Size = new System.Drawing.Size(382, 46);
            rútTiềnToolStripMenuItem.Text = "Withdraw money";
            // 
            // statisticalToolStripMenuItem
            // 
            statisticalToolStripMenuItem.Name = "statisticalToolStripMenuItem";
            statisticalToolStripMenuItem.Size = new System.Drawing.Size(148, 42);
            statisticalToolStripMenuItem.Text = "Statistical";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new System.Drawing.Size(116, 42);
            searchToolStripMenuItem.Text = "Search";
            // 
            // changeRegulationsToolStripMenuItem
            // 
            changeRegulationsToolStripMenuItem.Name = "changeRegulationsToolStripMenuItem";
            changeRegulationsToolStripMenuItem.Size = new System.Drawing.Size(279, 42);
            changeRegulationsToolStripMenuItem.Text = "Change Regulations";
            // 
            // Form_MainMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(15F, 38F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1200, 684);
            Controls.Add(menuStrip1);
            Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "Form_MainMenu";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form_MainMenu";
            Load += Form_MainMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openASavingsBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendMoneyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rútTiềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeRegulationsToolStripMenuItem;
    }
}