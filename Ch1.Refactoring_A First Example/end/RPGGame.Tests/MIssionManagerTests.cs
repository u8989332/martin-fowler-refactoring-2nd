using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using RPGGame.Core;

namespace RPGGame.Tests
{
    public class MIssionManagerTests
    {
        [Test]
        public void Given_Mission_Monsters_Should_Return_Correct_Statement()
        {
            // arrange
            Dictionary<string, Monster> monsters = new Dictionary<string, Monster>();
            monsters.Add("fire_giant", new Monster("Fire Giant", "giant"));
            monsters.Add("stone_giant", new Monster("Stone Giant", "giant"));
            monsters.Add("bone_dragon", new Monster("Bone Dragon", "dragon"));

            HuntingMission mission = new HuntingMission("Giant & Dragon Hunting", new List<HuntingTarget>(new[]
            {
                new HuntingTarget("fire_giant", 55),
                new HuntingTarget("bone_dragon", 40),
                new HuntingTarget("stone_giant", 61)
            }));

            List<HuntingMission> missions = new List<HuntingMission>(new[] { mission });

            // act
            string result = new MissionManager().Statement(missions.First(), monsters);

            // assert
            Assert.AreEqual(
                "Statement for Giant & Dragon Hunting\nFire Giant: $750.00 (55 levels)\nBone Dragon: $950.00 (40 levels)\nStone Giant: $780.00 (61 levels)\nBonus was $2,480.00\nYou got 49 experiences\n", 
                result);
        }

        [Test]
        public void Given_Mission_Monsters_Should_Return_Correct_HtmlStatement()
        {
            // arrange
            Dictionary<string, Monster> monsters = new Dictionary<string, Monster>();
            monsters.Add("fire_giant", new Monster("Fire Giant", "giant"));
            monsters.Add("stone_giant", new Monster("Stone Giant", "giant"));
            monsters.Add("bone_dragon", new Monster("Bone Dragon", "dragon"));

            HuntingMission mission = new HuntingMission("Giant & Dragon Hunting", new List<HuntingTarget>(new[]
            {
                new HuntingTarget("fire_giant", 55),
                new HuntingTarget("bone_dragon", 40),
                new HuntingTarget("stone_giant", 61)
            }));

            List<HuntingMission> missions = new List<HuntingMission>(new[] { mission });

            // act
            string result = new MissionManager().HtmlStatement(missions.First(), monsters);

            // assert
            Assert.AreEqual(
                "<h1>Statement for Giant & Dragon Hunting</h1>\n<table>\n<tr><th>Monster Name</th><th>Bonus</th><th>Level</th></tr><tr><td>Fire Giant</td><td>$750.00</td><td>55</td></tr>\n<tr><td>Bone Dragon</td><td>$950.00</td><td>40</td></tr>\n<tr><td>Stone Giant</td><td>$780.00</td><td>61</td></tr>\n</table>\n<p>Bonus was <em>$2,480.00</em></p>\n<p>You got <em>49</em> experiences</p>\n",
                result);
        }
    }
}