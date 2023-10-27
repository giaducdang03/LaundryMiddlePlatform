using BusinessObjects.Models;
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
        public static object lockObject = new Object();
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
        public List<Service> GetAllService()
        {
            List<Service> listService = new List<Service>();
            try
            {
                using (var context = new LaundryManagementPrnContext())
                {
                    listService = context.Services.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listService;
        }

        public void AddService(Service service)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                var userExist = db.Services.SingleOrDefault(a => a.Name == service.Name && a.StoreId == service.StoreId);
                if (userExist != null)
                {
                    throw new Exception("Service is exist. Please change ");
                }
                db.Services.Add(service);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteService(Service service)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                var updateAccount = db.Services.SingleOrDefault(a => a.ServiceId == service.ServiceId && a.StoreId == service.StoreId );
                if (updateAccount != null)
                {
                    updateAccount.Status = false;
                    db.Services.Update(service);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdaterService(Service service)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                db.Services.Update(service);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public Service GetServiceByStoreId(int storeId)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                return db.Services.SingleOrDefault(s => s.StoreId == storeId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
