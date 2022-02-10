using System;
using System.Collections.Generic;

namespace EncapsulateCollection.Core
{
    public class Order
    {
        private string _name;
        private List<Product> _products;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public Order(string name)
        {
            Name = name;
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            int index = _products.IndexOf(product);
            if (index == -1)
            {
                throw new ArgumentOutOfRangeException(nameof(product) + " is not found");
            }
            else
            {
                _products.RemoveAt(index);
            }
        }

        public List<Product> Products
        {
            get => new List<Product>(_products);
            set => _products = new List<Product>(value);
        }
    }
}
