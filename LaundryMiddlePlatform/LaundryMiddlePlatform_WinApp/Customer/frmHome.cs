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
using System.Xml.Linq;

namespace LaundryMiddlePlatform_WinApp.Customer
{
    public partial class frmHome : Form
    {
        IStoreRepository resp = new StoreRepository();
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            LoadStoreList();
        }

        public void LoadStoreList()
        {
            try
            {
                var storeList = resp.GetStores();
                BindingSource source = new BindingSource();
                source.DataSource = storeList;

                dgvStore.DataSource = null;
                dgvStore.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load Store List");
            }
        }

        private void lbHeader_Click(object sender, EventArgs e)
        {

        }

        private void dgvStore_DoubleClick(object sender, EventArgs e)
        {
            frmServiceOfStore f = new frmServiceOfStore();
            f.Show();
            this.Hide();
        }
    }
}
