using Microsoft.EntityFrameworkCore;
using ServiceDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceDataLayer.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly ServiceDBContext _context;

        public UserRepository(ServiceDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _context.Users
                                 .Include(u => u.UserCars)
                                 .Include(u => u.UserRoles)
                                 .ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(Guid userId)
        {
            return await _context.Users
                                  .Include(u => u.UserCars)
                                  .Include(u => u.UserRoles)
                                  .FirstOrDefaultAsync(u => u.Id == userId);
        }

        // Метод для добавления нового пользователя
        public async Task<User> AddUserAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            var existingUser = await _context.Users
                                              .Include(u => u.UserCars)
                                              .Include(u => u.UserRoles)
                                              .FirstOrDefaultAsync(u => u.Id == user.Id);

            if (existingUser == null)
            {
                return null;
            }

            existingUser.Username = user.Username;
            existingUser.Name = user.Name;
            existingUser.Surname = user.Surname;
            existingUser.Email = user.Email;
            existingUser.Phone = user.Phone;
            existingUser.Password = user.Password;

            _context.Users.Update(existingUser);
            await _context.SaveChangesAsync();

            return existingUser;
        }

        public async Task<bool> DeleteUserAsync(Guid userId)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user == null)
            {
                return false;
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
