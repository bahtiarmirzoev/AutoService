using ServiceDataLayer.Models;

using Microsoft.EntityFrameworkCore;

namespace ServiceDataLayer.Repositories
{
    public class CarStatusRepository : ICarStatusRepository
    {
        private readonly ServiceDBContext _context;

        public CarStatusRepository(ServiceDBContext context)
        {
            _context = context;
        }

        public async Task<CarStatus> GetCarStatusByIdAsync(Guid statusId)
        {
            return await _context.Set<CarStatus>().FindAsync(statusId);
        }

        public async Task<IEnumerable<CarStatus>> GetAllCarStatusesAsync()
        {
            return await _context.Set<CarStatus>().ToListAsync();
        }

        public async Task AddCarStatusAsync(CarStatus carStatus)
        {
            await _context.Set<CarStatus>().AddAsync(carStatus);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCarStatusAsync(CarStatus carStatus)
        {
            _context.Set<CarStatus>().Update(carStatus);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCarStatusAsync(Guid statusId)
        {
            var carStatus = await GetCarStatusByIdAsync(statusId);
            if (carStatus != null)
            {
                _context.Set<CarStatus>().Remove(carStatus);
                await _context.SaveChangesAsync();
            }
        }
    }
}
