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
    public partial class frmOrderManagement : Form
    {
        public Account managerAccount { get; set; }
        public Store currentStore { get; set; }

        IOrderRepository orderRepository = new OrderRepository();
        public frmOrderManagement()
        {
            InitializeComponent();
        }

        private void frmOrderManagement_Load(object sender, EventArgs e)
        {
            lblStoreName.Text = currentStore.Name;
            lblManager.Text = managerAccount.Email;
            cboSort.SelectedIndex = 0;
            LoadOrderList();
        }

        private void LoadOrderList()
        {
            try
            {
                BindingSource source = new BindingSource();
                var orders = orderRepository.GetOrders(cboSort.Text, dtpFrom.Value, dtpTo.Value);
                double totalAmount = 0;
                if (orders.Any())
                {
                    foreach (var order in orders)
                    {
                        totalAmount += order.TotalPrice.Value;
                    }
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

                    source.DataSource = ordersView;

                    ClearData();

                    txtOrderId.DataBindings.Add("Text", source, "OrderId");
                    txtCustomer.DataBindings.Add("Text", source, "Customer");
                    txtPhone.DataBindings.Add("Text", source, "CustomerPhone");
                    txtOrderDate.DataBindings.Add("Text", source, "CreateDate");
                    txtPrice.DataBindings.Add("Text", source, "TotalPrice");
                    lblStatus.DataBindings.Add("Text", source, "Status");
                    txtStaffName.DataBindings.Add("Text", source, "Staff");
                    txtStaffPhone.DataBindings.Add("Text", source, "StaffPhone");
                }
                else
                {
                    ClearText();
                    source.DataSource = null;
                    MessageBox.Show("Not found orders in the period. Please choose another time.", "Order Management",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                dgvOrders.DataSource = null;
                dgvOrders.DataSource = source;

                lblNumOfOrder.Text = orders.Count().ToString();
                lblTotalAmount.Text = string.Format("{0:C}", totalAmount);

                EnableText(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Management",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                int location = dgvOrders.CurrentCell.RowIndex;
                int orderId = int.Parse(dgvOrders.Rows[location].Cells["OrderId"].Value.ToString());
                var currentOrder = orderRepository.GetOrderById(orderId);
                // show form order detail
                frmOrderDetail f = new frmOrderDetail();
                f.currentOrder = currentOrder;
                f.ShowDialog();
                LoadOrderList();
            }
        }

        private void cboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOrderList();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadOrderList();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            LoadOrderList();
        }

        private void ClearData()
        {
            txtOrderId.DataBindings.Clear();
            txtCustomer.DataBindings.Clear();
            txtPhone.DataBindings.Clear();
            txtOrderDate.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            lblStatus.DataBindings.Clear();
            txtStaffName.DataBindings.Clear();
            txtStaffPhone.DataBindings.Clear();
        }

        private void EnableText(bool status)
        {
            txtOrderId.ReadOnly = !status;
            txtCustomer.ReadOnly = !status;
            txtPhone.ReadOnly = !status;
            txtOrderDate.ReadOnly = !status;
            txtPrice.ReadOnly = !status;
            txtStaffName.ReadOnly = !status;
            txtStaffPhone.ReadOnly = !status;
        }

        private void ClearText()
        {
            txtOrderId.Text = string.Empty;
            txtCustomer.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtOrderDate.Text = string.Empty;
            txtPrice.Text = string.Empty;
            lblStatus.Text = string.Empty;
            txtStaffName.Text = string.Empty;
            txtStaffPhone.Text = string.Empty;
        }
    }
}
