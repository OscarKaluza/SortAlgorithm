using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    public class Data
    {
        public List<Product> Products { get; set; }
        public List<Product> GetProducts()
        {
            Products = new List<Product>();

            Products.Add(new Product
            {
                Name = "Product1",
                Price = 1000
            });

            Products.Add(new Product
            {
                Name = "Product2",
                Price = 750
            });

            Products.Add(new Product
            {
                Name = "Product3",
                Price = 300
            });

            Products.Add(new Product
            {
                Name = "Product4",
                Price = 55
            });

            Products.Add(new Product
            {
                Name = "Product5",
                Price = 1000
            });

            return Products;
        }

    }
}
