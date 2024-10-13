using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ServiceDataLayer.Models;

namespace ServiceDataLayer.Repositories
{
    public interface IRoleRepository
    {
        Task<Role> GetRoleByIdAsync(Guid id);
        Task<IEnumerable<Role>> GetAllRolesAsync();
        Task AddRoleAsync(Role role);
        Task UpdateRoleAsync(Role role);
        Task DeleteRoleAsync(Guid id);
    }
}
