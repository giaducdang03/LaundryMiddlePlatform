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
        IServiceRepository _serviceRepo = new ServiceRepository();
        IStoreRepository resp = new StoreRepository();
        public Store currentStore { get; set; }
        public Account loginUser { get; set; }

        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            LoadStoreList(cboSort.Text);
            cboSort.SelectedIndex = 0;
        }

        public void LoadStoreList(string? sortType)
        {
            try
            {
                var storeList = resp.GetStores(sortType);
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
            if (e.RowIndex >= 0)
            {
                int storeId = int.Parse(dgvStore.Rows[e.RowIndex].Cells["StoreId"].Value.ToString());
                f.currentStore = resp.GetStoreById(storeId);
                f.loginUser = loginUser;
                f.Show();
            }
        }

        private void cboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStoreList(cboSort.Text);
        }
    }
}
