using ServiceDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceDataLayer.Repositories
{
    public interface IRoleRepository
    {
        Task<Role> GetRoleByIdAsync(Guid roleId);
        Task<IEnumerable<Role>> GetAllRolesAsync();
        Task AddRoleAsync(Role role);
        Task UpdateRoleAsync(Role role);
        Task DeleteRoleAsync(Guid roleId);
    }
}
