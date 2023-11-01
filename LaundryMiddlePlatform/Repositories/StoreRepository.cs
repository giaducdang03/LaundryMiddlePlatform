using BusinessObjects.Models;
using DataAccessObjects;
using Repositories.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class StoreRepository : IStoreRepository
    {
        public List<Store> GetStores() => StoreDAO.Instance.GetStore();
        public bool SaveStore(Store store)
        {
            if (!CommonValidation.CheckString(store.Name, 4, 50))
            {
                throw new Exception("Full name must be 4 to 50 character");
            }
            if(!CommonValidation.CheckString(store.Address, 5, 50))
            {
                throw new Exception("Address must be 4 to 50 character");
            }
            if(!CommonValidation.CheckString(store.PhoneNumber, 9, 11))
            {
                throw new Exception("Phone Number must be 9 to 11 number");
            }
            return StoreDAO.Instance.SaveStore(store);
        }
        public bool UpdateStore(Store store)
        {
            if (!CommonValidation.CheckString(store.Name, 4, 50))
            {
                throw new Exception("Full name must be 4 to 50 character");
            }
            if (!CommonValidation.CheckString(store.Address, 5, 50))
            {
                throw new Exception("Address must be 4 to 50 character");
            }
            if (!CommonValidation.CheckString(store.PhoneNumber, 9, 11))
            {
                throw new Exception("Phone Number must be 9 to 11 number");
            }
            return StoreDAO.Instance.UpdaterStore(store);
        }
        public bool DeleteStore(Store store) => StoreDAO.Instance.DeleteStore(store);

        public Store GetStoreById(int id)
            => StoreDAO.Instance.GetStoreById(id);

        public Store GetStoreByManagerId(int managerId)
            => StoreDAO.Instance.GetStoreByManagerId(managerId);
    }
}
