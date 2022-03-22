using System.Collections.Generic;
using System.Linq;

namespace RDVWQ.Core
{
    public class ASimpleExample
    {
        private List<Product> _products = new List<Product>();

        public int Credit
        {
            get
            {
                return _products.Sum(x => x.ShoppingCredit);
            }
        }

        public void AddCreditAfterShopping(Product product)
        {
            _products.Add(product);
        }
    }
}
