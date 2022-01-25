using System.Collections.Generic;
using System.Linq;

namespace IPO.Core
{
    public class ChangeFunctionDeclarationExample
    {
        public static List<Pig> PigsOutsideRange(StockFarm stockFarm, int min, int max)
        {
            return stockFarm.Pigs
                .Where(p => p.Weight < min || p.Weight > max).ToList();
        }
    }
}
