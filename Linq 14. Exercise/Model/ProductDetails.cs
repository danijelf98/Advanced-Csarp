using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_14._Exercise.Model
{
    public class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int ProductNumber { get; set; }
        public ProductType ProductType { get; set; }
    }
    public class WarehouseProduct
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public ProductType ProductType { get; set; }
    }

    public enum ProductType
    {
        Tech,
        BakeryProducts,
        Detergent
    }

}
