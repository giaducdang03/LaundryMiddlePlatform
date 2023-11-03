using BusinessObjects.Models;
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

namespace LaundryMiddlePlatform_WinApp.Customer
{
    public partial class frmServiceOfStore : Form
    {
        public Store currentStore { get; set; }
        public Account loginUser { get; set; }
        IServiceRepository _repo = new ServiceRepository();
        public frmServiceOfStore()
        {
            InitializeComponent();

        }
        private void LoadServiceData()
        {
            // load info store
            lblStoreName.Text = currentStore.Name;
            lblStoreAddress.Text = currentStore.Address;
            lblStorePhone.Text = currentStore.PhoneNumber;

            // load service store
            var services = _repo.GetSerivcesByStoreId(currentStore.StoreId, txtSearch.Text);
            var serviceView = services.Select(p => new
            {
                p.ServiceId,
                ServiceName = p.Name,
                p.Description
            });

            BindingSource source = new BindingSource();
            source.DataSource = serviceView;

            dgvServices.DataSource = null;
            dgvServices.DataSource = source;
        }
        private void frmServiceOfStore_Load(object sender, EventArgs e)
        {
            LoadServiceData();
            dgvServiceDetails.Visible = false;
            btnClose.Visible = false;
        }

        private void dgvServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int location = dgvServices.CurrentCell.RowIndex;
                int serviceId = int.Parse(dgvServices.Rows[location].Cells["ServiceId"].Value.ToString());
                var serviceDetail = _repo.GetServiceDetailsByServiceId(serviceId).Select(p => new
                {
                    ServiceName = p.Service.Name,
                    p.Type,
                    p.WashOption,
                    p.Duration,
                    p.PricePerUnit
                }).ToList();

                //lbDetails.Text = $"Details of renting transaction: {rentingId}";

                BindingSource source = new BindingSource();
                source.DataSource = serviceDetail;

                dgvServiceDetails.DataSource = null;
                dgvServiceDetails.DataSource = serviceDetail;

                dgvServiceDetails.Visible = true;
                btnClose.Visible = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            dgvServiceDetails.Visible = false;
            btnClose.Visible = false;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            frmCustomerOrder f = new frmCustomerOrder();
            f.orderStore = currentStore;
            f.loginUser = loginUser;
            f.ShowDialog();
        }
    }
}
