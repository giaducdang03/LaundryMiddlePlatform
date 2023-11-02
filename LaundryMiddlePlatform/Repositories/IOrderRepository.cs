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
        public List<Order> GetAllOrderOfCustomer(int customerId);
        public bool DeleteOrder(Order order);
        public bool CreateOrder(Order order);
    }
}
