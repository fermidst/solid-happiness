using System;

namespace SolidHappiness.Controllers.Products.GetProduct
{
    public class GetProductResponseDto
    {
        public Guid PublicId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        public Guid CategoryPublicId { get; set; }
    }
}