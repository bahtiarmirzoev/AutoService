using ServiceDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceDataLayer.Repositories
{
    public interface ICarStatusRepository
    {
        Task<CarStatus> GetCarStatusByIdAsync(Guid statusId);
        Task<IEnumerable<CarStatus>> GetAllCarStatusesAsync();
        Task AddCarStatusAsync(CarStatus carStatus);
        Task UpdateCarStatusAsync(CarStatus carStatus);
        Task DeleteCarStatusAsync(Guid statusId);
    }
}
