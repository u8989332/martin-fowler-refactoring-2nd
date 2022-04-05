using System;
using System.Collections.Generic;

namespace RCWP.Core
{
    internal class NantouRating : RestaurantRating
    {
        public NantouRating(Restaurant restaurant, List<Shareholder> shareholders) : base(restaurant, shareholders)
        {
        }

        protected override int CalculateShareholderRisk()
        {
            int result = base.CalculateShareholderRisk() - 2;
            return Math.Max(result, 0);
        }

        protected override int CalculateRestaurantProfit()
        {
            return base.CalculateRestaurantProfit() + 4;
        }

        protected override int RestaurantProfitFactor
        {
            get
            {
                int result = 0;
                if (Restaurant.TableSize > 15)
                {
                    result += 1;
                }

                if (Restaurant.TableSize > 30)
                {
                    result -= 1;
                }

                return result;
            }
        }

        protected override int ShareholdersProfitFactor => (Shareholders.Count > 5) ? 2 : 0;
    }
}