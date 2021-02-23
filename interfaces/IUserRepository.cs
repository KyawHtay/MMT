using System.Collections.Generic;
using System.Threading.Tasks;
using MMT.DTO;
using MMT.Models;

namespace MMT.interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GetUserAsync(string email);
    }
}