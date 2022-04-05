using System;
using System.Collections.Generic;
using System.Linq;

namespace RCWP.Core
{
    internal class RestaurantRating
    {
        protected readonly Restaurant Restaurant;
        protected readonly List<Shareholder> Shareholders;

        public RestaurantRating(Restaurant restaurant, List<Shareholder> shareholders)
        {
            Restaurant = restaurant;
            Shareholders = shareholders;
        }

        public string Value
        {
            get
            {
                int restaurantProfit = CalculateRestaurantProfit();
                int restaurantRisk = CalculateRestaurantRisk();
                int shareholderRisk = CalculateShareholderRisk();
                if (restaurantProfit * 2 > (restaurantRisk + shareholderRisk * 3))
                {
                    return "A";
                }

                return "B";
            }
        }

        protected virtual int CalculateShareholderRisk()
        {
            int result = 1;
            if (Shareholders.Count < 3)
            {
                result += 3;
            }

            result += Shareholders.Count(x => x.Reputation < 2);
            return Math.Max(result, 0);
        }

        private int CalculateRestaurantRisk()
        {
            int result = 1;
            if (Restaurant.TableSize > 20)
            {
                result += 3;
            }

            if (Restaurant.TableSize > 40)
            {
                result += Restaurant.TableSize - 40;
            }

            if (new[] { "Nantou City", "Chiayi City" }.Contains(Restaurant.City))
            {
                result += 4;
            }

            return result;
        }

        protected virtual int CalculateRestaurantProfit()
        {
            int result = 2;
            if (Restaurant.City == "Nantou City")
            {
                result += 1;
            }

            if (Restaurant.City == "Chiayi City")
            {
                result += 1;
            }

            result += RestaurantProfitFactor;
            result += ShareholdersProfitFactor;

            return result;
        }

        protected virtual int RestaurantProfitFactor
        {
            get
            {
                int result = 0;
                if (Shareholders.Count > 4)
                {
                    result += 2;
                }

                if (Restaurant.TableSize > 20)
                {
                    result -= 1;
                }

                return result;
            }
        }

        protected virtual int ShareholdersProfitFactor => (Shareholders.Count > 4) ? 2 : 0;
    }
}