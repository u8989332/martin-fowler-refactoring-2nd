using System;
using System.Collections.Generic;
using System.Linq;

namespace RCWP.Core
{
    public class UsingPolymorphismForVariationExample
    {
        public static string RatingRestaurant(Restaurant restaurant, List<Shareholder> shareholders)
        {
            int restaurantProfit = CalculateRestaurantProfit(restaurant, shareholders);
            int restaurantRisk = CalculateRestaurantRisk(restaurant);
            int shareholderRisk = CalculateShareholderRisk(restaurant, shareholders);
            if (restaurantProfit * 2 > (restaurantRisk + shareholderRisk * 3))
            {
                return "A";
            }

            return "B";
        }

        private static int CalculateShareholderRisk(Restaurant restaurant, List<Shareholder> shareholders)
        {
            int result = 1;
            if (shareholders.Count < 3)
            {
                result += 3;
            }

            result += shareholders.Count(x => x.Reputation < 2);

            if (restaurant.City == "Nantou City" && LiveInNantouCity(shareholders))
            {
                result -= 2;
            }

            return Math.Max(result, 0);
        }

        private static bool LiveInNantouCity(List<Shareholder> shareholders)
        {
            return shareholders.Any(x => x.LiveCity == "Nantou City");
        }

        private static int CalculateRestaurantRisk(Restaurant restaurant)
        {
            int result = 1;
            if (restaurant.TableSize > 20)
            {
                result += 3;
            }

            if (restaurant.TableSize > 40)
            {
                result += restaurant.TableSize - 40;
            }

            if (new[] { "Nantou City", "Chiayi City" }.Contains(restaurant.City))
            {
                result += 4;
            }

            return result;
        }

        private static int CalculateRestaurantProfit(Restaurant restaurant, List<Shareholder> shareholders)
        {
            int result = 2;
            if (restaurant.City == "Nantou City")
            {
                result += 1;
            }

            if (restaurant.City == "Chiayi City")
            {
                result += 1;
            }

            if (restaurant.City == "Nantou City" && LiveInNantouCity(shareholders))
            {
                result += 4;
                if (shareholders.Count > 5)
                {
                    result += 2;
                }

                if (restaurant.TableSize > 15)
                {
                    result += 1;
                }

                if (restaurant.TableSize > 30)
                {
                    result -= 1;
                }
            }
            else
            {
                if (shareholders.Count > 4)
                {
                    result += 2;
                }

                if (restaurant.TableSize > 20)
                {
                    result -= 1;
                }
            }

            return result;
        }
    }
}
