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
    public partial class frmOrderDetailStaff : Form
    {
        IOrderRepository orderRepo = new OrderRepository();
        IOrderDetailRepository orderDetailRepo = new OrderDetailRepository();

        bool AddOrUpdate = false;
        public Order currentOrder { get; set; }
        public frmOrderDetailStaff()
        {
            InitializeComponent();
        }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            LoadOrderData();
        }

        public void LoadOrderData()
        {
            try
            {
                var order = orderRepo.GetOrderById(currentOrder.OrderId);

                txtOrderId.Text = order.OrderId.ToString();
                txtCustomer.Text = order.Customer.FullName;
                txtCustomerPhone.Text = order.Customer.PhoneNumber;
                txtPrice.Text = string.Format("{0:C}", order.TotalPrice);
                txtOrderDate.Text = order.CreateDate.ToString();
                txtStaffName.Text = currentOrder.Staff.FullName;
                txtStaffPhone.Text = currentOrder.Staff.PhoneNumber;
                lblStatus.Text = order.Status;

                var viewDetail = order.OrderDetails.Select(p => new
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

                if (order.Status != OrderStatus.Pending.ToString())
                {
                    btnWorking.Enabled = false;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order Management",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                d = MessageBox.Show("Do you want to mark this order as 'Working'?", "Order management",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (d == DialogResult.OK)
                {
                    currentOrder.Status = OrderStatus.Working.ToString();
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



        private void dgvOrderDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrderDetail.SelectedRows.Count > 0)
            {
                int location = dgvOrderDetail.CurrentCell.RowIndex;
                int orderDetailId = int.Parse(dgvOrderDetail.Rows[location].Cells["Id"].Value.ToString());
                var currentOrderDetail = orderDetailRepo.GetOrderDetail(orderDetailId);
                // show form order detail
                if (frmLogin.loginUser.Role.Equals("Staff") && currentOrder.Status == OrderStatus.Pending.ToString())
                {
                    frmOrderDetailManagement f = new frmOrderDetailManagement();
                    f.currentOrderDetail = currentOrderDetail;
                    f.currentOrderId = currentOrder.OrderId;
                    f.ShowDialog();
                    LoadOrderData();
                }
                else
                {
                    MessageBox.Show("You don't have this permission to do this function", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}
