using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class ServiceDAO
    {
        public static ServiceDAO instance = null;
        public static object lockObject = new object();

        private ServiceDAO() { }
        public static ServiceDAO Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new ServiceDAO();
                    }
                }
                return instance;
            }
        }
        public List<Service> GetServicesByStoreId(int storeId)
        {
            List<Service> services = new List<Service>();
            try
            {
                using var db = new LaundryManagementPrnContext();
                services = db.Services
                    .Where(s => s.StoreId == storeId && s.Status == true)
                    .Include(s => s.Store)
                    .Include(s => s.ServiceDetails)
                    .ToList();
                return services;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool AddService(Service service)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                db.Services.Add(service);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool UpdateService(Service service)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                db.Services.Update(service);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool DeleteService(Service service)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                var delService = db.Services.SingleOrDefault(s => s.ServiceId == service.ServiceId);
                if (delService != null)
                {
                    delService.Status = false;
                    db.Services.Update(delService);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ServiceDetail> GetServiceDetailsBySericeId(int sericeId)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                var serviceDetail = db.ServiceDetails
                    .Where(s => s.ServiceId == sericeId && s.Status == true)
                    .Include(s => s.Service)
                    .ToList();
                return serviceDetail;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
