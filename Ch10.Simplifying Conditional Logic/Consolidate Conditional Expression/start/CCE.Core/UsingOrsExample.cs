namespace CCE.Core
{
    public class UsingOrsExample
    {
        public static double Discount(Product product)
        {
            if (product.Type == ProductType.NonDiscount)
            {
                return 0;
            }

            if (product.Price > 5000)
            {
                return 0;
            }

            if (product.IsExpired)
            {
                return 0;
            }

            return product.Price * 0.05;
        }
    }
}