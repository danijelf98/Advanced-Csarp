using Linq_14._Exercise.Model;

namespace Linq_14._Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //make 2 lists, one for Products, and the other one for Warehouse Products
            //make anonym. data type which connects 2 lists

            List<Product> products = new List<Product>()
            {
                new Product() { Name = "Laptop", Quantity = 2, ProductNumber = 1, ProductType = ProductType.Tech },
                new Product() { Name = "Monitor", Quantity = 1, ProductNumber = 4, ProductType = ProductType.Tech },

                new Product() { Name = "Bread", Quantity = 5, ProductNumber = 7508, ProductType = ProductType.BakeryProducts },
                new Product() { Name = "Croissant", Quantity = 15, ProductNumber = 15, ProductType = ProductType.BakeryProducts },

                new Product() { Name = "Mr.Muscle", Quantity = 3, ProductNumber = 2, ProductType = ProductType.Detergent },
                new Product() { Name = "Likvi", Quantity = 0, ProductNumber = 9, ProductType = ProductType.Detergent },
            };

            List<WarehouseProduct> warehouseProducts = new List<WarehouseProduct>()
            {
                new WarehouseProduct() { Name = "Laptop", Quantity = 2, ProductId = 1, ProductType = ProductType.Tech },
                new WarehouseProduct() { Name = "Monitor", Quantity = 1, ProductId = 4, ProductType = ProductType.Tech },

                new WarehouseProduct() { Name = "Bread", Quantity = 5, ProductId = 7508, ProductType = ProductType.BakeryProducts },
                new WarehouseProduct() { Name = "Croissant", Quantity = 15, ProductId = 15, ProductType = ProductType.BakeryProducts },

                new WarehouseProduct() { Name = "Mr.Muscle", Quantity = 3, ProductId = 2, ProductType = ProductType.Detergent },
                new WarehouseProduct() { Name = "Likvi", Quantity = 0, ProductId = 9, ProductType = ProductType.Detergent },
            };

            var joinedProducts = from p in products
                                 join wp in warehouseProducts
                                 on p.ProductNumber equals wp.ProductId
                                 select new
                                 {
                                     Name = p.Name,
                                     Type = p.ProductType,
                                     ProductNum = wp.ProductId,
                                 };

            foreach (var item in joinedProducts)
            {
                Console.WriteLine(item);
            }
        }
    }
}
