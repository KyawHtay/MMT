using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MMT.interfaces;
using MMT.Models;

namespace MMT.Data
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _context;
        public OrderRepository(DataContext context)
        {
            _context = context;

        }

        public  async Task<AppUser> GetOrderAsync(string email, int Id)
        {
            return await _context.Users.Where(x => x.Id == Id)
                .Include(c=>c.order)
                .SingleAsync();
        }
    }
}