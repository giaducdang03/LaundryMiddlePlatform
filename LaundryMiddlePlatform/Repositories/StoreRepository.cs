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
        public List<Store> GetStores(string? sortType) => StoreDAO.Instance.GetStore(sortType);
        public void SaveStore(Store store) => StoreDAO.Instance.SaveStore(store);
        public void UpdateStore(Store store) => StoreDAO.Instance.UpdaterStore(store);
        public void DeleteStore(Store store) => StoreDAO.Instance.DeleteStore(store);

        public Store GetStoreById(int id)
            => StoreDAO.Instance.GetStoreById(id);

        public Store GetStoreByManagerId(int managerId)
            => StoreDAO.Instance.GetStoreByManagerId(managerId);
    }
}
