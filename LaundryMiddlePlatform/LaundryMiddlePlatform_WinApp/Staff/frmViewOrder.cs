using BusinessObjects.Models;
using LaundryMiddlePlatform_WinApp.StoreManagement;
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
    public partial class frmViewOrder : Form
    {
        IOrderRepository orderRepository = new OrderRepository();
        private Order orderInfo { get; set; }

        public frmViewOrder()
        {
            InitializeComponent();
        }

        private void frmViewOrder_Load(object sender, EventArgs e)
        {
            LoadOrderList();
        }
        private void EnableText(bool status)
        {
            txtCustomer.Enabled = !status;
            txtOrderDate.Enabled = !status;
            txtPhone.Enabled = !status;
            txtStaffName.Enabled = !status;
            txtStaffPhone.Enabled = !status;
            txtTotalPrice.Enabled = !status;
            txtOrderID.Enabled = !status;

        }
        public void LoadOrderList()
        {
            try
            {
                var orders = orderRepository.GetByStaffIdandStatus(frmLogin.loginUser.AccountId, OrderStatus.Pending.ToString());
                var ordersView = orders.Select(p => new
                {
                    p.OrderId,
                    Customer = p.Customer.FullName,
                    CustomerPhone = p.Customer.PhoneNumber,
                    p.CreateDate,
                    p.TotalPrice,
                    Staff = p.Staff.FullName,
                    StaffPhone = p.Staff.PhoneNumber,
                    p.Status
                });
                BindingSource source = new BindingSource();
                source.DataSource = ordersView;

                txtCustomer.DataBindings.Clear();
                txtOrderDate.DataBindings.Clear();
                txtPhone.DataBindings.Clear();
                txtStaffName.DataBindings.Clear();
                txtStaffPhone.DataBindings.Clear();
                txtTotalPrice.DataBindings.Clear();
                txtOrderID.DataBindings.Clear();
                txtStatus.DataBindings.Clear();

                txtOrderID.DataBindings.Add("Text", source, "OrderId");
                txtCustomer.DataBindings.Add("Text", source, "Customer");
                txtPhone.DataBindings.Add("Text", source, "CustomerPhone");
                txtOrderDate.DataBindings.Add("Text", source, "CreateDate");
                txtTotalPrice.DataBindings.Add("Text", source, "TotalPrice");
                txtStaffName.DataBindings.Add("Text", source, "Staff");
                txtStaffPhone.DataBindings.Add("Text", source, "StaffPhone");
                txtStatus.DataBindings.Add("Text", source, "Status");

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = source;


                EnableText(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "View Order",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int location = dataGridView1.CurrentCell.RowIndex;
                int orderId = int.Parse(dataGridView1.Rows[location].Cells["OrderId"].Value.ToString());
                var currentOrder = orderRepository.GetOrderById(orderId);
                // show form order detail

                frmOrderDetailStaff f = new frmOrderDetailStaff();
                f.currentOrder = currentOrder;
                f.ShowDialog();
                LoadOrderList();
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int location = dataGridView1.CurrentCell.RowIndex;
                int orderId = int.Parse(dataGridView1.Rows[location].Cells["OrderId"].Value.ToString());
                orderInfo = orderRepository.GetOrderById(orderId);
            }
            bool hasNonZeroHeight = orderInfo.OrderDetails.Any(detail => detail.Weight != 0);

            if (!hasNonZeroHeight)
            {
                MessageBox.Show("The order's OrderDetail Weight must be different than 0.", "Store Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult d;
            d = MessageBox.Show("Are you sure working this order?", "Order management",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                bool delStatus = orderRepository.UpdateStatus(orderInfo.OrderId);
                if (delStatus)
                {
                    MessageBox.Show($" Now this order's status is Working.", "Order management",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadOrderList();
            }
        }
    }
}
