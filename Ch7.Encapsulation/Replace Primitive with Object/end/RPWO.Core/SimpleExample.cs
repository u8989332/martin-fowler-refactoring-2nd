using System.Collections.Generic;
using System.Linq;

namespace RPWO.Core
{
    public class SimpleExample
    {
        private static List<Player> _players = new List<Player>()
        {
            new Player("P1", new Guild() {Level = "C"}),
            new Player("P2", new Guild() {Level = "A"}),
            new Player("P3", new Guild() {Level = "B"}),
            new Player("P4", new Guild() {Level = "S"}),
        };

        public static int GetHighLevelPlayers()
        {
            return _players.Count(x => x.Level.HigherThan(new Level("B")));
        }
    }
}
