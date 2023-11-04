using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessObjects;

namespace Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public bool UpdateOrder(OrderDetail orderDetail) => OrderDetailDAO.Instance.UpdateWeight(orderDetail);
       public OrderDetail GetOrderDetail(int id) => OrderDetailDAO.Instance.GetOrderDeTailById(id);
    }
}
