using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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
            
        }
        
    }
}
