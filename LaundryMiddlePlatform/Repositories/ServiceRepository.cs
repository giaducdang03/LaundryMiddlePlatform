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
    public class ServiceRepository : IServiceRepository
    {
        public Service GetServiceById(int id)
            => ServiceDAO.Instance.GetServiceById(id);

        public bool AddService(Service service)
        { 
            if (!CommonValidation.CheckString(service.Name, 4, 50))
            {
                throw new Exception("Serivce name must be 4 to 50 characters.");
            }
            if (!CommonValidation.CheckString(service.Name, 4, 50))
            {
                throw new Exception("Description must be 4 to 100 characters.");
            }
            return ServiceDAO.Instance.AddService(service);
        }

        public bool DeleteService(Service service)
            => ServiceDAO.Instance.DeleteService(service);

        public List<Service> GetSerivcesByStoreId(int storeId, string? txtSearch)
            => ServiceDAO.Instance.GetServicesByStoreId(storeId, txtSearch);

        public bool UpdateService(Service service)
            => ServiceDAO.Instance.UpdateService(service);

        public List<ServiceDetail> GetServiceDetailsByServiceId(int serviceId)
            => ServiceDAO.Instance.GetServiceDetailsBySericeId(serviceId);

        public ServiceDetail GetServiceDetailById(int id)
            => ServiceDAO.Instance.GetServiceDetailById(id);

        public bool UpdateServiceDetail(ServiceDetail serviceDetail)
            => ServiceDAO.Instance.UpdateServiceDetail(serviceDetail);

        public bool AddServiceDetail(ServiceDetail serviceDetail)
            => ServiceDAO.Instance.AddServiceDetail(serviceDetail);

        public bool DeleteServiceDetail(ServiceDetail serviceDetail)
            => ServiceDAO.Instance.DeleteServiceDetail(serviceDetail);
    }
}
