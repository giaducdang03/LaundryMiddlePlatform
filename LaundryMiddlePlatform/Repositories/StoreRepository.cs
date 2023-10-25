using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class StoreRepository : IStoreRepository
    {
        public List<Store> GetStores() => StoreDAO.getStore();
        public void SaveStore(Store store) => StoreDAO.SaveStore(store);
        public void UpdateStore(Store store) => StoreDAO.UpdaterStore(store);
        public void DeleteStore(Store store) => StoreDAO.DeleteStore(store);

    }
}
