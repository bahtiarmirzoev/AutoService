using Microsoft.EntityFrameworkCore;
using ServiceDataLayer.Models;
using ServiceDataLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceDataLayer.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly ServiceDBContext _context;

        public CarRepository(ServiceDBContext context)
        {
            _context = context;
        }

        public async Task<Car> GetCarByIdAsync(Guid id)
        {
            return await _context.Cars
                .Include(c => c.User)
                .Include(c => c.Status)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<Car>> GetAllCarsAsync()
        {
            return await _context.Cars
                .Include(c => c.User)
                .Include(c => c.Status)
                .ToListAsync();
        }

        public async Task AddCarAsync(Car car)
        {
            await _context.Cars.AddAsync(car);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCarAsync(Car car)
        {
            _context.Cars.Update(car);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCarAsync(Guid id)
        {
            var car = await GetCarByIdAsync(id);
            if (car != null)
            {
                _context.Cars.Remove(car);
                await _context.SaveChangesAsync();
            }
        }
    }
}
