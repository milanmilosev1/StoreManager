using SM.Domain.Models;

namespace SM.Domain.Interfaces.IRepository
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetProducts();
    }
}
