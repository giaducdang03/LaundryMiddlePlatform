using BusinessObjects.Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryMiddlePlatform_WinApp.StoreManagement
{
    public partial class frmServiceManagement : Form
    {
        public Account managerAccount { get; set; }
        public Store currentStore { get; set; }

        bool AddOrUpdate = false;
        bool AddOrUpdateDetail = false;

        private Service newService = null;
        public List<ServiceDetail> serviceDetails = new List<ServiceDetail>();

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

        // for service
        private void LoadServiceData()
        {
            try
            {
                var services = _repo.GetSerivcesByStoreId(currentStore.StoreId, txtSearch.Text);
                var serviceView = services.Select(p => new
                {
                    p.ServiceId,
                    StoreName = p.Store.Name,
                    ServiceName = p.Name,
                    p.Description
                });

                BindingSource source = new BindingSource();
                source.DataSource = serviceView;

                ClearData();

                txtServiceName.DataBindings.Add("Text", source, "ServiceName");
                txtDescription.DataBindings.Add("Text", source, "Description");

                dgvServices.DataSource = null;
                dgvServices.DataSource = source;

                EnableText(false);

                btnSave.Enabled = false;
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;

                dgvServiceDetails.Visible = false;
                btnAddDetail.Visible = false;
                btnCloseDetail.Visible = false;
                btnUpdateDetail.Visible = false;
                btnRemove.Visible = false;
                lblDetail.Visible = false;

                serviceDetails.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Service Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                AddOrUpdateDetail = true;
                btnAdd.Text = "Cancel";
                btnUpdate.Enabled = false;
                btnSave.Enabled = true;
                AddOrUpdate = true;
                ClearData();
                ClearText();
                EnableText(true);

                dgvServiceDetails.DataSource = null;

                dgvServiceDetails.Visible = true;
                btnAddDetail.Visible = true;
                btnCloseDetail.Visible = true;
                btnUpdateDetail.Visible = true;
                lblDetail.Visible = true;

            }
            else
            {
                DialogResult d;
                d = MessageBox.Show("Do you want to cancel add service?", "Service management",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (d == DialogResult.OK)
                {
                    btnAdd.Text = "Add";
                    ClearText();
                    LoadServiceData();
                    EnableText(false);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (AddOrUpdate == true)
                {
                    if (txtServiceName.Text.Trim() == string.Empty || txtDescription.Text.Trim() == string.Empty)
                    {
                        throw new Exception("Service name and description are require.");
                    }
                    newService = new Service
                    {
                        Name = txtServiceName.Text,
                        Description = txtDescription.Text,
                        StoreId = currentStore.StoreId,
                        Status = true
                    };
                    if (!serviceDetails.Any())
                    {
                        throw new Exception("Plaese add at least 1 Service detail.");
                    }
                    else
                    {
                        foreach (var item in serviceDetails)
                        {
                            item.Id = 0;
                        }
                        newService.ServiceDetails = serviceDetails;
                        bool addStatus = _repo.AddService(newService);
                        if (addStatus)
                        {
                            MessageBox.Show($"Add service {newService.Name} successfully.", "Service management",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadServiceData();
                        }
                        btnAdd.Text = "Add";
                    }
                }
                else
                {
                    if (dgvServices.SelectedRows.Count > 0)
                    {
                        int location = dgvServices.CurrentCell.RowIndex;
                        int serviceId = int.Parse(dgvServices.Rows[location].Cells["ServiceId"].Value.ToString());
                        var updateService = _repo.GetServiceById(serviceId);
                        updateService.Name = txtServiceName.Text;
                        updateService.Description = txtDescription.Text;
                        bool updateStatus = _repo.UpdateService(updateService);
                        if (updateStatus)
                        {
                            MessageBox.Show($"Update service successfully.", "Service management",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadServiceData();
                        }
                        btnUpdate.Text = "Update";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Service Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Update")
            {
                AddOrUpdate = false;
                btnUpdate.Text = "Cancel";
                btnAdd.Enabled = false;
                btnSave.Enabled = true;
                EnableText(true);
            }
            else
            {
                DialogResult d;
                d = MessageBox.Show("Do you want to cancel update service?", "Service management",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (d == DialogResult.OK)
                {
                    btnUpdate.Text = "Update";
                    ClearText();
                    LoadServiceData();
                    EnableText(false);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count > 0)
            {
                int location = dgvServices.CurrentCell.RowIndex;
                int serviceId = int.Parse(dgvServices.Rows[location].Cells["ServiceId"].Value.ToString());
                var currentService = _repo.GetServiceById(serviceId);
                DialogResult d;
                d = MessageBox.Show($"Do you want delete {currentService.Name}?", "Service management",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (d == DialogResult.OK)
                {
                    bool delService = _repo.DeleteService(currentService);
                    if (delService)
                    {
                        MessageBox.Show($"Delete {currentService.Name} successfully.", "Service Management",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    LoadServiceData();
                }
            }
        }

        private void dgvServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvServices.SelectedRows.Count > 0)
            {
                int location = dgvServices.CurrentCell.RowIndex;
                int serviceId = int.Parse(dgvServices.Rows[location].Cells["ServiceId"].Value.ToString());

                LoadServiceDetail(serviceId);

                dgvServiceDetails.Visible = true;
                btnAddDetail.Visible = true;
                btnCloseDetail.Visible = true;
                btnUpdateDetail.Visible = true;
                btnRemove.Visible = true;
                lblDetail.Visible = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadServiceData();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnSearch_Click(sender, e);
        }

        // for service detail

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtServiceName.Text.Trim() == string.Empty || txtDescription.Text.Trim() == string.Empty)
                {
                    throw new Exception("Service name and description are require.");
                }
                if (AddOrUpdateDetail == true)
                {
                    frmServiceDetail f = new frmServiceDetail();
                    f.addId = serviceDetails.Any() ? serviceDetails.Max(s => s.Id) : 0;
                    f.AddOrUpdate = true;
                    f.serviceName = txtServiceName.Text;
                    f.ShowDialog();
                    if (f.ServiceDetailInfo != null)
                    {
                        serviceDetails.Add(f.ServiceDetailInfo);
                        LoadAddServiceDetail();
                    }
                }
                else
                {
                    if (dgvServices.SelectedRows.Count > 0)
                    {
                        int location = dgvServices.CurrentCell.RowIndex;
                        int serviceId = int.Parse(dgvServices.Rows[location].Cells["ServiceId"].Value.ToString());
                        frmServiceDetail f = new frmServiceDetail();
                        f.AddOrUpdate = true;
                        f.serviceName = txtServiceName.Text;
                        f.serviceId = serviceId;
                        f.ShowDialog();
                        LoadServiceDetail(serviceId);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Service Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAddServiceDetail()
        {
            var viewDetails = serviceDetails.Select(p => new
            {
                ServiceName = txtServiceName.Text,
                p.Id,
                p.Type,
                p.WashOption,
                p.Duration,
                p.PricePerUnit
            });
            BindingSource source = new BindingSource();
            source.DataSource = viewDetails;

            dgvServiceDetails.DataSource = null;
            dgvServiceDetails.DataSource = source;
        }

        private void btnCloseDetail_Click(object sender, EventArgs e)
        {
            dgvServiceDetails.Visible = false;
            btnAddDetail.Visible = false;
            btnCloseDetail.Visible = false;
            btnUpdateDetail.Visible = false;
            btnRemove.Visible = false;
            lblDetail.Visible = false;
        }

        private void dgvServiceDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvServiceDetails.SelectedRows.Count > 0)
            {
                int location = dgvServiceDetails.CurrentCell.RowIndex;
                int serviceDetailId = int.Parse(dgvServiceDetails.Rows[location].Cells["ServiceDetailId"].Value.ToString());
                var serviceDetail = _repo.GetServiceDetailById(serviceDetailId);
                frmServiceDetail f = new frmServiceDetail();
                f.AddOrUpdate = false;
                f.serviceName = txtServiceName.Text;
                f.ServiceDetailInfo = serviceDetail;
                f.ShowDialog();
                if (dgvServices.SelectedRows.Count > 0)
                {
                    int location2 = dgvServices.CurrentCell.RowIndex;
                    int serviceId = int.Parse(dgvServices.Rows[location2].Cells["ServiceId"].Value.ToString());
                    LoadServiceDetail(serviceId);
                }
            }
        }

        private void LoadServiceDetail(int serviceId)
        {
            var serviceDetail = _repo.GetServiceDetailsByServiceId(serviceId).Select(p => new
            {
                ServiceName = p.Service.Name,
                ServiceDetailId = p.Id,
                p.Type,
                p.WashOption,
                p.Duration,
                p.PricePerUnit
            }).ToList();

            BindingSource source = new BindingSource();
            source.DataSource = serviceDetail;

            dgvServiceDetails.DataSource = null;
            dgvServiceDetails.DataSource = serviceDetail;
        }

        private void btnUpdateDetail_Click(object sender, EventArgs e)
        {
            if (dgvServiceDetails.SelectedRows.Count > 0)
            {
                int location = dgvServiceDetails.CurrentCell.RowIndex;
                int serviceDetailId = int.Parse(dgvServiceDetails.Rows[location].Cells["ServiceDetailId"].Value.ToString());
                var serviceDetail = _repo.GetServiceDetailById(serviceDetailId);
                frmServiceDetail f = new frmServiceDetail();
                f.AddOrUpdate = false;
                f.serviceName = txtServiceName.Text;
                f.ServiceDetailInfo = serviceDetail;
                f.ShowDialog();
                //serviceDetails.Add(f.ServiceDetailInfo);
                if (dgvServices.SelectedRows.Count > 0)
                {
                    int location2 = dgvServices.CurrentCell.RowIndex;
                    int serviceId = int.Parse(dgvServices.Rows[location2].Cells["ServiceId"].Value.ToString());

                    LoadServiceDetail(serviceId);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (serviceDetails.Any())
            {
                if (dgvServiceDetails.SelectedRows.Count > 0)
                {
                    int location = dgvServiceDetails.CurrentCell.RowIndex;
                    int serviceDetailId = int.Parse(dgvServiceDetails.Rows[location].Cells["Id"].Value.ToString());
                    serviceDetails.Remove(serviceDetails.SingleOrDefault(s => s.Id == serviceDetailId));
                    MessageBox.Show($"Remove service detail successfully.", "Service Management",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAddServiceDetail();
                }
            }
            else
            {
                try
                {
                    if (dgvServiceDetails.SelectedRows.Count > 0)
                    {
                        int location = dgvServiceDetails.CurrentCell.RowIndex;
                        int serviceDetailId = int.Parse(dgvServiceDetails.Rows[location].Cells["ServiceDetailId"].Value.ToString());
                        DialogResult d;
                        d = MessageBox.Show("Are you sure remove this service detail?", "Service Management",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button1);
                        if (d == DialogResult.OK)
                        {
                            var serviceDetail = _repo.GetServiceDetailById(serviceDetailId);
                            int serviceId = serviceDetail.Service.ServiceId;
                            var currentService = _repo.GetServiceById(serviceId);
                            if (currentService.ServiceDetails.Count() <= 1)
                            {
                                DialogResult d1;
                                d1 = MessageBox.Show($"Do you want delete {currentService.Name}?", "Service management",
                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                                    MessageBoxDefaultButton.Button1);
                                if (d1 == DialogResult.OK)
                                {
                                    bool delService = _repo.DeleteService(currentService);
                                    if (delService)
                                    {
                                        MessageBox.Show($"Delete {currentService.Name} successfully.", "Service Management",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    LoadServiceData();
                                }
                            }
                            else
                            {
                                bool delStatus = _repo.DeleteServiceDetail(serviceDetail);
                                if (delStatus)
                                {
                                    MessageBox.Show($"Remove successfully.", "Service Management",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                LoadServiceDetail(serviceId);
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Service Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // tools
        private void ClearData()
        {
            txtServiceName.DataBindings.Clear();
            txtDescription.DataBindings.Clear();
        }

        private void ClearText()
        {
            txtServiceName.Text = string.Empty;
            txtDescription.Text = string.Empty;
        }

        private void EnableText(bool status)
        {
            txtServiceName.ReadOnly = !status;
            txtDescription.ReadOnly = !status;
        }

        
    }
}
