using MediatR;

namespace SolidHappiness.Controllers.Products.GetProducts
{
    public class GetProductsRequestDto : IRequest<GetProductsResponseDto>
    {
    }
}