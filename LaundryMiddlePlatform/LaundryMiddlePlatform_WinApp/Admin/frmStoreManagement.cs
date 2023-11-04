using BusinessObjects.Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LaundryMiddlePlatform_WinApp
{
    public partial class frmStoreManagement : Form
    {
        IStoreRepository resp = new StoreRepository();
        IAccountRepository account = new AccountRepository();


        bool AddOrUpdate = false;
        private Store storeInfo { get; set; }
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
                AddOrUpdate = true;
                EnableText(true);
                ClearData();
                ClearText();

                LoadManagerList();
                btnCreate.Text = "Cancel";
                btnCreate.Enabled = true;
                btnSave.Enabled = true;
                btnDelete.Enabled = false;
                cboIsAvailable.SelectedIndex = 0;
            }
            else
            {
                DialogResult d;
                d = MessageBox.Show(AddOrUpdate ? "Do you want to cancel store account?" : "Do you want to cancel update account?", "Storemanagement",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (d == DialogResult.OK)
                {
                    btnCreate.Text = "Create";
                    btnCreate.Enabled = false;
                    LoadStoreList();
                    EnableText(false);
                }
            }

        }
        public void LoadStoreList()
        {
            try
            {
                var storeList = resp.GetStores(null);
                BindingSource source = new BindingSource();

                var storeView = storeList.Select(p => new
                {
                    p.StoreId,
                    p.Name,
                    p.Address,
                    p.PhoneNumber,
                    Manager = p.Management.FullName,
                    p.IsAvailable,
                    p.Status,
                });
                source.DataSource = storeView;
                ClearData();
                ClearText();

                txtAddress.DataBindings.Add("Text", source, "Address");
                cbxManagement.DataBindings.Add("Text", source, "Manager");
                txtName.DataBindings.Add("Text", source, "Name");
                txtPhoneNumber.DataBindings.Add("Text", source, "PhoneNumber");
                txtStatus.DataBindings.Add("Text", source, "Status");
                txtStoreID.DataBindings.Add("Text", source, "StoreId");
                //txtIsAvaiable.DataBindings.Add("Text", source, "IsAvailable");
                cboIsAvailable.DataBindings.Add("Text", source, "IsAvailable");

                dgvStore.DataSource = null;
                dgvStore.DataSource = source;
                EnableText(false);

                btnSave.Enabled = false;
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load Store List");
            }
        }
        private void LoadManagerList()
        {
            // Lấy danh sách các quản lý từ nguồn dữ liệu
            var managerList = account.GetAccountWithoutInfo();
            List<string> managerName = new List<string>();
            foreach (var item in managerList)
            {
                managerName.Add(item.FullName);
            }
            // Xóa các mục có sẵn trong comboBox
            cbxManagement.Items.Clear();

            // Thêm các quản lý vào comboBox
            foreach (var manager in managerName)
            {
                cbxManagement.Items.Add(manager);
            }
        }

        public void ClearText()
        {
            txtAddress.Text = "";
            cbxManagement.Text = "";
            txtName.Text = "";
            txtPhoneNumber.Text = "";
            txtStatus.Text = "";
            txtStoreID.Text = "";
        }
        public void ClearData()
        {
            txtAddress.DataBindings.Clear();
            cbxManagement.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtPhoneNumber.DataBindings.Clear();
            txtStatus.DataBindings.Clear();
            txtStoreID.DataBindings.Clear();
            cboIsAvailable.DataBindings.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var store = new Store
                {
                    Name = txtName.Text,
                    Address = txtAddress.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    ManagementId = account.GetAccountByName(cbxManagement.Text),
                    IsAvailable = bool.Parse(cboIsAvailable.Text),
                    Status = true,
                };
                if (AddOrUpdate == true)
                {
                    bool addStatus = resp.SaveStore(store);
                    if (addStatus)
                    {
                        MessageBox.Show($"Create store successfully", "Storemanagement",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    store.StoreId = storeInfo.StoreId;
                    bool updateStore = resp.UpdateStore(store);
                    if (updateStore)
                    {
                        MessageBox.Show($"Update store successfully.", "Storemanagement",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                ClearData();
                btnDelete.Enabled = true;
                btnCreate.Text = "Create";
                LoadStoreList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Store Management",
              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EnableText(bool status)
        {
            txtAddress.ReadOnly = !status;
            cbxManagement.Enabled = status;
            txtName.ReadOnly = !status;
            txtPhoneNumber.ReadOnly = !status;
            cboIsAvailable.Enabled = status;
            txtStatus.Text = "True";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStore.SelectedRows.Count > 0)
            {
                int location = dgvStore.CurrentCell.RowIndex;
                int storeId = int.Parse(dgvStore.Rows[location].Cells["StoreId"].Value.ToString());
                storeInfo = resp.GetStoreById(storeId);
                DialogResult d;
                d = MessageBox.Show("Are you sure delete this store?", "Storemanagement",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (d == DialogResult.OK)
                {
                    bool delStatus = resp.DeleteStore(storeInfo);
                    if (delStatus)
                    {
                        MessageBox.Show($"Delete store successfully.", "management",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    LoadStoreList();
                }
            }
        }

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    if (txtAddress.Text == "" || txtName.Text == "" || txtPhoneNumber.Text == "" || txtStatus.Text == "" || txtStatus.Text == "" || txtIsAvaiable.Text == "")
        //    {
        //        MessageBox.Show("All fields are required!", "frmStoreManagement", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    }
        //    else
        //    {
        //        var s = new Store
        //        {
        //            StoreId = int.Parse((string)txtStoreID.Text),
        //            Name = txtName.Text,
        //            Address = txtAddress.Text,
        //            IsAvailable = bool.Parse(txtIsAvaiable.Text),
        //            ManagementId = int.Parse(txtManagement.Text),
        //            PhoneNumber = txtPhoneNumber.Text,
        //            Status = bool.Parse((string)txtStatus.Text),
        //        };
        //        resp.UpdateStore(s);
        //        LoadStoreList();


        //    }
        //}

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvStore_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStore.SelectedRows.Count > 0)
            {
                int location = dgvStore.CurrentCell.RowIndex;
                int storeId = int.Parse(dgvStore.Rows[location].Cells["storeId"].Value.ToString());
                storeInfo = resp.GetStoreById(storeId);
                ClearData();
                EnableText(true);

                btnSave.Enabled = true;
                btnCreate.Text = "Cancel";
                btnDelete.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();


    }
}

