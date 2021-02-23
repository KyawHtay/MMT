using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MMT.DTO;
using MMT.interfaces;
using MMT.Models;

namespace MMT.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context;

        }

        public async Task<AppUser> GetUserAsync(string email)
        {
             return await _context.Users.Where(x => x.Email == email).SingleAsync();
                
        }

        public async Task<IEnumerable<AppUser>> GetUsersAsync()
        {
            return await _context.Users
                .ToListAsync();
        }
    }
}