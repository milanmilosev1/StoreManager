
using SM.Infrastructure.Models;

namespace SM.Infrastructure.Interfaces.IRepository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProducts();
        Task<Product> GetProductByID(Guid id);
        Task<Product> AddProduct(Product product);
        Task<Product> DeleteProduct(Product product);
        Task<Product> UpdateProduct(Product product);
        Task<Product> GetProductBySerialNumber(string serialNumber);
    }
}
