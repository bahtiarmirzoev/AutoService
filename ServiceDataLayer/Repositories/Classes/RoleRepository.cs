using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceDataLayer.Models;

namespace ServiceDataLayer.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ServiceDBContext _context;

        public RoleRepository(ServiceDBContext context)
        {
            _context = context;
        }

        public async Task<Role> GetRoleByIdAsync(Guid id)
        {
            return await _context.Roles.Include(r => r.Users).FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<IEnumerable<Role>> GetAllRolesAsync()
        {
            return await _context.Roles.Include(r => r.Users).ToListAsync();
        }

        public async Task AddRoleAsync(Role role)
        {
            await _context.Roles.AddAsync(role);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRoleAsync(Role role)
        {
            _context.Roles.Update(role);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRoleAsync(Guid id)
        {
            var role = await _context.Roles.FindAsync(id);
            if (role != null)
            {
                _context.Roles.Remove(role);
                await _context.SaveChangesAsync();
            }
        }
    }
}
