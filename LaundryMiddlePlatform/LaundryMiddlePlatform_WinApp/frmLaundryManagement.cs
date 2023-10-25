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
        public frmLaundryManagement()
        {
            InitializeComponent();
        }

        private void frmLaundryManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnStoreManagement_Click(object sender, EventArgs e)
        {
            frmStoreManagement f = new frmStoreManagement();
            f.Show();
            this.Hide();

        }
    }
}
