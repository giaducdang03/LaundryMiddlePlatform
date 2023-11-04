using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class OrderDetailDAO
    {
        public static OrderDetailDAO instance = null;
        public static object lockObject = new Object();

        private OrderDetailDAO() { }

        public static OrderDetailDAO Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                }
                return instance;
            }
        }
        public OrderDetail GetOrderDeTailById(int id)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                var orderDetail = db.OrderDetails.FirstOrDefault(x => x.Id == id);
                if (orderDetail == null)
                {
                    throw new Exception("Not found");
                }
                return orderDetail;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        } 

        public bool UpdateWeight (OrderDetail orderDetail)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                db.OrderDetails.Update(orderDetail);
                db.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
