using System.Collections.Generic;

namespace IPO.Core
{
    public class StockFarm
    {
        public string Name { get; set; }
        public List<Pig> Pigs { get; set; } = new List<Pig>();
    }
}