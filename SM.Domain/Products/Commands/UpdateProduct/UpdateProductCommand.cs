using MediatR;
using SM.Domain.DTOs;

namespace SM.Domain.Products.Commands.UpdateProduct
{
    public class UpdateProductCommand : IRequest<ProductRepresentation>
    {
        public string SerialNumber { get; set; } = string.Empty;
        public double Price { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
