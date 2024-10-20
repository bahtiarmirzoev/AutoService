using ServiceDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceDataLayer.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(Guid userId);
        Task<User> AddUserAsync(User user);
        Task<User> UpdateUserAsync(User user);
        Task<bool> DeleteUserAsync(Guid userId);
    }
}
