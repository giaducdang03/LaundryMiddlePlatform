using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using BusinessObjects.Models;

namespace Repositories
{
    public interface IStoreRepository
    {
         
        bool SaveStore(Store store);
        bool DeleteStore(Store store); 
        bool UpdateStore(Store store);
        List<Store> GetStores(string? sortType);
        Store GetStoreById(int id);
        Store GetStoreByManagerId(int managerId);
    }
}
