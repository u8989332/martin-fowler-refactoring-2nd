namespace CCE.Core
{
    public class UsingOrsExample
    {
        public static double Discount(Product product)
        {
            if (NotDiscountProduct(product))
            {
                return 0;
            }

            return product.Price * 0.05;
        }

        private static bool NotDiscountProduct(Product product)
        {
            return product.Type == ProductType.NonDiscount || product.Price > 5000 || product.IsExpired;
        }
    }
}