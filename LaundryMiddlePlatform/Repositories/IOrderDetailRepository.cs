using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IOrderDetailRepository
    {
        bool UpdateOrder(OrderDetail orderDetail);
        OrderDetail GetOrderDetail(int id);
    }
}
