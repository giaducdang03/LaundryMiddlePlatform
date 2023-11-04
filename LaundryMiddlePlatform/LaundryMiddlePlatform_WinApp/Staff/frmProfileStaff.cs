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
    public partial class frmProfileStaff : Form
    {
        IAccountRepository repo = new AccountRepository();
        bool AddOrUpdate = false;

        public frmProfileStaff()
        {
            InitializeComponent();
        }
        IAccountRepository _repo = new AccountRepository();


        private void ClearData()
        {
         
            txtFullname.DataBindings.Clear();
            dtpBirthDate.DataBindings.Clear();
            txtPhone.DataBindings.Clear();
            txtAddress.DataBindings.Clear();
         
        }
        private void ClearText()
        {
        
            txtFullname.Text = string.Empty;
            dtpBirthDate.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAddress.Text = string.Empty;
        
        }

        private void EnableText(bool status)
        {
            txtEmail.ReadOnly = !status;
            txtFullname.ReadOnly = !status;
            dtpBirthDate.Enabled = status;
            txtPhone.ReadOnly = !status;
            txtAddress.ReadOnly = !status;
        }

        private void frmProfileStaff_Load_1(object sender, EventArgs e)
        {
            LoadProFile();

        }
        private void LoadProFile()
        {
            try
            {
                var account = repo.GetAccountById(frmLogin.AccountID);
                BindingSource source = new BindingSource();


                source.DataSource = account;
                ClearData();
                txtEmail.DataBindings.Clear();
                txtRole.DataBindings.Clear();

                txtEmail.DataBindings.Add("Text", source, "Email");
                txtFullname.DataBindings.Add("Text", source, "FullName");
                dtpBirthDate.DataBindings.Add("Text", source, "DateOfBirth");
                txtPhone.DataBindings.Add("Text", source, "PhoneNumber");
                txtAddress.DataBindings.Add("Text", source, "Address");
                txtRole.DataBindings.Add("Text", source, "Role");

                dgvProfileStaff.DataSource = null;
                dgvProfileStaff.DataSource = source;
                EnableText(false);



                //btn control
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Profile Staff",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Update")
            {
                AddOrUpdate = true;
                EnableText(true);
                ClearData();
               

                //btn control
                btnUpdate.Text = "Cancel";
                btnSave.Enabled = true;
            }
            else
            {
                DialogResult d;
                d = MessageBox.Show(AddOrUpdate ? "Do you want to cancel update account?" : "Do you want to cancel update account?", "Profile Staff",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (d == DialogResult.OK)
                {
                    btnUpdate.Text = "Update";
                    ClearText();
                    LoadProFile();
                    EnableText(false);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var account = _repo.GetAccountById(frmLogin.AccountID);
                if (account != null)
                {
                    account.FullName = txtFullname.Text;
                    account.DateOfBirth = dtpBirthDate.Value;
                    account.PhoneNumber = txtPhone.Text;
                    account.Address = txtAddress.Text;
                    _repo.UpdateAccount(account);
                    btnUpdate.Text = "Update";
                    LoadProFile();
                }
                else
                {
                    MessageBox.Show("Can't find this Staff", "Profile Staff");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Profile Staff",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
