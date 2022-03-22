using System.Collections.Generic;

namespace RDVWQ.Core
{
    public class ASimpleExample
    {
        private int _credit;
        private List<Product> _products = new List<Product>();

        public int Credit => _credit;

        public void AddCreditAfterShopping(Product product)
        {
            _products.Add(product);
            _credit += product.ShoppingCredit;
        }
    }
}
