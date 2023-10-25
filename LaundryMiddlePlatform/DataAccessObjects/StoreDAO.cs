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
        public static List<Store> getStore()
        {
            List<Store> listStore = new List<Store>();
            try
            {
                using(var context = new LaundryManagementPrnContext())
                {
                    listStore = context.Stores.ToList();
                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listStore;
        }
        public static void SaveStore(Store store)
        {
            using var db = new LaundryManagementPrnContext();   
            db.Stores.Add(store);
            db.SaveChanges();
        }
        public static void DeleteStore(Store store)
        {
            using var db = new LaundryManagementPrnContext();
            db.Stores.Remove(store);
            db.SaveChanges();
        }
        public static void UpdaterStore(Store store)
        {
            using var db = new LaundryManagementPrnContext();
            db.Stores.Update(store);
            db.SaveChanges();

        }
    }
       
}
