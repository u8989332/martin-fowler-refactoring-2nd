using System.Collections.Generic;
using System.Diagnostics;

namespace CFD.Core
{
    public class AddingAParameterExample
    {
        private static List<Product> _shoppingCard = new List<Product>();

        public static void AddShoppingCart(Product product)
        {
            Temp_AddSoppingCart(product, new User());
        }

        private static void Temp_AddSoppingCart(Product product, User user)
        {
            Debug.Assert(user != null);
            _shoppingCard.Add(product);
        }
    }
}
