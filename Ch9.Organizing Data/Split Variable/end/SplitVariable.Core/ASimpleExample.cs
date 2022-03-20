using System.Linq;

namespace SplitVariable.Core
{
    public class ASimpleExample
    {
        public static double Discount(Order order)
        {
            double result;
            double discount = order.Coupon + order.HolidaySurprise;
            result = discount * order.Products.Count * 0.25;

            double allPrice = order.Products.Sum(x => x.Price);
            if (allPrice > 2000)
            {
                discount = allPrice * 0.1;
                result += discount;
            }

            return result;
        }
    }
}
