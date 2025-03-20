using SM.Application.Interfaces;
using SM.Application.ViewModels;
using SM.Domain.Interfaces.IRepository;

namespace SM.Application.Services
{
    public class ProductService(IProductRepository productRepository) : IProductService
    {
        private readonly IProductRepository _productRepository = productRepository;

        public ProductViewModel GetProducts()
        {
            return new ProductViewModel
            {
                Products = _productRepository.GetProducts()
            };
        }
    }
}
