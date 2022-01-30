using System;

namespace SplitPhase.Core
{
    public class HuntingMonsterExample
    {
        public static double GetExperience(Monster monster, int huntingCount, GuildAward guildAward)
        {
            double baseExperience = monster.BaseExperience * huntingCount;
            double bonusExperience = Math.Max(huntingCount - monster.BonusExperienceHuntingCount, 0)
                                     * monster.BaseExperience * monster.BonusExperienceRate;
            double guildAwardPerMonster = (baseExperience > guildAward.BonusExperienceThreshold)
                ? guildAward.HighExperiencePerMonster : guildAward.NormalExperiencePerMonster;
            double guildExperience = huntingCount * guildAwardPerMonster;
            double experience = baseExperience + bonusExperience + guildExperience;
            return experience;
        }
    }
}
