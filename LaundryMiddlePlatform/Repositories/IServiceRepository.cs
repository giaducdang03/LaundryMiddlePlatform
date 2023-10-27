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
        List<Service> GetSerivcesByStoreId(int storeId);
        bool AddService(Service service);
        bool UpdateService(Service service);
        bool DeleteService(Service service);
        List<ServiceDetail> GetServiceDetailsByServiceId(int serviceId);
    }
}
