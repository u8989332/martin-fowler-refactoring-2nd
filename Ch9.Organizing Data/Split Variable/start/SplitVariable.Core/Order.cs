using System.Collections.Generic;

namespace SplitVariable.Core
{
    public class Order
    {
        public Order(double coupon, double holidaySurprise, List<Product> products)
        {
            Coupon = coupon;
            HolidaySurprise = holidaySurprise;
            Products = products;
        }

        public double Coupon { get; }
        public double HolidaySurprise { get; }
        public List<Product> Products { get; }
    }
}