using BusinessObjects.Models;
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

                listStore = query.ToList();

                return listStore;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listStore;
        }
        public void SaveStore(Store store)
        {
            using var db = new LaundryManagementPrnContext();   
            db.Stores.Add(store);
            db.SaveChanges();
        }
        public void DeleteStore(Store store)
        {
            using var db = new LaundryManagementPrnContext();
            store.Status = false;
            db.Stores.Remove(store);
            db.SaveChanges();
        }
        public void UpdaterStore(Store store)
        {
            using var db = new LaundryManagementPrnContext();
            db.Stores.Update(store);
            db.SaveChanges();
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
