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

namespace LaundryMiddlePlatform_WinApp.Authen
{
    public partial class frmRegister : Form
    {
        IAccountRepository _repo = new AccountRepository();
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtFullName.Text) ||
                string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtPhone.Text) ||
                string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConfirm.Text))
                {
                    MessageBox.Show("All field are require", "Laundry Middle Platform",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtPassword.Text != txtConfirm.Text)
                    {
                        MessageBox.Show("Password and confirm password is not match", "Laundry Middle Platform",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var newAccount = new Account
                        {
                            Email = txtEmail.Text,
                            Password = txtPassword.Text,
                            FullName = txtFullName.Text,
                            Address = txtAddress.Text,
                            PhoneNumber = txtPhone.Text,
                            DateOfBirth = DateTime.Parse(dtpBirthday.Value.Date.ToString()),
                            Role = "User",
                            Status = true
                        };
                        bool add = _repo.SaveAccount(newAccount);
                        if (add)
                        {
                            MessageBox.Show("Your account is ready. Login now", "Laundry Middle Platform",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Laundry Middle Platform",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Are you sure to cancel?", "Laundry Middle Platform",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                this.Close();
            }
        }


    }
}
