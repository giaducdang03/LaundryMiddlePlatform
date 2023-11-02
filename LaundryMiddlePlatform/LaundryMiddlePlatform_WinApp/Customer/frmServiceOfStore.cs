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
        IServiceRepository _repo = new ServiceRepository();
        public frmServiceOfStore()
        {
            InitializeComponent();

        }
        private void LoadServiceData()
        {
            var services = _repo.GetSerivcesByStoreId(currentStore.StoreId);
            var serviceView = services.Select(p => new
            {
                p.ServiceId,
                StoreName = p.Store.Name,
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
            dgvServiceDetails.Visible = false;
            LoadServiceData();
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
                dgvServiceDetails.Visible = true;
                dgvServiceDetails.DataSource = serviceDetail;
            }
        }
    }
}
