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
        void SaveStore(Store store);
        void DeleteStore(Store store); 
        void UpdateStore(Store store);
        List<Store> GetStores();
    }
}
