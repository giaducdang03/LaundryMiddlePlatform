using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IOrderRepository
    {
        List<Order> GetByStaffIdandStatus(int  staffId, string Status);
        List<Order> GetOrders(string? sortBy, DateTime? from, DateTime? to);
        Order GetOrderById(int id);
        bool UpdateOrder(Order order);
        bool UpdateStatus(int id);
    }
}
