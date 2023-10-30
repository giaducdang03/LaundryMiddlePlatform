using BusinessObjects.Models;
using Microsoft.VisualBasic.ApplicationServices;
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
        public Store currentStore { get; set; }
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
                var storeView = storeList.Select(p => new
                {
                    p.StoreId,
                    p.Name,
                    p.Address,
                    p.PhoneNumber

                });
                source.DataSource = storeView;
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

        private void dgvStore_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmServiceOfStore f = new frmServiceOfStore();
            f.currentStore = currentStore;
            f.Show();
            this.Hide();
        }
    }
}
