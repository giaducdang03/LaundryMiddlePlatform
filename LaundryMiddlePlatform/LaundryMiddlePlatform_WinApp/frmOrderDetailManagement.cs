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

namespace LaundryMiddlePlatform_WinApp
{
    public partial class frmOrderDetailManagement : Form
    {
        bool AddOrUpdate = false;
        IOrderDetailRepository detailRepository = new OrderDetailRepository();
        private OrderDetail OrderDetail { get; set; }
        public frmOrderDetailManagement()
        {
            InitializeComponent();
        }
        public OrderDetail currentOrderDetail { get; set; }

        public void LoadOrderDetail()
        {

            txtId.Text = currentOrderDetail.Id.ToString();
            txtPrice.Text = currentOrderDetail.Price.ToString();
            txtUnitPrice.Text = currentOrderDetail.UnitPrice.ToString();
            txtWeight.Text = currentOrderDetail.Weight.ToString();

            var orderDetail = new OrderDetail
            {
                Id = currentOrderDetail.Id,
                Price = currentOrderDetail.Price,
                UnitPrice = currentOrderDetail.UnitPrice,
                Weight = currentOrderDetail.Weight
            };




            BindingSource source = new BindingSource();
            source.DataSource = orderDetail;


            dgvOrderDetail.DataSource = null;
            dgvOrderDetail.DataSource = source;

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
                ClearText();

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

            if (dgvOrderDetail.SelectedRows.Count > 0)
            {
                int location = dgvOrderDetail.CurrentCell.RowIndex;
                int orderDetailId = int.Parse(dgvOrderDetail.Rows[location].Cells["Id"].Value.ToString());
                OrderDetail = detailRepository.GetOrderDetail(orderDetailId);
                if (OrderDetail != null)
                {
                    OrderDetail.Weight = double.Parse(txtWeight.Text);
                    OrderDetail.Price = double.Parse(txtWeight.Text) * OrderDetail.UnitPrice;
                    detailRepository.UpdateOrder(OrderDetail);
                    btnUpdate.Text = "Update";

                }
            }
            var orderDetail = new OrderDetail
            {
                Id = OrderDetail.Id,
                Price = OrderDetail.Price,
                UnitPrice = OrderDetail.UnitPrice,
                Weight = OrderDetail.Weight
            };

            ClearText();
            txtId.Text = OrderDetail.Id.ToString();
            txtPrice.Text = OrderDetail.Price.ToString();
            txtUnitPrice.Text = OrderDetail.UnitPrice.ToString();
            txtWeight.Text = OrderDetail.Weight.ToString();
            BindingSource source = new BindingSource();
            source.DataSource = orderDetail;


            dgvOrderDetail.DataSource = null;
            dgvOrderDetail.DataSource = source;


        }
    }
}
