namespace MoveFunction.Core
{
    public class MovingANestedFunctionToTopLevelExample
    {
        public static OrderSummary CalculateOrderSummary(Product[] products)
        {
            double averagePrice = TotalPrice(products) / products.Length;

            return new OrderSummary(averagePrice, TotalPrice(products));
        }

        private static double TotalPrice(Product[] products)
        {
            double result = 0;
            foreach (Product product in products)
            {
                result += SinglePrice(product);
            }

            return result;
        }

        private static double SinglePrice(Product product)
        {
            if (product.Price > 5000)
            {
                return product.Price * 0.85;
            }

            return product.Price * 0.95;
        }
    }
}
