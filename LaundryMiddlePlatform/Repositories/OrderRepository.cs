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

        public List<Order> GetOrderByCustomerId(int customerId, string? sortBy) => OrderDAO.Instance.GetOrderByCustomerId(customerId, sortBy);


        public Order GetOrderById(int id)
            => OrderDAO.Instance.GetOrderById(id);

        public List<Order> GetOrders(string? sortBy, DateTime? from, DateTime? to)
            => OrderDAO.Instance.GetOrders(sortBy, from, to);

        public int SaveOrder(Order order)
            => OrderDAO.Instance.SaveOrder(order);

        public bool UpdateOrder(Order order)
            => OrderDAO.Instance.UpdateOrder(order);
    }
}
