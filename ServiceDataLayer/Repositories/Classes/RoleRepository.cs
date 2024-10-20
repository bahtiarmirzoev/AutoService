using ServiceDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ServiceDataLayer.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ServiceDBContext _context;

        public RoleRepository(ServiceDBContext context)
        {
            _context = context;
        }

        public async Task<Role> GetRoleByIdAsync(Guid roleId)
        {
            return await _context.Set<Role>().FindAsync(roleId);
        }

        public async Task<IEnumerable<Role>> GetAllRolesAsync()
        {
            return await _context.Set<Role>().ToListAsync();
        }

        public async Task AddRoleAsync(Role role)
        {
            await _context.Set<Role>().AddAsync(role);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRoleAsync(Role role)
        {
            _context.Set<Role>().Update(role);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRoleAsync(Guid roleId)
        {
            var role = await GetRoleByIdAsync(roleId);
            if (role != null)
            {
                _context.Set<Role>().Remove(role);
                await _context.SaveChangesAsync();
            }
        }
    }
}
