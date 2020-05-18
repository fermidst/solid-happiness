using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SolidHappiness.Controllers.Products.GetProduct;
using SolidHappiness.Controllers.Products.GetProducts;

namespace SolidHappiness.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<GetProductsResponseDto> GetProducts([FromRoute] GetProductsRequestDto request)
        {
            return await _mediator.Send(request);
        }

        [HttpGet("{id}")]
        public async Task<GetProductResponseDto> GetProduct([FromRoute] GetProductRequestDto request)
        {
            return await _mediator.Send(request);
        }
    }
}