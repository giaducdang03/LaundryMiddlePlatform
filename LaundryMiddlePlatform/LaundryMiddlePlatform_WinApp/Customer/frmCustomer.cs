using BusinessObjects.Models;
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
        public Account loginUser {  get; set; }
        IAccountRepository _repo = new AccountRepository();

        public Account loginAccount { get; set; }

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHome f = new frmHome();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }
        private void yourProfileToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmProfile f = new frmProfile();
            f.loginUser = loginUser;
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }
    }
}
