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
        public Order GetOrderById(int id)
            => OrderDAO.Instance.GetOrderById(id);

        public List<Order> GetOrders(string? sortBy, DateTime? from, DateTime? to)
            => OrderDAO.Instance.GetOrders(sortBy, from, to);

        public bool UpdateOrder(Order order)
            => OrderDAO.Instance.UpdateOrder(order);
    }
}
