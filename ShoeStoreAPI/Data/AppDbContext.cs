using Microsoft.EntityFrameworkCore;
using ShoeStoreAPI.Models;

namespace ShoeStoreAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts) { }
        public DbSet<User> Users => Set<User>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Shoe> Shoes => Set<Shoe>();


    }
    
}
