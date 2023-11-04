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

namespace LaundryMiddlePlatform_WinApp.Admin
{
    public partial class frmOrdersManagement : Form
    {
        public Account loginAccount { get; set; }
        IOrderRepository orderRepository = new OrderRepository();
        IStoreRepository storeRepository = new StoreRepository();
        public frmOrdersManagement()
        {
            InitializeComponent();
        }

        private void frmOrdersManagement_Load(object sender, EventArgs e)
        {
            cboSort.SelectedIndex = 0;
            LoadStore();
        }
        private void LoadOrderList()
        {
            try
            {
                var orders = orderRepository.GetOrdersByAdmin(int.Parse(cboStore.SelectedValue.ToString()), cboSort.Text, dtpFrom.Value, dtpTo.Value);
                double totalAmount = 0;
                foreach (var order in orders)
                {
                    totalAmount += order.TotalPrice.Value;
                }
                var ordersView = orders.Select(p => new
                {
                    p.OrderId,
                    p.StoreId,
                    p.CustomerId,
                    storeName = p.Store.Name,
                    p.PaymentDate,
                    p.CreateDate,
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
        private void LoadStore()
        {
            try
            {
                var stores = storeRepository.GetStores(null);
                if (!stores.Any())
                {
                    throw new Exception("Not found services of the store");
                }

                cboStore.ValueMember = "StoreId";
                cboStore.DisplayMember = "Name";
                cboStore.DataSource = stores;
                cboStore.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order",
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
            /*dgvOrders.Visible = true;
            LoadOrderList();*/
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadOrderList();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            LoadOrderList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOrderList();
        }
    }
}
