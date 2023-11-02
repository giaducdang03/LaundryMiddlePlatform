using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

namespace LaundryMiddlePlatform_WinApp.StoreManagement
{
    public partial class frmServiceDetail : Form
    {
        IServiceRepository _repo = new ServiceRepository();
        public bool AddOrUpdate { get; set; }
        public string serviceName { get; set; }
        public int serviceId { get; set; } = 0;
        public int addId { get; set; }
        public ServiceDetail ServiceDetailInfo { get; set; }
        public frmServiceDetail()
        {
            InitializeComponent();
        }

        private void frmServiceDetail_Load(object sender, EventArgs e)
        {
            cboWashOption.SelectedIndex = 0;
            cboWashType.SelectedIndex = 0;
            txtServiceName.Text = serviceName;
            txtServiceName.ReadOnly = true;
            if (AddOrUpdate == false)
            {
                cboWashOption.Text = ServiceDetailInfo.WashOption;
                cboWashType.Text = ServiceDetailInfo.Type;
                txtDuration.Text = ServiceDetailInfo.Duration.ToString();
                txtPrice.Text = ServiceDetailInfo.PricePerUnit.ToString();
                btnAdd.Text = "Update";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAdd.Text == "Add")
                {
                    if (txtDuration.Text.Trim() == string.Empty || txtPrice.Text.Trim() == string.Empty)
                    {
                        throw new Exception("All field are require.");
                    }
                    TimeSpan duration;
                    if (!TimeSpan.TryParse(txtDuration.Text, out duration) || txtDuration.Text == "00:00:00")
                    {
                        throw new Exception("Completion time is invalid.");
                    }
                    double price;
                    if (!double.TryParse(txtPrice.Text, out price) || price == 0)
                    {
                        throw new Exception("Price must be numeric and more than 0");
                    }
                    if (serviceId == 0)
                    {
                        ServiceDetailInfo = new ServiceDetail
                        {
                            Id = addId + 1,
                            TypeName = $"{cboWashType.Text} - {cboWashOption.Text}",
                            Type = cboWashType.Text,
                            WashOption = cboWashOption.Text,
                            Duration = duration,
                            PricePerUnit = price,
                            Status = true
                        };
                    }
                    else
                    {
                        ServiceDetailInfo = new ServiceDetail
                        {
                            ServiceId = serviceId,
                            TypeName = $"{cboWashType.Text} - {cboWashOption.Text}",
                            Type = cboWashType.Text,
                            WashOption = cboWashOption.Text,
                            Duration = duration,
                            PricePerUnit = price,
                            Status = true
                        };
                        bool addStatus = _repo.AddServiceDetail(ServiceDetailInfo);
                        if (addStatus)
                        {
                            MessageBox.Show($"Add service deltail successfully.", "Service management",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    if (txtDuration.Text.Trim() == string.Empty || txtPrice.Text.Trim() == string.Empty)
                    {
                        throw new Exception("All field are require.");
                    }
                    TimeSpan duration;
                    if (!TimeSpan.TryParse(txtDuration.Text, out duration) || txtDuration.Text == "00:00:00")
                    {
                        throw new Exception("Completion time is invalid.");
                    }
                    double price;
                    if (!double.TryParse(txtPrice.Text, out price) || price == 0)
                    {
                        throw new Exception("Price must be numeric and more than 0");
                    }

                    // update service detail
                    ServiceDetailInfo.TypeName = $"{cboWashType.Text} - {cboWashOption.Text}";
                    ServiceDetailInfo.Type = cboWashType.Text;
                    ServiceDetailInfo.WashOption = cboWashOption.Text;
                    ServiceDetailInfo.Duration = duration;
                    ServiceDetailInfo.PricePerUnit = price;

                    bool updateStatus = _repo.UpdateServiceDetail(ServiceDetailInfo);
                    if (updateStatus)
                    {
                        MessageBox.Show($"Update successfully.", "Service management",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Service Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you want cancel?", "Service Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                ServiceDetailInfo = null;
                this.Close();
            }
        }


        private void frmServiceDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you want cancel?", "Service Management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (d == DialogResult.Cancel)
            {
                e.Cancel = true;
                ServiceDetailInfo = null;
            }
        }
    }
}
