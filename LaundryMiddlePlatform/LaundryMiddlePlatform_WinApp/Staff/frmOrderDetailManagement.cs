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
    public partial class frmOrderDetailManagement : Form
    {
        bool AddOrUpdate = false;
        IOrderDetailRepository detailRepository = new OrderDetailRepository();
        IOrderRepository orderRepository = new OrderRepository();
        private OrderDetail OrderDetail { get; set; }

        public frmOrderDetailManagement()
        {
            InitializeComponent();
        }
        public OrderDetail currentOrderDetail { get; set; }
        public int currentOrderId { get; set; }

        public void LoadOrderDetail()
        {
            var orderDetail = detailRepository.GetOrderDetail(currentOrderDetail.Id);

            txtId.Text = orderDetail.Id.ToString();
            txtService.Text = orderDetail.ServiceDetail.Service.Name;
            txtType.Text = orderDetail.ServiceDetail.TypeName;
            txtPrice.Text = orderDetail.Price.ToString();
            txtUnitPrice.Text = orderDetail.UnitPrice.ToString();
            txtWeight.Text = orderDetail.Weight.ToString();

        }

        private void frmOrderDetailManagement_Load(object sender, EventArgs e)
        {
            LoadOrderDetail();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Update")
            {
                AddOrUpdate = true;
                txtWeight.ReadOnly = false;
                ClearData();
                //ClearText();

                //btn control
                btnUpdate.Text = "Cancel";
                btnSave.Enabled = true;
            }
            else
            {
                DialogResult d;
                d = MessageBox.Show(AddOrUpdate ? "Do you want to cancel update orderDetail?" : "Do you want to cancel update orderDetail?", "Order Detail Management",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (d == DialogResult.OK)
                {
                    btnUpdate.Text = "Update";
                    ClearText();
                    LoadOrderDetail();
                    txtWeight.ReadOnly = true;
                }
            }
        }
        private void ClearText()
        {

            txtId.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtWeight.Text = string.Empty;

        }
        private void ClearData()
        {
            txtId.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            txtUnitPrice.DataBindings.Clear();
            txtWeight.DataBindings.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                double total = 0;
                OrderDetail = detailRepository.GetOrderDetail(currentOrderDetail.Id);

                if (OrderDetail != null)
                {
                    OrderDetail.Weight = double.Parse(txtWeight.Text);
                    OrderDetail.Price = double.Parse(txtWeight.Text) / 5 * OrderDetail.UnitPrice;
                    detailRepository.UpdateOrder(OrderDetail);
                    btnUpdate.Text = "Update";
                }
                Order order = orderRepository.GetOrderById(currentOrderId);
                List<OrderDetail> list = (List<OrderDetail>)order.OrderDetails;
                foreach (var item in list)
                {
                    if (item.Price != null || item.Price > 0)
                    {
                        total += (double) item.Price;
                    }
                }
                order.TotalPrice = total;
                orderRepository.UpdateOrder(order);

                LoadOrderDetail();
                txtWeight.ReadOnly = true;

                MessageBox.Show("Update weight successfully", "Order",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
