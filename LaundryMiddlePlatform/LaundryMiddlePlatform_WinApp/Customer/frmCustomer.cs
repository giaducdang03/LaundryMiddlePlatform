﻿using BusinessObjects.Models;
using LaundryMiddlePlatform_WinApp.Admin;
using LaundryMiddlePlatform_WinApp.Customer;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryMiddlePlatform_WinApp
{
    public partial class frmCustomer : Form
    {
        public Account loginUser { get; set; }
        public Store currentStore { get; set; }
        IAccountRepository _repo = new AccountRepository();

        public Account loginAccount { get; set; }

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            homeToolStripMenuItem_Click(sender, e);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHome f = new frmHome();
            f.currentStore = currentStore;
            f.loginUser = loginUser;
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void yourProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfile f = new frmProfile();
            f.loginUser = loginUser;
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Are you sure logout the system?", "Laundry Middle Platform",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                loginAccount = null;
                frmLogin f = new frmLogin();
                f.Show();
                this.Hide();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void frmCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you want exit?", "Laundry Middle Platform",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (d == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void orderHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderHistoryCustomer f = new frmOrderHistoryCustomer();
            f.currentStore = currentStore;
            f.loginUser = loginUser;
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }
    }
}
