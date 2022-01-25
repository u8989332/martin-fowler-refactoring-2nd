using System.Collections.Generic;
using System.Linq;

namespace IPO.Core
{
    public class ChangeFunctionDeclarationExample
    {
        public static List<Pig> PigsOutsideRange(StockFarm stockFarm, WeightRange range)
        {
            return stockFarm.Pigs
                .Where(p => !range.Contains(p.Weight)).ToList();
        }
    }
}
