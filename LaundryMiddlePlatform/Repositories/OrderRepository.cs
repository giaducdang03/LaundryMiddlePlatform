using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public bool CreateOrder(Order order) => OrderDAO.Instance.CreateOrder(order);

        public bool DeleteOrder(Order order) => OrderDAO.Instance.DeleteOrder(order);

        public List<Order> GetAllOrderOfCustomer(int customerId) => OrderDAO.Instance.GetAllOrderByCustomerId(customerId);
    }
}
