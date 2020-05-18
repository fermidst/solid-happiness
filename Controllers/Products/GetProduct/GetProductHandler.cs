using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace SolidHappiness.Controllers.Products.GetProduct
{
    public class GetProductHandler : IRequestHandler<GetProductRequestDto, GetProductResponseDto>
    {
        public async Task<GetProductResponseDto> Handle(GetProductRequestDto request,
            CancellationToken cancellationToken)
        {
            return new GetProductResponseDto
            {
                Name = "name1",
                Description = "desc1",
                CategoryPublicId = Guid.NewGuid(),
                Image = "image1",
                Price = 111,
                PublicId = Guid.NewGuid()
            };
        }
    }
}