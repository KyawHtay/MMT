using System.Threading.Tasks;
using MMT.Models;

namespace MMT.interfaces
{
    public interface IOrderRepository
    {
         Task<AppUser> GetOrderAsync(string email,int Id);
    }
}