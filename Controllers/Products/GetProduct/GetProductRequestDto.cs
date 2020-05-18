using System;
using MediatR;

namespace SolidHappiness.Controllers.Products.GetProduct
{
    public class GetProductRequestDto : IRequest<GetProductResponseDto>
    {
        public Guid PublicId { get; set; }
    }
}