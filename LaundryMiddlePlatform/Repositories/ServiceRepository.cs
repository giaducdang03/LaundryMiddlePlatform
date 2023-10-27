using BusinessObjects.Models;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        public bool AddService(Service service)
            => ServiceDAO.Instance.AddService(service);

        public bool DeleteService(Service service)
            => ServiceDAO.Instance.DeleteService(service);

        public List<Service> GetSerivcesByStoreId(int storeId)
            => ServiceDAO.Instance.GetServicesByStoreId(storeId);

        public bool UpdateService(Service service)
            => ServiceDAO.Instance.UpdateService(service);

        public List<ServiceDetail> GetServiceDetailsByServiceId(int serviceId)
            => ServiceDAO.Instance.GetServiceDetailsBySericeId(serviceId);
    }
}
