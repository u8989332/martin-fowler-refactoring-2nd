using System.Collections.Generic;

namespace EncapsulateCollection.Core
{
    public class Order
    {
        public string Name { get; set; }
        public Order(string name)
        {
            Name = name;
            Products = new List<Product>();
        }

        public List<Product> Products { get; set; }
    }
}
