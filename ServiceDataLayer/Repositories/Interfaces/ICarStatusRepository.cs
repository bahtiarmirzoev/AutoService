using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ServiceDataLayer.Models;

namespace ServiceDataLayer.Repositories
{
    public interface ICarStatusRepository
    {
        Task<CarStatus> GetCarStatusByIdAsync(Guid id);
        Task<IEnumerable<CarStatus>> GetAllCarStatusesAsync();
        Task AddCarStatusAsync(CarStatus carStatus);
        Task UpdateCarStatusAsync(CarStatus carStatus);
        Task DeleteCarStatusAsync(Guid id);
    }
}
