﻿namespace LaundryMiddlePlatform_WinApp
{
    partial class frmCustomer
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
            yourProfileToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            homeToolStripMenuItem = new ToolStripMenuItem();
            yourProfileToolStripMenuItem2 = new ToolStripMenuItem();
            orderHistoryToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { yourProfileToolStripMenuItem, homeToolStripMenuItem, yourProfileToolStripMenuItem2, orderHistoryToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1318, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // yourProfileToolStripMenuItem
            // 
            yourProfileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logOutToolStripMenuItem, exitToolStripMenuItem });
            yourProfileToolStripMenuItem.Name = "yourProfileToolStripMenuItem";
            yourProfileToolStripMenuItem.Size = new Size(60, 24);
            yourProfileToolStripMenuItem.Text = "Menu";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(139, 26);
            logOutToolStripMenuItem.Text = "Logout";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(139, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Checked = true;
            homeToolStripMenuItem.CheckState = CheckState.Checked;
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // yourProfileToolStripMenuItem2
            // 
            yourProfileToolStripMenuItem2.Name = "yourProfileToolStripMenuItem2";
            yourProfileToolStripMenuItem2.Size = new Size(99, 24);
            yourProfileToolStripMenuItem2.Text = "Your Profile";
            yourProfileToolStripMenuItem2.Click += yourProfileToolStripMenuItem_Click;
            // 
            // orderHistoryToolStripMenuItem
            // 
            orderHistoryToolStripMenuItem.Name = "orderHistoryToolStripMenuItem";
            orderHistoryToolStripMenuItem.Size = new Size(112, 24);
            orderHistoryToolStripMenuItem.Text = "Order History";
            orderHistoryToolStripMenuItem.Click += orderHistoryToolStripMenuItem_Click;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 881);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer";
            FormClosing += frmCustomer_FormClosing;
            FormClosed += frmCustomer_FormClosed;
            Load += frmCustomer_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem yourProfileToolStripMenuItem;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem orderHistoryToolStripMenuItem;
        private ToolStripMenuItem yourProfileToolStripMenuItem2;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}