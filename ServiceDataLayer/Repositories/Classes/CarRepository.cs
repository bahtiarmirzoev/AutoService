using Microsoft.EntityFrameworkCore;
using ServiceDataLayer;
using ServiceDataLayer.Models;

public class CarRepository : ICarRepository
{
    private readonly ServiceDBContext _context;

    public CarRepository(ServiceDBContext context)
    {
        _context = context;
    }

    public async Task<Car> GetByIdAsync(Guid id)
    {
        return await _context.Cars
            .Include(c => c.User)
            .Include(c => c.Status)
            .FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<List<Car>> GetAllAsync()
    {
        return await _context.Cars
            .Include(c => c.User)
            .Include(c => c.Status)
            .ToListAsync();
    }

    public async Task<List<Car>> GetByUserIdAsync(Guid userId)
    {
        return await _context.Cars
            .Include(c => c.User)
            .Include(c => c.Status)
            .Where(c => c.UserId == userId)
            .ToListAsync();
    }

    public async Task<List<Car>> GetByStatusIdAsync(Guid statusId)
    {
        return await _context.Cars
            .Include(c => c.User)
            .Include(c => c.Status)
            .Where(c => c.StatusId == statusId)
            .ToListAsync();
    }

    public async Task AddAsync(Car car)
    {
        await _context.Cars.AddAsync(car);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Car car)
    {
        _context.Cars.Update(car);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var car = await _context.Cars.FindAsync(id);
        if (car != null)
        {
            _context.Cars.Remove(car);
            await _context.SaveChangesAsync();
        }
    }
}
