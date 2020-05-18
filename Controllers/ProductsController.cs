using System.Collections.Generic;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SolidHappiness.Configs;
using SolidHappiness.Controllers.Products.GetProducts;

namespace SolidHappiness.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IOptions<FirestoreConfig> _options;

        public ProductsController(IMediator mediator, IOptions<FirestoreConfig> options)
        {
            _mediator = mediator;
            _options = options;
        }

        [HttpPost]
        public async Task AddProducts()
        {
            var firestore = await FirestoreDb.CreateAsync(_options.Value.ProjectId);
            var document = firestore.Collection("products").Document();
            var product = new Dictionary<string, object>
            {
                {"description", ""},
                {"image", ""},
                {"name", ""},
                {"price", 0}
            };
            await document.SetAsync(product);
        }

        [HttpGet]
        public async Task<GetProductsResponseDto> GetProducts([FromRoute] GetProductsRequestDto request)
        {
            return await _mediator.Send(request);
        }
    }
}