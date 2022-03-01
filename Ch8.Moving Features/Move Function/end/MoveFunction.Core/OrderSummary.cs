namespace MoveFunction.Core
{
    public class OrderSummary
    {
        public OrderSummary(double averagePrice, double totalPrice)
        {
            AveragePrice = averagePrice;
            TotalPrice = totalPrice;
        }

        public double TotalPrice { get; }
        public double AveragePrice { get; }
    }
}