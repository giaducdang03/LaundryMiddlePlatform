using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class OrderDAO
    {
        public static OrderDAO instance = null;
        public static object lockObject = new Object();

        private OrderDAO() { }

        public static OrderDAO Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                }
                return instance;
            }
        }

        public List<Order> GetAllOrderByCustomerId(int id)
        {
            List<Order> orders = new List<Order>();
            try
            {
                using var db = new LaundryManagementPrnContext();
                orders = db.Orders
                    .Where(s => s.CustomerId == id)
                    .Include(s => s.Customer)
                    .Include(s => s.OrderDetails)
                    .ToList();
                return orders;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool DeleteOrder(Order order)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                var delOrder = db.Orders.SingleOrDefault(s => s.OrderId == order.OrderId && s.CustomerId == order.CustomerId);
                if (delOrder != null)
                {
                    db.Orders.Remove(delOrder);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool CreateOrder(Order order)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                db.Orders.Add(order);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
