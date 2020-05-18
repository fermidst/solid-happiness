using System;

namespace SolidHappiness.Controllers.Products.GetProducts
{
    public class ProductDto
    {
        public Guid PublicId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }
    }
}