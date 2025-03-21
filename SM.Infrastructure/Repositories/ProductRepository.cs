using Microsoft.EntityFrameworkCore;
using SM.Infrastructure.Context;
using SM.Infrastructure.Interfaces.IRepository;
using SM.Infrastructure.Models;

namespace SM.Infrastructure.Repositories
{
    public class ProductRepository(StoreDbContext context) : IProductRepository
    {
        private readonly StoreDbContext Context = context;

        public async Task<Product> AddProduct(Product product)
        {
            var result = Context.Products.Add(product)!;

            await Context.SaveChangesAsync();

            return result.Entity;
        }

        public async Task<Product> DeleteProduct(Product product)
        {
            var result = Context.Products.Remove(product)!;

            await Context.SaveChangesAsync();

            return result.Entity;
        }

        public Task<List<Product>> GetAllProducts()
        {
            return Task.Run(() => GetQueryable().ToList());
        }

        public async Task<Product> GetProductByID(Guid id)
        {
            var result = await Context.Products.FirstOrDefaultAsync(x => x!.Id == id);
            return result;
        }


        public async Task<Product> UpdateProduct(Product product)
        {
            var result = Context.Products.Update(product)!;

            await Context.SaveChangesAsync();

            return result.Entity;
        }

        public async Task<Product> GetProductBySerialNumber(string serialNumber)
        {
            var result = await Context.Products.FirstOrDefaultAsync(x => x.SerialNumber == serialNumber);
            return result;
        }

        private IQueryable<Product> GetQueryable()
        {
            var products = Context.Products;
            return products;
        }

    }
}
