using Microsoft.EntityFrameworkCore;
using MMT.Models;

namespace MMT.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}