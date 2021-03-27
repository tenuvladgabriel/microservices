using System.Collections.Generic;
using Shopping.Client.Models;

namespace Shopping.Client.Data
{
    public static class ProductContext
    {
        public static readonly List<Product> Products = new List<Product>()
        {
            new Product
            {
                Name = "Iphone X",
                Description = "This is the best iphone",
                ImageFile = "product-1.png",
                Price = 950.00M,
                Category = "Smart Phone"
            },
            new Product
            {
                Name = "Samsung 20",
                Description = "This is the best samsung",
                ImageFile = "product-2.png",
                Price = 840.00M,
                Category = "Smart Phone"
            },
            new Product
            {
                Name = "Huawei Plus",
                Description = "This is the best huawei",
                ImageFile = "product-3.png",
                Price = 650.00M,
                Category = "White Appliances"
            },
            new Product
            {
                Name = "Nokia 8",
                Description = "This is the best nokia",
                ImageFile = "product-4.png",
                Price = 550.00M,
                Category = "White Appliances"
            },
            new Product
            {
                Name = "Xiaomi Mi 9",
                Description = "This is the best xiaomi",
                ImageFile = "product-5.png",
                Price = 450.00M,
                Category = "Smart Phone"
            },
            new Product
            {
                Name = "HTC U11+",
                Description = "This is the best htc",
                ImageFile = "product-5.png",
                Price = 450.00M,
                Category = "Smart Phone"
            },
            new Product
            {
                Name = "LG G9",
                Description = "This is the best lg",
                ImageFile = "product-6.png",
                Price = 350.00M,
                Category = "Home Kitchen"
            }
        };
    }
}