using BusinessObjects.Models;
using LaundryMiddlePlatform_WinApp.Admin;
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
    public partial class frmLaundryManagement : Form
    {
        public Account loginAccount { get; set; }
        public frmLaundryManagement()
        {
            InitializeComponent();
        }

        private void frmLaundryManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void accountManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountManagement f = new frmAccountManagement();
            f.loginAccount = loginAccount;
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
