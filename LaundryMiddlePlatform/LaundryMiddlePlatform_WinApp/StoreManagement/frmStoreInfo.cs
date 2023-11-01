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

namespace LaundryMiddlePlatform_WinApp.StoreManagement
{
    public partial class frmStoreInfo : Form
    {
        IStoreRepository _repo = new StoreRepository();
        public Account managerAccount { get; set; }
        public Store currentStore { get; set; }
        public frmStoreInfo()
        {
            InitializeComponent();
        }

        private void frmStoreInfo_Load(object sender, EventArgs e)
        {
            LoadData();
            EnableText(false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Update")
            {
                btnUpdate.Text = "Cancel";
                btnSave.Enabled = true;
                EnableText(true);
            }
            else
            {
                DialogResult d;
                d = MessageBox.Show("Do you want to cancel update store?", "Store Management",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (d == DialogResult.OK)
                {
                    EnableText(false);
                    LoadData();
                    btnUpdate.Text = "Update";
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtStoreName.Text.Trim()) || string.IsNullOrEmpty(txtAddress.Text.Trim())
                    || string.IsNullOrEmpty(txtPhone.Text.Trim()))
                {
                    throw new Exception("All feild are require.");
                }
                var updateStore = currentStore;
                updateStore.Name = txtStoreName.Text;
                updateStore.Address = txtAddress.Text;
                updateStore.PhoneNumber = txtPhone.Text;
                _repo.UpdateStore(updateStore);
                currentStore = updateStore;
                MessageBox.Show($"Update store info successfully.", "Service management",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Store Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnableText(bool status)
        {
            txtStoreName.ReadOnly = !status;
            txtAddress.ReadOnly = !status;
            txtPhone.ReadOnly = !status;
        }

        private void LoadData()
        {
            lblStoreName.Text = currentStore.Name;
            lblManager.Text = managerAccount.Email;
            txtStoreName.Text = currentStore.Name;
            txtAddress.Text = currentStore.Address;
            txtPhone.Text = currentStore.PhoneNumber;
            lblStatus.Text = currentStore.IsAvailable.ToString();
            btnSave.Enabled = false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                currentStore.IsAvailable = !currentStore.IsAvailable;
                _repo.UpdateStore(currentStore);
                MessageBox.Show($"Change status successfully.", "Service management",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Store Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
