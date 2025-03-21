using MediatR;
using Microsoft.AspNetCore.Mvc;
using SM.Api.Requests.ProductRequests;
using SM.Domain.DTOs;
using SM.Domain.Products.Commands.AddProduct;
using SM.Domain.Products.Commands.DeleteProduct;
using SM.Domain.Products.Commands.UpdateProduct;
using SM.Domain.Products.Queries.GetAllProducts;

namespace SM.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> AddProduct(AddProductRequest request)
        {
            await _mediator.Send(new AddProductCommand
            {
                Name = request.Name,
                Price = request.Price,
                SerialNumber = request.SerialNumber,
            });
            return Ok();
        }

        [HttpDelete]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> DeleteProduct(DeleteProductRequest request)
        {
            await _mediator.Send(new DeleteProductCommand
            {
                SerialNumber = request.SerialNumber
            });
            return Ok();
        }

        [HttpPatch]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> UpdateProduct(UpdateProductRequest request)
        {
            await _mediator.Send(new UpdateProductCommand
            {
                SerialNumber = request.SerialNumber
            });
            return Ok();
        }


        [HttpGet]
        [ProducesResponseType(typeof(List<ProductRepresentation>), StatusCodes.Status200OK)]
        public async Task<List<ProductRepresentation>> GetAllProducts()
        {
            var result = await _mediator.Send(new GetAllProductsQuery());

            return result;
        }

    }
}
