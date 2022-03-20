using System.Linq;

namespace SplitVariable.Core
{
    public class ASimpleExample
    {
        public static double Discount(Order order)
        {
            double result;
            double firstDiscount = order.Coupon + order.HolidaySurprise;
            result = firstDiscount * order.Products.Count * 0.25;

            double allPrice = order.Products.Sum(x => x.Price);
            if (allPrice > 2000)
            {
                double secondDiscount = allPrice * 0.1;
                result += secondDiscount;
            }

            return result;
        }
    }
}
