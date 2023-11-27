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

namespace LaundryMiddlePlatform_WinApp.Customer
{
    public partial class frmOrderHistoryCustomer : Form
    {
        public Account loginUser { get; set; }
        public Store currentStore { get; set; }
        IOrderRepository _repo = new OrderRepository();

        IOrderRepository orderRepository = new OrderRepository();
        public frmOrderHistoryCustomer()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadOrderList()
        {
            try
            {
                var orders = _repo.GetOrderByCustomerId(loginUser.AccountId, cboSort.Text);

                double totalAmount = 0;
                foreach (var order in orders)
                {
                    totalAmount += order.TotalPrice.Value;
                }
                var ordersView = orders.Select(p => new
                {
                    p.OrderId,
                    Store = p.Store.Name,
                    p.CreateDate,
                    p.PaymentDate,
                    p.TotalPrice,
                    p.Status,
                });
                BindingSource source = new BindingSource();
                source.DataSource = ordersView;



                dgvOrders.DataSource = null;
                dgvOrders.DataSource = source;

                lblNumOfOrder.Text = orders.Count().ToString();
                lblTotalAmount.Text = string.Format("{0:C}", totalAmount);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Management",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmOrderHistoryCustomer_Load(object sender, EventArgs e)
        {
            cboSort.SelectedIndex = 0;
            LoadOrderList();
        }

        

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                int location = dgvOrders.CurrentCell.RowIndex;
                int orderId = int.Parse(dgvOrders.Rows[location].Cells["OrderId"].Value.ToString());
                var currentOrder = orderRepository.GetOrderById(orderId);
                // show form order detail
                frmOrderDetailCus f = new frmOrderDetailCus();
                f.currentOrder = currentOrder;
                f.ShowDialog();
                LoadOrderList();
            }
        }

        private void cboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOrderList();
        }
    }
}
