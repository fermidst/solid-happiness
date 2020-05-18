using System;

namespace SolidHappiness.Controllers.Products.GetProduct
{
    public class GetProductResponseDto
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }
    }
}