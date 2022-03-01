namespace MoveFunction.Core
{
    public class MovingANestedFunctionToTopLevelExample
    {
        public static OrderSummary CalculateOrderSummary(Product[] products)
        {
            double totalPrice = CalculatePrice();
            double averagePrice = totalPrice / products.Length;

            return new OrderSummary(averagePrice, totalPrice);


            double CalculatePrice()
            {
                double result = 0;
                foreach (Product product in products)
                {
                    result += SinglePrice(product);
                }

                return result;
            }

            double SinglePrice(Product product)
            {
                if (product.Price > 5000)
                {
                    return product.Price * 0.85;
                }

                return product.Price * 0.95;
            }
        }
    }
}
