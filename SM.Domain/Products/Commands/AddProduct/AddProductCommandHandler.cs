using MediatR;
using SM.Domain.DTOs;
using SM.Infrastructure.Interfaces.IRepository;
using SM.Infrastructure.Models;

namespace SM.Domain.Products.Commands.AddProduct
{
    public class AddProductCommandHandler(IProductRepository productRepository) : IRequestHandler<AddProductCommand, ProductRepresentation>
    {
        private readonly IProductRepository _productRepository = productRepository;
        public async Task<ProductRepresentation> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                SerialNumber = request.SerialNumber,
                Name = request.Name,
                Price = request.Price,
            };

            var result = await _productRepository.AddProduct(product);

            return new ProductRepresentation { SerialNumber = result.SerialNumber };
        }
    }
}
