using System.Collections.Generic;
using System.Linq;

namespace EncapsulateCollection.Core
{
    public class SimpleExample
    {
        private static Order _order = new Order("Order 1")
        {
            Products = new List<Product>()
            {
                new Product("Product 1", 300),
                new Product("Product 2", 700),
                new Product("Product 3", 200),
                new Product("Product 4", 800),
            }
        };

        public static int GerHighPriceProductCount()
        {
            return _order.Products.Count(x => x.Price > 500);
        }

        public static void UpdateProducts()
        {
            _order.Products = new List<Product>()
            {
                new Product("New P 1", 600),
                new Product("New P 2", 400)
            };
        }

        public static void AddHighPriceProduct()
        {
            _order.Products.Add(new Product("High price product", 9999));
        }
    }
}
