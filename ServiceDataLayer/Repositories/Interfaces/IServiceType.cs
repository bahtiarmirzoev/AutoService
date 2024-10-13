using ServiceDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceDataLayer.Repositories
{
    public interface IServiceTypeRepository
    {
        Task<ServiceType> GetServiceTypeByIdAsync(Guid id);
        Task<IEnumerable<ServiceType>> GetAllServiceTypesAsync();
        Task AddServiceTypeAsync(ServiceType serviceType);
        Task UpdateServiceTypeAsync(ServiceType serviceType);
        Task DeleteServiceTypeAsync(Guid id);
    }
}
