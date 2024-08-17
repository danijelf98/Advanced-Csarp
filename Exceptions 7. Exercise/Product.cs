using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_7._Exercise
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>()
            {
                
                new Product
                {
                    Name = string.Empty,
                    Price = 35,
                    Quantity = 1,
                    Description = "Long Description"
                },
                new Product
                {
                    Name = "Product 2",
                    Quantity = 1,
                    Description = "Long Description"
                },
                new Product
                {
                    Name = "Product 3",
                    Price = 35,
                    Quantity = 0,
                    Description = "Long Description 2"
                },
                new Product
                {
                    Name = "Product 4",
                    Price = 35,
                    Quantity = 1,
                    Description = "Veeeeeeeery Loooooooooong Descriptiooooooooooon"
                }
            };
            foreach (var product in products)
            {
                    if (string.IsNullOrEmpty(product.Name))
                    {
                        throw new Exception("Product Name not Entered");
                    }
                    if (product.Price == default)
                    {
                        throw new PriceIsNullOrZero("Price is null or empty!!");
                    }
                    if (product.Quantity < 1)
                    {
                        throw new ThereIsNoItemInProducts("Product quantity is 0");
                    }
                    if (product.Description.Length > 50)
                    {
                        throw new DescriptionIsTooLong(product.Description.Length);
                    }
            }
            return products;
        }
    }
}
