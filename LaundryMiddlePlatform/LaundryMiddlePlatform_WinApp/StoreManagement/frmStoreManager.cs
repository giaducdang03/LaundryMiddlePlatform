using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryMiddlePlatform_WinApp.StoreManagement
{
    public partial class frmStoreManager : Form
    {
        public Store currentStore { get; set; }
        public Account managerAccount { get; set; }
        public frmStoreManager()
        {
            InitializeComponent();
        }

        private void frmStoreManager_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmStoreManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServiceManagement f = new frmServiceManagement();
            f.managerAccount = managerAccount;
            f.currentStore = currentStore;
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void storeInfomationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStoreInfo f = new frmStoreInfo();
            f.managerAccount = managerAccount;
            f.currentStore = currentStore;
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderManagement f = new frmOrderManagement();
            f.managerAccount = managerAccount;
            f.currentStore = currentStore;
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Are you sure logout the system?", "Laundry Middle Platform",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                managerAccount = null;
                frmLogin f = new frmLogin();
                f.Show();
                this.Hide();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Close();
    }
}
