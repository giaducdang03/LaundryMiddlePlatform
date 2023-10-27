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
        public void AddService(Service service) => ServiceDAO.Instance.AddService(service);

        public void DeleteService(Service service) => ServiceDAO.Instance.DeleteService(service);

        public List<Service> GetAllService() => ServiceDAO.Instance.GetAllService();

        public Service GetServiceByStoreId(int storeId) => ServiceDAO.Instance.GetServiceByStoreId(storeId);

        public void UpdateService(Service service) => ServiceDAO.Instance.UpdaterService(service);
    }
}
