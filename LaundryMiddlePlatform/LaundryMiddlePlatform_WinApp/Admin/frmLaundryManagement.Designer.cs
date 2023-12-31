﻿namespace LaundryMiddlePlatform_WinApp
{
    partial class frmLaundryManagement
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            systemToolStripMenuItem = new ToolStripMenuItem();
            accountManagementToolStripMenuItem = new ToolStripMenuItem();
            storeManagementToolStripMenuItem = new ToolStripMenuItem();
            orderManagemnetToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, systemToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1318, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(139, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(139, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // systemToolStripMenuItem
            // 
            systemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { accountManagementToolStripMenuItem, storeManagementToolStripMenuItem, orderManagemnetToolStripMenuItem });
            systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            systemToolStripMenuItem.Size = new Size(111, 24);
            systemToolStripMenuItem.Text = "Management";
            // 
            // accountManagementToolStripMenuItem
            // 
            accountManagementToolStripMenuItem.Name = "accountManagementToolStripMenuItem";
            accountManagementToolStripMenuItem.Size = new Size(238, 26);
            accountManagementToolStripMenuItem.Text = "Account management";
            accountManagementToolStripMenuItem.Click += accountManagementToolStripMenuItem_Click;
            // 
            // storeManagementToolStripMenuItem
            // 
            storeManagementToolStripMenuItem.Name = "storeManagementToolStripMenuItem";
            storeManagementToolStripMenuItem.Size = new Size(238, 26);
            storeManagementToolStripMenuItem.Text = "Store management";
            storeManagementToolStripMenuItem.Click += storeManagementToolStripMenuItem_Click;
            // 
            // orderManagemnetToolStripMenuItem
            // 
            orderManagemnetToolStripMenuItem.Name = "orderManagemnetToolStripMenuItem";
            orderManagemnetToolStripMenuItem.Size = new Size(238, 26);
            orderManagemnetToolStripMenuItem.Text = "Order managemnet";
            orderManagemnetToolStripMenuItem.Click += orderManagemnetToolStripMenuItem_Click;
            // 
            // frmLaundryManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 840);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmLaundryManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Laundry Middle Platform";
            FormClosing += frmLaundryManagement_FormClosing;
            FormClosed += frmLaundryManagement_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem systemToolStripMenuItem;
        private ToolStripMenuItem accountManagementToolStripMenuItem;
        private ToolStripMenuItem storeManagementToolStripMenuItem;
        private ToolStripMenuItem orderManagemnetToolStripMenuItem;
    }
}