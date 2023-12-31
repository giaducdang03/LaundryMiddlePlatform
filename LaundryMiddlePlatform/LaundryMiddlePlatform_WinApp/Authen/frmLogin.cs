using BusinessObjects.Models;
using LaundryMiddlePlatform_WinApp.Authen;
using LaundryMiddlePlatform_WinApp.Staff;
using LaundryMiddlePlatform_WinApp.StoreManagement;
using Repositories;

namespace LaundryMiddlePlatform_WinApp
{
    public partial class frmLogin : Form
    {
        IAccountRepository _repo = new AccountRepository();
        IStoreRepository _storeRepo = new StoreRepository();
        public static int AccountID { get; private set; }
        public static Account loginUser { get; private set; } = null!;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    throw new Exception("Email and password are required");
                }
                loginUser = _repo.CheckLogin(txtEmail.Text, txtPassword.Text);
                if (loginUser != null)
                {
                    if (loginUser.Role == "Admin")
                    {
                        frmLaundryManagement f = new frmLaundryManagement();
                        f.loginAccount = loginUser;
                        f.Show();
                        this.Hide();
                    }
                    else if (loginUser.Role == "Store")
                    {
                        AccountID = _repo.GetAccountIdByEmail(txtEmail.Text);
                        frmStoreManager f = new frmStoreManager();
                        f.currentStore = _storeRepo.GetStoreByManagerId(loginUser.AccountId);
                        f.managerAccount = loginUser;
                        f.Show();
                        this.Hide();

                    }
                    else if (loginUser.Role == "User")
                    {
                        frmCustomer f = new frmCustomer();
                        f.loginUser = loginUser;
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        frmStaff f = new frmStaff();
                        f.loginAccount = loginUser;
                        f.Show();
                        this.Hide();
                    }
                }
                else
                {
                    throw new Exception("Incorrect email or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Laundry Middle Platform",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnLogin_Click(sender, e);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister register = new frmRegister();
            register.ShowDialog();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}