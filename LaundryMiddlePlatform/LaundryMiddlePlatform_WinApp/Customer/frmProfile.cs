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

namespace LaundryMiddlePlatform_WinApp.Customer
{
    public partial class frmProfile : Form
    {
        public Account loginUser {  get; set; } 
        IAccountRepository _repo = new AccountRepository();
        public frmProfile()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblAccount_Click(object sender, EventArgs e)
        {

        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            if (frmHome..SelectedRows.Count > 0)
            {
                int location = dgvAccounts.CurrentCell.RowIndex;
                int accountId = int.Parse(dgvAccounts.Rows[location].Cells["AccountId"].Value.ToString());
                accountInfo = _repo.GetAccountById(accountId);
                ClearData();
                EnableText(true);
                txtEmail.ReadOnly = true;

              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
