using MediatR;
using SM.Domain.DTOs;

namespace SM.Domain.Products.Queries.GetAllProducts
{
    public class GetAllProductsQuery : IRequest<List<ProductRepresentation>>
    {
    }
}
