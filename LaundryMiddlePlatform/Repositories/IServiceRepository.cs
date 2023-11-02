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
        List<Service> GetSerivcesByStoreId(int storeId, string? txtSearch);
        Service GetServiceById(int id);
        bool AddService(Service service);
        bool UpdateService(Service service);
        bool DeleteService(Service service);
        List<ServiceDetail> GetServiceDetailsByServiceId(int serviceId);
        ServiceDetail GetServiceDetailById(int id);
        bool AddServiceDetail(ServiceDetail serviceDetail);
        bool DeleteServiceDetail(ServiceDetail serviceDetail);

        bool UpdateServiceDetail(ServiceDetail serviceDetail);
    }
}
