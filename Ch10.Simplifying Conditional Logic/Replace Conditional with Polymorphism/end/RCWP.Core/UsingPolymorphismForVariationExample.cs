using System.Collections.Generic;
using System.Linq;

namespace RCWP.Core
{
    public class UsingPolymorphismForVariationExample
    {
        public static string RatingRestaurant(Restaurant restaurant, List<Shareholder> shareholders)
        {
            return CreateRating(restaurant, shareholders).Value;
        }

        private static RestaurantRating CreateRating(Restaurant restaurant, List<Shareholder> shareholders)
        {
            if (restaurant.City == "Nantou City" && shareholders.Any(x => x.LiveCity == "Nantou City"))
            {
                return new NantouRating(restaurant, shareholders);
            }

            return new RestaurantRating(restaurant, shareholders);
        }
    }
}
