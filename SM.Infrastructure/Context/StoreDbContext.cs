using Microsoft.EntityFrameworkCore;
using SM.Infrastructure.Models;

namespace SM.Infrastructure.Context
{
    public class StoreDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees{ get; set; }
        public DbSet<BillProduct> BillProducts{ get; set; }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=StoreDB;Username=postgres;Password=milan4321");
        }
    }
}
