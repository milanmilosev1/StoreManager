using SM.Domain.Interfaces.IRepository;
using SM.Domain.Models;
using SM.Infrastructure.Context;

namespace SM.Infrastructure.Repositories
{
    public class ProductRepository(StoreDbContext context) : IProductRepository
    {
        private readonly StoreDbContext Context = context;

        public IEnumerable<Product> GetProducts()
        {
            return (IEnumerable<Product>)Context.Products;
        }
    }
}
