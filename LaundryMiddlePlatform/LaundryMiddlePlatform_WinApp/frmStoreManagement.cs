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

namespace LaundryMiddlePlatform_WinApp
{
    public partial class frmStoreManagement : Form
    {
        IStoreRepository resp = new StoreRepository();
        public frmStoreManagement()
        {
            InitializeComponent();
        }

        private void frmStoreManagement_Load(object sender, EventArgs e)
        {
            LoadStoreList();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (btnCreate.Text == "Create")
            {
                btnCreate.Text = "Cancel";
                btnCreate.Enabled = true;


                txtAddress.DataBindings.Clear();
                txtIsAvaiable.DataBindings.Clear();
                txtManagement.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtPhoneNumber.DataBindings.Clear();
                txtStatus.DataBindings.Clear();
                txtStoreID.DataBindings.Clear();
                ClearText();
            }
            else
            {
                btnCreate.Text = "Create";
                btnCreate.Enabled = false;
                LoadStoreList();
            }

        }
        public void LoadStoreList()
        {
            try
            {
                var storeList = resp.GetStores();
                BindingSource source = new BindingSource();
                source.DataSource = storeList;

                txtAddress.DataBindings.Clear();
                txtIsAvaiable.DataBindings.Clear();
                txtManagement.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtPhoneNumber.DataBindings.Clear();
                txtStatus.DataBindings.Clear();
                txtStoreID.DataBindings.Clear();
                ClearText();

                txtAddress.DataBindings.Add("Text", source, "Address");               
                txtManagement.DataBindings.Add("Text", source, "ManagementId");
                txtName.DataBindings.Add("Text", source, "Name");
                txtPhoneNumber.DataBindings.Add("Text", source, "PhoneNumber");
                txtStatus.DataBindings.Add("Text", source, "Status");
                txtStoreID.DataBindings.Add("Text", source, "StoreId");
                txtIsAvaiable.DataBindings.Add("Text", source, "IsAvailable");

                dgvStore.DataSource = null;
                dgvStore.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load Store List");
            }
        }
        public void ClearText()
        {
            txtAddress.Text = "";
            txtIsAvaiable.Text = "";
            txtManagement.Text = "";
            txtName.Text = "";
            txtPhoneNumber.Text = "";
            txtStatus.Text = "";
            txtStoreID.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" || txtName.Text == "" || txtPhoneNumber.Text == "" || txtStatus.Text == "" || txtStatus.Text == "" || txtIsAvaiable.Text == "")
            {
                MessageBox.Show("All fields are required!", "frmStoreManagement", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                var s = new Store
                {
                    Name = txtName.Text,
                    Address = txtAddress.Text,
                    IsAvailable = bool.Parse(txtIsAvaiable.Text),
                    ManagementId = int.Parse(txtManagement.Text),
                    PhoneNumber = txtPhoneNumber.Text,
                    Status = bool.Parse((string)txtStatus.Text),
                };
                resp.SaveStore(s);
                btnCreate.Text = "Create";
                btnSave.Enabled = false;
                LoadStoreList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this record?", "frmCustomerManagement",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                var s = new Store
                {
                    StoreId = int.Parse(txtStoreID.Text),
                };
                resp.DeleteStore(s);
                LoadStoreList();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" || txtName.Text == "" || txtPhoneNumber.Text == "" || txtStatus.Text == "" || txtStatus.Text == "" || txtIsAvaiable.Text == "")
            {
                MessageBox.Show("All fields are required!", "frmStoreManagement", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                var s = new Store
                {
                    StoreId = int.Parse((string)txtStoreID.Text),
                    Name = txtName.Text,
                    Address = txtAddress.Text,
                    IsAvailable = bool.Parse(txtIsAvaiable.Text),
                    ManagementId = int.Parse(txtManagement.Text),
                    PhoneNumber = txtPhoneNumber.Text,
                    Status = bool.Parse((string)txtStatus.Text),
                };
                resp.UpdateStore(s);
                LoadStoreList();


            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

