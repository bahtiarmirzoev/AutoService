using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceDataLayer.Models;

namespace ServiceDataLayer.Repositories
{
    public class CarStatusRepository : ICarStatusRepository
    {
        private readonly ServiceDBContext _context;

        public CarStatusRepository(ServiceDBContext context)
        {
            _context = context;
        }

        public async Task<CarStatus> GetCarStatusByIdAsync(Guid id)
        {
            return await _context.CarStatuses.Include(cs => cs.Cars).FirstOrDefaultAsync(cs => cs.Id == id);
        }

        public async Task<IEnumerable<CarStatus>> GetAllCarStatusesAsync()
        {
            return await _context.CarStatuses.Include(cs => cs.Cars).ToListAsync();
        }

        public async Task AddCarStatusAsync(CarStatus carStatus)
        {
            await _context.CarStatuses.AddAsync(carStatus);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCarStatusAsync(CarStatus carStatus)
        {
            _context.CarStatuses.Update(carStatus);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCarStatusAsync(Guid id)
        {
            var carStatus = await _context.CarStatuses.FindAsync(id);
            if (carStatus != null)
            {
                _context.CarStatuses.Remove(carStatus);
                await _context.SaveChangesAsync();
            }
        }
    }
}
