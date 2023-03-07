using EcommerceStoreDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EcommerceStoreDataAccess
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Order> Order { get; set; }
        public DbSet<OrderProductQuantity> OrderProductQuantity { get; set; }
        public DbSet<Product> Product { get; set; }


    }
}
