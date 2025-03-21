using AutoMapper;
using MediatR;
using SM.Domain.DTOs;
using SM.Infrastructure.Interfaces.IRepository;
using SM.Infrastructure.Models;

namespace SM.Domain.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryHandler(IProductRepository productRepository, IMapper mapper) : IRequestHandler<GetAllProductsQuery, List<ProductRepresentation>>
    {
        private readonly IProductRepository _productRepository = productRepository;
        private readonly IMapper _mapper = mapper;
        public async Task<List<ProductRepresentation>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetAllProducts();

            var result = _mapper.Map<List<Product>, List<ProductRepresentation>>(products!);

            return result;
        }
    }
}
