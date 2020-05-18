using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace SolidHappiness.Controllers.Products.GetProduct
{
    public class GetProductRequestDto : IRequest<GetProductResponseDto>
    {
        [FromRoute(Name = "{id}")]
        public Guid PublicId { get; set; }
    }
}