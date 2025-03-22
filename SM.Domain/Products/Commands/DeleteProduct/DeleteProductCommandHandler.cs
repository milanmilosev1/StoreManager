using MediatR;
using SM.Domain.DTOs;
using SM.Infrastructure.Context;
using SM.Infrastructure.Interfaces.IRepository;

namespace SM.Domain.Products.Commands.DeleteProduct
{
    public class DeleteProductCommandHandler(IProductRepository productRepository, StoreDbContext context) : IRequestHandler<DeleteProductCommand, ProductRepresentation>
    {
        private readonly IProductRepository _productRepository = productRepository;
        private readonly StoreDbContext Context = context;
        public async Task<ProductRepresentation> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = await Context.Products.FindAsync(request.SerialNumber);
            await _productRepository.DeleteProduct(product);
            return new ProductRepresentation { SerialNumber = request.SerialNumber };
        }
    }
}
