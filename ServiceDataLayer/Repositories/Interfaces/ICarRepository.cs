using ServiceDataLayer.Models;

public interface ICarRepository
{
    Task<Car> GetByIdAsync(Guid id);
    Task<List<Car>> GetAllAsync();
    Task<List<Car>> GetByUserIdAsync(Guid userId);
    Task<List<Car>> GetByStatusIdAsync(Guid statusId);
    Task AddAsync(Car car);
    Task UpdateAsync(Car car);
    Task DeleteAsync(Guid id);
}