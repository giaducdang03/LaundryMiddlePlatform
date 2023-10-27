using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IServiceRepository
    {
        List<Service> GetAllService();
        void AddService(Service service);
        void DeleteService(Service service);
        void UpdateService(Service service);
        Service GetServiceByStoreId(int storeId);

    
    }
}
