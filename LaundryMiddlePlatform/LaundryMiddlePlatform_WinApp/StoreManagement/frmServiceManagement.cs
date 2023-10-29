using BusinessObjects.Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryMiddlePlatform_WinApp.StoreManagement
{
    public partial class frmServiceManagement : Form
    {
        public Account managerAccount { get; set; }
        public Store currentStore { get; set; }

        IServiceRepository _repo = new ServiceRepository();

        public frmServiceManagement()
        {
            InitializeComponent();
        }

        private void ServiceManagement_Load(object sender, EventArgs e)
        {
            lblStoreName.Text = currentStore.Name;
            lblManager.Text = managerAccount.Email;
            LoadServiceData();
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

            txtServiceName.DataBindings.Clear();
            txtDescription.DataBindings.Clear();

            txtServiceName.DataBindings.Add("Text", source, "ServiceName");
            txtDescription.DataBindings.Add("Text", source, "Description");

            dgvServices.DataSource = null;
            dgvServices.DataSource = source;
        }

        private void dgvServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvServices.SelectedRows.Count > 0)
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
            }
        }
    }
}
