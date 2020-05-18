using System.Collections.Generic;

namespace SolidHappiness.Controllers.Products.GetProducts
{
    public class GetProductsResponseDto
    {
        public ICollection<ProductDto> Products { get; set; }
    }
}