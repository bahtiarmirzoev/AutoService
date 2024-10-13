using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceDataLayer.Models;

namespace ServiceDataLayer.Repositories
{
    public class ServiceTypeRepository : IServiceTypeRepository
    {
        private readonly ServiceDBContext _context;

        public ServiceTypeRepository(ServiceDBContext context)
        {
            _context = context;
        }

        public async Task<ServiceType> GetServiceTypeByIdAsync(Guid id)
        {
            return await _context.ServiceTypes.FindAsync(id);
        }

        public async Task<IEnumerable<ServiceType>> GetAllServiceTypesAsync()
        {
            return await _context.ServiceTypes.ToListAsync();
        }

        public async Task AddServiceTypeAsync(ServiceType serviceType)
        {
            await _context.ServiceTypes.AddAsync(serviceType);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateServiceTypeAsync(ServiceType serviceType)
        {
            _context.ServiceTypes.Update(serviceType);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteServiceTypeAsync(Guid id)
        {
            var serviceType = await _context.ServiceTypes.FindAsync(id);
            if (serviceType != null)
            {
                _context.ServiceTypes.Remove(serviceType);
                await _context.SaveChangesAsync();
            }
        }
    }
}
