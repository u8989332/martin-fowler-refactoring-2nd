using System.Collections.Generic;

namespace CFD.Core
{
    public class AddingAParameterExample
    {
        private static List<Product> _shoppingCard = new List<Product>();

        public static void AddShoppingCart(Product product)
        {
            _shoppingCard.Add(product);
        }
    }
}
