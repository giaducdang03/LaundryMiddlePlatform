using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class StoreDAO
    {
        public static StoreDAO instance = null;
        public static object lockObject = new object();

        private StoreDAO() { }
        public static StoreDAO Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new StoreDAO();
                    }
                }
                return instance;
            }
        }
        public List<Store> GetStore(string? sortType)
        {
            List<Store> listStore = new List<Store>();
           
            try
            {
                using var db = new LaundryManagementPrnContext();
                var query = db.Stores.Where(a => a.Status == true).AsQueryable();
                if (!string.IsNullOrEmpty(sortType))
                {
                    if (sortType == "Name: A -> Z")
                    {
                        query = query.OrderBy(a => a.Name);
                    }
                    if (sortType == "Name: Z -> A")
                    {
                        query = query.OrderByDescending(a => a.Name);
                    }
                }
                if (!query.Any())
                {
                    throw new Exception("Not found.");
                }

                listStore = query.Include(m => m.Manager).ToList();

                return listStore;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool SaveStore(Store store)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                db.Stores.Add(store);
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool DeleteStore(Store store)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                var updateStore = db.Stores.SingleOrDefault(a => a.StoreId == store.StoreId);
                if (updateStore != null)
                {
                    updateStore.Status = false;
                    db.Stores.Update(updateStore);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }
        public bool UpdaterStore(Store store)
        {
            try
            {
                using var db = new LaundryManagementPrnContext();
                db.Stores.Update(store);
                db.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }   
        }
    
        public Store GetStoreById(int id)
        {
            using var db = new LaundryManagementPrnContext();
            return db.Stores.SingleOrDefault(s => s.StoreId == id && s.Status == true);
        }

        public Store GetStoreByManagerId(int managerId)
        {
            using var db = new LaundryManagementPrnContext();
            return db.Stores.SingleOrDefault(s => s.ManagementId == managerId && s.Status == true);
        }
    }
       
}
