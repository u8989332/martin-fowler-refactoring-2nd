using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace RPGGame.Core
{
    public class MissionManager
    {
        public string Statement(HuntingMission mission, Dictionary<string, Monster> monsters)
        {
            return RenderPlainText(new StatementDataManager().CreateStatementData(mission, monsters));
        }

        public string HtmlStatement(HuntingMission mission, Dictionary<string, Monster> monsters)
        {
            return RenderHtml(new StatementDataManager().CreateStatementData(mission, monsters));
        }

        private string RenderHtml(StatementData data)
        {
            string result = $"<h1>Statement for {data.MissionName}</h1>\n";
            result += $"<table>\n";
            result += $"<tr><th>Monster Name</th><th>Bonus</th><th>Level</th></tr>";
            foreach (var missionTarget in data.Targets)
            {
                result +=
                    $"<tr><td>{missionTarget.Monster.Name}</td><td>{Usd(missionTarget.Amount)}</td>";
                result += $"<td>{missionTarget.Level}</td></tr>\n";
            }
            result += $"</table>\n";
            result += $"<p>Bonus was <em>{Usd(data.TotalBonuses)}</em></p>\n";
            result += $"<p>You got <em>{data.TotalExperiences}</em> experiences</p>\n";
            return result;
        }


        private string RenderPlainText(StatementData data)
        {
            string result = $"Statement for {data.MissionName}\n";
            foreach (var missionTarget in data.Targets)
            {
                result +=
                    $"{missionTarget.Monster.Name}: {Usd(missionTarget.Amount)} ({missionTarget.Level} levels)\n";
            }

            result += $"Bonus was {Usd(data.TotalBonuses)}\n";
            result += $"You got {data.TotalExperiences} experiences\n";

            return result;
        }

        private string Usd(int aNumber)
        {
            CultureInfo enCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = enCulture;
            NumberFormatInfo localFormat = (NumberFormatInfo)NumberFormatInfo.CurrentInfo.Clone();
            return (aNumber / 100).ToString("c", localFormat);
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

    internal class StatementData
    {
        public string MissionName { get; set; }
        public List<CalculatedTarget> Targets { get; set; }
        public int TotalBonuses { get; set; }
        public int TotalExperiences { get; set; }
    }

    internal class CalculatedTarget
    {
        public string MonsterId { get; }
        public int Level { get; }
        public Monster Monster { get; set; }
        public int Amount { get; set; }
        public int Experience { get; set; }

        public CalculatedTarget(string monsterId, int level)
        {
            MonsterId = monsterId;
            Level = level;
        }
    }
}
