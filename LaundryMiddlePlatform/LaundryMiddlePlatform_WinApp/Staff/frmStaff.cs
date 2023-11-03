using BusinessObjects.Models;
using LaundryMiddlePlatform_WinApp.StoreManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryMiddlePlatform_WinApp.Staff
{
    public partial class frmStaff : Form
    {
        public Account loginAccount { get; set; }
        public frmStaff()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void frmStaff_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void viewTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewOrder f = new frmViewOrder();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }
    }
}
