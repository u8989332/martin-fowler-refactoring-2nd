using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace RPGGame.Core
{
    public class MissionManager
    {
        public string Statement(HuntingMission mission, Dictionary<string, Monster> monsters)
        {
            int totalExperience = 0;
            int totalBonus = 0;
            string result = $"Statement for {mission.Name}\n";
            CultureInfo enCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = enCulture;
            NumberFormatInfo localFormat = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();

            foreach (var missionTarget in mission.Targets)
            {
                var monster = monsters[missionTarget.MonsterId];
                int thisBonus = 0;

                switch (monster.Type)
                {
                    case "giant":
                        thisBonus = 60000;
                        if (missionTarget.Level > 25)
                        {
                            thisBonus += 500 * (missionTarget.Level - 25);
                        }

                        break;
                    case "dragon":
                        thisBonus = 80000;
                        if (missionTarget.Level > 35)
                        {
                            thisBonus += 2500 + 900 * (missionTarget.Level - 35);
                        }

                        thisBonus += 200 * missionTarget.Level;
                        break;
                    default:
                        throw new Exception($"Unknown type: {monster.Type}");
                }

                // add experience
                totalExperience += Math.Max(missionTarget.Level - 40, 0);

                // add extra experience for every dragon monster by level dividing by 3
                if (monster.Type == "dragon")
                {
                    totalExperience += missionTarget.Level / 3;
                }

                result +=
                    $"{monster.Name}: {(thisBonus / 100).ToString("c", localFormat)} ({missionTarget.Level} levels)\n";
                totalBonus += thisBonus;
            }

            result += $"Bonus was {(totalBonus / 100).ToString("c", localFormat)}\n";
            result += $"You got {totalExperience} experiences\n";

            return result;
        }
    }

    public class HuntingMission
    {
        public string Name { get; }
        public List<HuntingTarget> Targets { get; }
        public HuntingMission(string name, List<HuntingTarget> targets)
        {
            Name = name;
            Targets = targets;
        }
    }

    public class HuntingTarget
    {
        public string MonsterId { get; }
        public int Level { get; }
        public HuntingTarget(string monsterId, int level)
        {
            MonsterId = monsterId;
            Level = level;
        }
    }

    public class Monster
    {
        public string Name { get; }
        public string Type { get; }
        public Monster(string name, string type)
        {
            Name = name;
            Type = type;
        }
    }
}
