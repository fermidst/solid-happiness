using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace SolidHappiness.Controllers.Products.GetProducts
{
    public class GetProductsHandler : IRequestHandler<GetProductsRequestDto, GetProductsResponseDto>
    {
        public async Task<GetProductsResponseDto> Handle(GetProductsRequestDto request,
            CancellationToken cancellationToken)
        {
            return new GetProductsResponseDto
            {
                Products = new List<ProductDto>
                {
                    new ProductDto
                    {
                        PublicId = Guid.NewGuid(),
                        Description = "desc1",
                        Price = 100,
                        Image = string.Empty,
                        Name = "name1",
                    },
                    new ProductDto
                    {
                        PublicId = Guid.NewGuid(),
                        Description = "desc123",
                        Price = 200,
                        Image = string.Empty,
                        Name = "name12",
                    },
                    new ProductDto
                    {
                        PublicId = Guid.NewGuid(),
                        Description = "desc123",
                        Price = 300,
                        Image = string.Empty,
                        Name = "name123",
                    }
                }
            };
        }
    }
}