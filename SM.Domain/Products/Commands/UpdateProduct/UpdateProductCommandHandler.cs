using MediatR;
using SM.Domain.DTOs;
using SM.Infrastructure.Interfaces.IRepository;
using SM.Infrastructure.Models;

namespace SM.Domain.Products.Commands.UpdateProduct
{
    public class UpdateProductCommandHandler(IProductRepository productRepository) : IRequestHandler<UpdateProductCommand, ProductRepresentation>
    {
        private readonly IProductRepository _productRepository = productRepository;
        public async Task<ProductRepresentation> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                SerialNumber = request.SerialNumber,
                Name = request.Name,
                Price = request.Price
            };

            var result = await _productRepository.UpdateProduct(product);

            return new ProductRepresentation { SerialNumber = result.SerialNumber };
        }
    }
}
