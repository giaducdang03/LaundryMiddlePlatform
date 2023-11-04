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
    public partial class frmOrderDetail : Form
    {
        IOrderRepository orderRepo = new OrderRepository();
        IOrderDetailRepository orderDetailRepo = new OrderDetailRepository();

        bool AddOrUpdate = false;
        public Order currentOrder { get; set; }
        public frmOrderDetail()
        {
            InitializeComponent();
        }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            LoadOrderData();
        }

        public void LoadOrderData()
        {
            txtOrderId.Text = currentOrder.OrderId.ToString();
            txtCustomer.Text = currentOrder.Customer.FullName;
            txtCustomerPhone.Text = currentOrder.Customer.PhoneNumber;
            txtPrice.Text = string.Format("{0:C}", currentOrder.TotalPrice);
            txtOrderDate.Text = currentOrder.CreateDate.ToString();
            txtStaffName.Text = currentOrder.Staff.FullName;
            txtStaffPhone.Text = currentOrder.Staff.PhoneNumber;
            lblStatus.Text = currentOrder.Status;

            var viewDetail = currentOrder.OrderDetails.Select(p => new
            {
                p.Id,
                Type = p.ServiceDetail.TypeName,
                p.ServiceDetail.Duration,
                p.Weight,
                p.UnitPrice,
                p.Price
            });

            BindingSource source = new BindingSource();
            source.DataSource = viewDetail;

            dgvOrderDetail.DataSource = null;
            dgvOrderDetail.DataSource = source;

            DisableText();

            if (currentOrder.Status != OrderStatus.Working.ToString())
            {
                btnComplete.Enabled = false;
            }

            //change color status
            if (lblStatus.Text == OrderStatus.Pending.ToString())
            {
                lblStatus.ForeColor = Color.Red;
            }
            else if (lblStatus.Text == OrderStatus.Working.ToString())
            {
                lblStatus.ForeColor = Color.White;
                lblStatus.BackColor = Color.Brown;
            }
            else if (lblStatus.Text == OrderStatus.Completed.ToString())
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.BackColor = Color.Yellow;
            }
            else
            {
                lblStatus.ForeColor = Color.White;
                lblStatus.BackColor = Color.Green;
            }
        }

        public void DisableText()
        {
            txtOrderId.ReadOnly = true;
            txtCustomer.ReadOnly = true;
            txtCustomerPhone.ReadOnly = true;
            txtPrice.ReadOnly = true;
            txtOrderDate.ReadOnly = true;
            txtStaffName.ReadOnly = true;
            txtStaffPhone.ReadOnly = true;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d;
                d = MessageBox.Show("Do you want to mark this order as 'Complete'?", "Order management",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (d == DialogResult.OK)
                {
                    currentOrder.Status = OrderStatus.Completed.ToString();
                    orderRepo.UpdateOrder(currentOrder);
                    LoadOrderData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Management",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
