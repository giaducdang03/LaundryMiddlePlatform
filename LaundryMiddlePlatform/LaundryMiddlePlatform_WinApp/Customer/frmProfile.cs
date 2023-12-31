﻿using BusinessObjects.Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryMiddlePlatform_WinApp.Customer
{
    public partial class frmProfile : Form
    {
        public Account loginUser { get; set; }
        IAccountRepository _repo = new AccountRepository();
        public frmProfile()
        {
            InitializeComponent();
          
        }

        public frmProfile(Account user)
        {
            InitializeComponent();
            this.loginUser = user;
            _repo.GetAccountById(loginUser.AccountId);


        }
        private void EnableText(bool status)
        {
            txtFullName.Enabled = status;
            dtpBirthDate.Enabled = status;
            txtPhone.Enabled = status;
            txtAddress.Enabled = status;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblAccount_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text.Equals("Edit Profile"))
            {
                EnableText(true);
                // btn control
                btnSave.Enabled = true;


            }
        }

        public void loadProfile()
        {
            Account user = _repo.GetAccountById(loginUser.AccountId);
            if (user == null)
            {
                MessageBox.Show("User's profile is not found", "Laundry Middle Platform",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtAddress.Text = user.Address;
            txtFullName.Text = user.FullName;
            txtEmail.Text = user.Email;
            txtPhone.Text = user.PhoneNumber;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var account = new Account
            {
                Email = loginUser.Email,
                Password = loginUser.Password,
                FullName = txtFullName.Text,
                Address = txtAddress.Text,
                DateOfBirth = DateTime.Parse(dtpBirthDate.Value.ToString()),
                PhoneNumber = txtPhone.Text,
                Role = loginUser.Role,
                Status = true
            };
            account.AccountId = loginUser.AccountId;
            account.Password = loginUser.Password;
            bool updateStatus = _repo.UpdateAccount(account);
            if (updateStatus)
            {
                EnableText(false);
                MessageBox.Show($"Update account {account.Email} successfully.", "Account management",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadProfile();
            }
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
          loadProfile();
        }
    }
}
