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
        public List<Service> GetServicesByStoreId(int storeId, string? txtSearch)
        {
            List<Service> services = new List<Service>();
            try
            {
                using var db = new LaundryManagementPrnContext();
                var query = db.Services
                    .Where(s => s.StoreId == storeId && s.Status == true)
                    .Include(s => s.Store)
                    .Include(s => s.ServiceDetails)
                    .AsQueryable();
                // search function
                if (!string.IsNullOrEmpty(txtSearch.Trim()))
                {
                    query = query.Where(s => s.Name.ToLower().Contains(txtSearch.ToLower()));
                }
                services = query.ToList();
                return services;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Service GetServiceById(int serviceId)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                return db.Services
                    .Include(s => s.ServiceDetails)
                    .SingleOrDefault(s => s.ServiceId == serviceId);
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

        public ServiceDetail GetServiceDetailById(int id)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                var serviceDetail = db.ServiceDetails
                    .Include(s => s.Service)
                    .SingleOrDefault(s => s.Id == id && s.Status == true);
                return serviceDetail;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool AddServiceDetail(ServiceDetail serviceDetail)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                db.ServiceDetails.Add(serviceDetail);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool UpdateServiceDetail(ServiceDetail serviceDetail)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                db.ServiceDetails.Update(serviceDetail);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool DeleteServiceDetail(ServiceDetail serviceDetail)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                var delServiceDetail = db.ServiceDetails.SingleOrDefault(s => s.Id == serviceDetail.Id);
                if (delServiceDetail != null)
                {
                    delServiceDetail.Status = false;
                    db.ServiceDetails.Update(delServiceDetail);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}