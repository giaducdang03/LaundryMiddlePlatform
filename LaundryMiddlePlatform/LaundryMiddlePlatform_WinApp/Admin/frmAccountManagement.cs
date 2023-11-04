using BusinessObjects.Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryMiddlePlatform_WinApp.Admin
{
    public partial class frmAccountManagement : Form
    {
        IAccountRepository _repo = new AccountRepository();

        public Account loginAccount { get; set; }

        bool AddOrUpdate = false;

        private Account accountInfo { get; set; }
        public frmAccountManagement()
        {
            InitializeComponent();
        }

        private void frmAccountManagement_Load(object sender, EventArgs e)
        {
            lblDate.Text = $"Date:\t {DateTime.Now}";
            lblAccount.Text = $"Admin:\t {loginAccount.Email}";
            LoadListAccount(txtSearchBox.Text, cboFilterRole.Text, cboSort.Text);
            cboFilterRole.SelectedIndex = 0;
            cboSort.SelectedIndex = 0;
        }

        private void LoadListAccount(string? txtSearch, string? role, string? sortType)
        {
            try
            {
                var accountList = _repo.GetAllAccount(txtSearch, role, sortType);
                BindingSource source = new BindingSource();

                var accountView = accountList.Select(p => new
                {
                    p.AccountId,
                    p.FullName,
                    p.DateOfBirth,
                    p.Email,
                    p.PhoneNumber,
                    p.Address,
                    p.Role
                });

                source.DataSource = accountView;

                ClearData();

                txtEmail.DataBindings.Add("Text", source, "Email");
                txtFullName.DataBindings.Add("Text", source, "FullName");
                dtpBirthDate.DataBindings.Add("Text", source, "DateOfBirth");
                txtPhone.DataBindings.Add("Text", source, "PhoneNumber");
                txtAddress.DataBindings.Add("Text", source, "Address");
                cboRole.DataBindings.Add("Text", source, "Role");

                dgvAccounts.DataSource = null;
                dgvAccounts.DataSource = source;

                EnableText(false);

                //btn control
                btnSave.Enabled = false;
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Account Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadListAccount(txtSearchBox.Text, cboFilterRole.Text, cboSort.Text);
        }

        private void cboFilterRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListAccount(txtSearchBox.Text, cboFilterRole.Text, cboSort.Text);
        }

        private void cboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListAccount(txtSearchBox.Text, cboFilterRole.Text, cboSort.Text);
        }

        // tools
        private void ClearData()
        {
            txtEmail.DataBindings.Clear();
            txtFullName.DataBindings.Clear();
            dtpBirthDate.DataBindings.Clear();
            txtPhone.DataBindings.Clear();
            txtAddress.DataBindings.Clear();
            cboRole.DataBindings.Clear();
        }

        private void ClearText()
        {
            txtEmail.Text = string.Empty;
            txtFullName.Text = string.Empty;
            dtpBirthDate.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAddress.Text = string.Empty;
            cboRole.SelectedIndex = 0;
        }

        private void EnableText(bool status)
        {
            txtEmail.ReadOnly = !status;
            txtFullName.ReadOnly = !status;
            dtpBirthDate.Enabled = status;
            txtPhone.ReadOnly = !status;
            txtAddress.ReadOnly = !status;
            cboRole.Enabled = status;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                AddOrUpdate = true;
                EnableText(true);
                ClearData();
                ClearText();

                //btn control
                btnAdd.Text = "Cancel";
                btnSave.Enabled = true;
                btnDelete.Enabled = false;
            }
            else
            {
                DialogResult d;
                d = MessageBox.Show(AddOrUpdate ? "Do you want to cancel add account?" : "Do you want to cancel update account?", "Account management",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (d == DialogResult.OK)
                {
                    btnAdd.Text = "Add";
                    ClearText();
                    LoadListAccount(txtSearchBox.Text, cboFilterRole.Text, cboSort.Text);
                    EnableText(false);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var account = new Account
                {
                    Email = txtEmail.Text,
                    Password = "1",
                    FullName = txtFullName.Text,
                    Address = txtAddress.Text,
                    DateOfBirth = DateTime.Parse(dtpBirthDate.Value.ToString()),
                    PhoneNumber = txtPhone.Text,
                    Role = cboRole.Text,
                    Status = true
                };
                if (AddOrUpdate == true)
                {
                    bool addStatus = _repo.SaveAccount(account);
                    if (addStatus)
                    {
                        MessageBox.Show($"Create account {account.Email} successfully.", "Account management",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    account.AccountId = accountInfo.AccountId;
                    account.Password = accountInfo.Password;
                    bool updateStatus = _repo.UpdateAccount(account);
                    if (updateStatus)
                    {
                        MessageBox.Show($"Update account {account.Email} successfully.", "Account management",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                btnDelete.Enabled = true;
                btnAdd.Text = "Add";
                LoadListAccount(txtSearchBox.Text, cboFilterRole.Text, cboSort.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Account Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAccounts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count > 0)
            {
                int location = dgvAccounts.CurrentCell.RowIndex;
                int accountId = int.Parse(dgvAccounts.Rows[location].Cells["AccountId"].Value.ToString());
                accountInfo = _repo.GetAccountById(accountId);
                ClearData();
                EnableText(true);
                txtEmail.ReadOnly = true;

                // btn control
                btnSave.Enabled = true;
                btnAdd.Text = "Cancel";
                btnDelete.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAccounts.SelectedRows.Count > 0)
                {
                    int location = dgvAccounts.CurrentCell.RowIndex;
                    int accountId = int.Parse(dgvAccounts.Rows[location].Cells["AccountId"].Value.ToString());
                    accountInfo = _repo.GetAccountById(accountId);
                    if (accountInfo.AccountId == loginAccount.AccountId)
                    {
                        throw new Exception($"Account {accountInfo.Email} is already login. Can not delete!");
                    }
                    DialogResult d;
                    d = MessageBox.Show("Are you sure delete this account?", "Account management",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);
                    if (d == DialogResult.OK)
                    {
                        bool delStatus = _repo.DeleteAccount(accountInfo);
                        if (delStatus)
                        {
                            MessageBox.Show($"Delete account {accountInfo.Email} successfully.", "Account management",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        LoadListAccount(txtSearchBox.Text, cboFilterRole.Text, cboSort.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Account Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResetPw_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count > 0)
            {
                int location = dgvAccounts.CurrentCell.RowIndex;
                int accountId = int.Parse(dgvAccounts.Rows[location].Cells["AccountId"].Value.ToString());
                accountInfo = _repo.GetAccountById(accountId);
                DialogResult d;
                d = MessageBox.Show("Are you sure reset password this account? (Default password is 1)", "Account management",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (d == DialogResult.OK)
                {
                    bool delStatus = _repo.ResetPassword(accountInfo);
                    if (delStatus)
                    {
                        MessageBox.Show($"Reset password account {accountInfo.Email} successfully.", "Account management",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    LoadListAccount(txtSearchBox.Text, cboFilterRole.Text, cboSort.Text);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();


    }
}
