using MediatR;
using SM.Domain.DTOs;

namespace SM.Domain.Products.Commands.DeleteProduct
{
    public class DeleteProductCommand : IRequest<ProductRepresentation>
    {
        public string SerialNumber { get; set; } = string.Empty;
    }
}
