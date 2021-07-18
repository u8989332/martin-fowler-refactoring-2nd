using System;
using System.Collections.Generic;
using System.Linq;

namespace RPGGame.Core
{
    internal class StatementDataManager
    {
        public StatementData CreateStatementData(HuntingMission mission, Dictionary<string, Monster> monsters)
        {
            Func<HuntingTarget, Monster> monsterFor = delegate (HuntingTarget missionTarget)
            {
                return monsters[missionTarget.MonsterId];
            };

            Func<HuntingTarget, CalculatedTarget> enrichTarget = delegate (HuntingTarget target)
            {
                var calculator = CreateHuntingTargetCalculator(target, monsterFor(target));
                CalculatedTarget result = new CalculatedTarget(target.MonsterId, target.Level);
                result.Monster = calculator.Monster;
                result.Amount = calculator.Amount;
                result.Experience = calculator.Experience;
                return result;
            };

            Func<StatementData, int> totalExperiences = delegate (StatementData data)
            {
                return data.Targets.Sum(x => x.Experience);
            };

            Func<StatementData, int> totalBonuses = delegate (StatementData data)
            {
                return data.Targets.Sum(x => x.Amount);
            };

            StatementData statementData = new StatementData();
            statementData.MissionName = mission.Name;
            statementData.Targets = mission.Targets.Select(enrichTarget).ToList();
            statementData.TotalBonuses = totalBonuses(statementData);
            statementData.TotalExperiences = totalExperiences(statementData);

            return statementData;
        }

        private HuntingTargetCalculator CreateHuntingTargetCalculator(HuntingTarget target, Monster monster)
        {
            switch (monster.Type)
            {
                case "giant":
                    return new GiantTargetCalculator(target, monster);
                case "dragon":
                    return new DragonTargetCalculator(target, monster);
                default:
                    throw new ApplicationException($"Unknown type: {monster.Type}");
            }
        }
    }

    internal class DragonTargetCalculator : HuntingTargetCalculator
    {
        public DragonTargetCalculator(HuntingTarget target, Monster monster) : base(target, monster)
        {
        }

        public override int Amount
        {
            get
            {
                int result = 80000;
                if (_target.Level > 35)
                {
                    result += 2500 + 900 * (_target.Level - 35);
                }
                result += 200 * _target.Level;

                return result;
            }
        }

        public override int Experience
        {
            get
            {
                return base.Experience + _target.Level / 3;
            }
        }
    }

    internal class GiantTargetCalculator : HuntingTargetCalculator
    {
        public GiantTargetCalculator(HuntingTarget target, Monster monster) : base(target, monster)
        {
        }

        public override int Amount
        {
            get
            {
                int result = 60000;
                if (_target.Level > 25)
                {
                    result += 500 * (_target.Level - 25);
                }

                return result;
            }
        }
    }

    internal abstract class HuntingTargetCalculator
    {
        protected readonly HuntingTarget _target;
        public Monster Monster { get; }

        public abstract int Amount { get; }

        public virtual int Experience
        {
            get
            {
                int result = 0;
                result += Math.Max(_target.Level - 40, 0);
                return result;
            }
        }

        protected HuntingTargetCalculator(HuntingTarget target, Monster monster)
        {
            _target = target;
            Monster = monster;
        }
    }
}
