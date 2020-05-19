using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using MediatR;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SolidHappiness.Configs;

namespace SolidHappiness.Controllers.Products.GetProducts
{
    public class GetProductsHandler : IRequestHandler<GetProductsRequestDto, GetProductsResponseDto>
    {
        private readonly ILogger<GetProductsHandler> _logger;
        private readonly IOptions<FirestoreConfig> _options;

        public GetProductsHandler(IOptions<FirestoreConfig> options, ILogger<GetProductsHandler> logger)
        {
            _options = options;
            _logger = logger;
        }

        public async Task<GetProductsResponseDto> Handle(GetProductsRequestDto request,
            CancellationToken cancellationToken)
        {
            _logger.Log(LogLevel.Critical, $"get products handler invoked at {DateTime.UtcNow}");
            var firestore = await FirestoreDb.CreateAsync(_options.Value.ProjectId);
            var collection = await firestore.Collection("products").GetSnapshotAsync(cancellationToken);
            return new GetProductsResponseDto
            {
                Products = (from document in collection.Documents
                    let dictionary = document.ToDictionary()
                    select new ProductDto
                    {
                        Id = document.Id,
                        Name = dictionary["name"].ToString(),
                        Price = Convert.ToDecimal(dictionary["price"]),
                        Image = dictionary["image"].ToString(),
                        Description = dictionary["description"].ToString()
                    }).ToList()
            };
        }
    }
}