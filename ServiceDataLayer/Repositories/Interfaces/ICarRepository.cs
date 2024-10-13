using ServiceDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDataLayer.Repositories.Interfaces
{
    public interface ICarRepository
    {
        Task<Car> GetCarByIdAsync(Guid Id);

        Task<IEnumerable<Car>> GetAllCarsAsync();

        Task AddCarAsync(Car car);

        Task UpdateCarAsync(Car car);

        Task DeleteCarAsync(Guid Id);
    }
}
