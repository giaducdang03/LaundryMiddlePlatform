using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
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
        public List<Order> GetOrders(string? sortBy, DateTime? from, DateTime? to)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                var query = db.Orders
                    .Include(o => o.OrderDetails)
                    .Include(o => o.Store)
                    .Include(o => o.Customer)
                    .Include(o => o.Staff)
                    .AsQueryable();
                // filter
                if (!string.IsNullOrEmpty(sortBy)) 
                { 
                    if (sortBy == "Newest")
                    {
                        query = query.OrderByDescending(o => o.CreateDate);
                    } 
                    else
                    {
                        query = query.OrderBy(o => o.CreateDate);
                    }
                }
                if (from != null && to != null)
                {
                    query = query.Where(o => o.CreateDate.Value.Date >= from.Value.Date 
                    && o.CreateDate.Value.Date <= to.Value.Date);
                }
                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Order> GetOrdersByAdmin(int id, string? sortBy, DateTime? from, DateTime? to)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                var query = db.Orders
                    .Include(o => o.OrderDetails)
                    .Include(o => o.Store)
                    .Include(o => o.Customer)
                    .Include(o => o.Staff)
                    .Where(o => o.StoreId == id)
                    .AsQueryable();
                // filter
                if (!string.IsNullOrEmpty(sortBy))
                {
                    if (sortBy == "Newest")
                    {
                        query = query.OrderByDescending(o => o.CreateDate);
                    } 
                    else
                    {
                        query = query.OrderBy(o => o.CreateDate);
                    }
                }
                if (from != null && to != null)
                {
                    query = query.Where(o => o.CreateDate.Value.Date >= from.Value.Date
                    && o.CreateDate.Value.Date <= to.Value.Date);
                }

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Order GetOrderById(int id)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                var order = db.Orders
                    .Include(o => o.Store)
                    .Include(o => o.Customer)
                    .Include(o => o.Staff)
                    .Include(o => o.OrderDetails).ThenInclude(od => od.ServiceDetail)
                    .SingleOrDefault(o => o.OrderId == id);
                if (order == null)
                {
                    throw new Exception("Not found");
                }
                return order;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Order> GetOrderByCustomerId(int id, string? sortBy)
        {
            List<Order> orders = new List<Order>();
            try
            {
                using var db = new LaundryManagementPrnContext();
                var query = db.Orders
                    .Include(o => o.OrderDetails)
                    .Include(o => o.Store)
                    .Include(o => o.Customer)
                    .Include(o => o.Staff)
                    .AsQueryable();
                // filter
                if (!string.IsNullOrEmpty(sortBy))
                {
                    if (sortBy == "Newest")
                    {
                        query = query.OrderByDescending(o => o.CreateDate);
                    }
                    else
                    {
                        query = query.OrderBy(o => o.CreateDate);
                    }
                }
                if (!query.Any())
                {
                    throw new Exception("Not found");
                }

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool UpdateOrder(Order order)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                db.Orders.Update(order);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
       
        public bool UpdateStatus(int id)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                Order order = GetOrderById(id);
                order.Status = "Working";
                db.Orders.Update(order);
                db.SaveChanges();
                return true;
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            
        }
        public List<Order> GetOrdersByStaffAndStatus(int? staffId, string? status)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                
                var orders = db.Orders
                    .Include(o => o.Store)
                    .Include(o => o.Customer)
                    .Include(o => o.Staff)
                    .Include(o => o.OrderDetails).ThenInclude(od => od.ServiceDetail)
                    .Where(o => o.StaffId == staffId && o.Status.Equals(status))
                    .ToList();
                return orders;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int SaveOrder(Order order)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                order.CreateDate = DateTime.Now;
                order.Status = OrderStatus.Pending.ToString();
                db.Orders.Add(order);
                db.SaveChanges();
                return order.OrderId;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
