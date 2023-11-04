using BusinessObjects.Models;
using LaundryMiddlePlatform_WinApp.StoreManagement;
using Microsoft.EntityFrameworkCore;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LaundryMiddlePlatform_WinApp.Customer
{
    public partial class frmCustomerOrder : Form
    {
        // repo
        IServiceRepository serviceRepository = new ServiceRepository();
        IAccountRepository accountRepository = new AccountRepository();
        IOrderRepository orderRepository = new OrderRepository();
        public Store orderStore { get; set; }
        public Account loginUser { get; set; }
        public Order order { get; set; }
        public List<OrderDetail> listOrderDeatail = new List<OrderDetail>();
        public frmCustomerOrder()
        {
            InitializeComponent();
        }

        private void frmCustomerOrder_Load(object sender, EventArgs e)
        {
            // store info
            lblStore.Text = orderStore.Name;
            lblStroreAddr.Text = orderStore.Address;
            lblStorePhone.Text = orderStore.PhoneNumber;
            // customer info
            lblCustomer.Text = loginUser.FullName;
            lblCustomerAddr.Text = loginUser.Address;
            lblCusPhone.Text = loginUser.PhoneNumber;

            lblNotice.Text = "(Actual price may vary depending on your laundry quantity.)";
            lblNotionalPrice.Text = string.Format("{0:C}", 0);

            LoadServiceList();
            // create new order
            order = new Order
            {
                StoreId = orderStore.StoreId,
                CustomerId = loginUser.AccountId,
                TotalPrice = 0
            };
        }

        private void LoadServiceList()
        {
            try
            {
                var services = serviceRepository.GetSerivcesByStoreId(orderStore.StoreId, "");
                if (!services.Any())
                {
                    throw new Exception("Not found services of the store");
                }

                cboServices.ValueMember = "ServiceId";
                cboServices.DisplayMember = "Name";
                cboServices.DataSource = services;
                cboServices.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cboServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var service = serviceRepository.GetServiceById(int.Parse(cboServices.SelectedValue.ToString()));
                var serviceDeatails = service.ServiceDetails;
                cboType.ValueMember = "Id";
                cboType.DisplayMember = "TypeName";
                if (listOrderDeatail.Any())
                {
                    foreach (var item in listOrderDeatail)
                    {
                        serviceDeatails = serviceDeatails.Where(s => s.Id != item.ServiceDetailId).ToList();
                    }
                }
                cboType.DataSource = serviceDeatails;

                cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var serviceDetail = serviceRepository.GetServiceDetailById(int.Parse(cboType.SelectedValue.ToString()));
                if (serviceDetail == null)
                {
                    throw new Exception("Error load");
                }
                lblDuration.Text = serviceDetail.Duration.ToString();
                lblPrice.Text = string.Format("{0:C}", serviceDetail.PricePerUnit);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                var serviceDeatail = serviceRepository.GetServiceDetailById(int.Parse(cboType.SelectedValue.ToString()));
                if (serviceDeatail == null)
                {
                    throw new Exception("Not found service.");
                }
                OrderDetail orderDetail = new OrderDetail
                {
                    ServiceDetailId = serviceDeatail.Id,
                    UnitPrice = serviceDeatail.PricePerUnit,
                    ServiceDetail = serviceDeatail
                };
                listOrderDeatail.Add(orderDetail);
                LoadListOrderDetail();
                LoadServiceList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadListOrderDetail()
        {
            double tempPrice = 0;
            if (listOrderDeatail.Any())
            {
                foreach (var item in listOrderDeatail)
                {
                    tempPrice += item.UnitPrice.Value;
                }
            }

            lblNotionalPrice.Text = string.Format("{0:C}", tempPrice);

            var viewList = listOrderDeatail.Select(p => new
            {
                p.ServiceDetailId,
                ServiceName = p.ServiceDetail.Service.Name,
                Type = p.ServiceDetail.TypeName,
                PricePer5Kg = p.UnitPrice
            });

            BindingSource source = new BindingSource();
            source.DataSource = viewList;

            dgvOrderDetail.DataSource = null;
            dgvOrderDetail.DataSource = source;
        }

        private void dgvOrderDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrderDetail.SelectedRows.Count > 0)
            {
                int location = dgvOrderDetail.CurrentCell.RowIndex;
                int serviceDetailId = int.Parse(dgvOrderDetail.Rows[location].Cells["ServiceDetailId"].Value.ToString());
                var removeItem = listOrderDeatail.SingleOrDefault(s => s.ServiceDetailId == serviceDetailId);
                listOrderDeatail.Remove(removeItem);
                LoadListOrderDetail();
                LoadServiceList();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you want to cancel order?", "Order",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                order = null;
                listOrderDeatail.Clear();
                this.Close();
                //LoadListOrderDetail();
                //LoadServiceList();
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                // check list
                if (!listOrderDeatail.Any())
                {
                    throw new Exception("Please choose a service before Order!");
                }
                order.OrderDetails = listOrderDeatail;
                order.StaffId = AssignStaff().AccountId;
                int orderId = orderRepository.SaveOrder(order);
                if (orderId != 0)
                {
                    MessageBox.Show("Order successfully. The staff will contact you soon.",
                        "Laundry Middle Platform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                order = null;
                listOrderDeatail.Clear();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Order",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // tools
        private Account AssignStaff()
        {
            var staffs = accountRepository.GetStaff();
            Account workStaff = null;
            // staff not have job on date
            var orders = orderRepository.GetOrders(null, null, null);
            foreach (var staff in staffs)
            {
                var ordersWoking = orders.Where(o => o.StaffId == staff.AccountId)
                    .Where(o => o.CreateDate.Value.Date == DateTime.Now.Date)
                    .ToList();
                if (!ordersWoking.Any())
                {
                    workStaff = staff;
                    break;
                }
            }
            // all staffs have a job on date
            if (workStaff == null)
            {
                var staffIdWithMinRecords = orders.Where(o => o.CreateDate.Value.Date == DateTime.Now.Date)
                    .GroupBy(o => o.StaffId)
                    .Select(group => new
                    {
                        StaffId = group.Key,
                        RecordCount = group.Count()
                    })
                    .OrderBy(group => group.RecordCount)
                    .ThenBy(group => group.StaffId)
                    .Select(group => group.StaffId)
                .FirstOrDefault();

                workStaff = accountRepository.GetAccountById(staffIdWithMinRecords.Value);
            }
            return workStaff;
        }
    }
}
