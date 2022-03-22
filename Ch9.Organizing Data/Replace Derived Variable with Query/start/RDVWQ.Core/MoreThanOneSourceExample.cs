using System.Collections.Generic;
using System.Linq;

namespace RDVWQ.Core
{
    public class MoreThanOneSourceExample
    {
        private int _credit;
        private List<Product> _products = new List<Product>();
        private int _initialCredit;

        public MoreThanOneSourceExample(int credit)
        {
            _initialCredit = credit;
            _credit = credit;
            _products = new List<Product>();
        }


        public int Credit => _initialCredit + CalculatedCreditAccumulator;

        public int CalculatedCreditAccumulator => _products.Sum(x => x.ShoppingCredit);

        public void AddCreditAfterShopping(Product product)
        {
            _products.Add(product);
        }
    }

}
