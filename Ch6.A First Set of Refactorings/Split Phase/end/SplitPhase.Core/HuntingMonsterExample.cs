using System;

namespace SplitPhase.Core
{
    public class HuntingMonsterExample
    {
        public static double GetExperience(Monster monster, int huntingCount, GuildAward guildAward)
        {
            ExperienceData experienceData = CalculateExperience(monster, huntingCount);
            return ApplyGuildAward(experienceData, guildAward);
        }

        private static ExperienceData CalculateExperience(Monster monster, int huntingCount)
        {
            double baseExperience = monster.BaseExperience * huntingCount;
            double bonusExperience = Math.Max(huntingCount - monster.BonusExperienceHuntingCount, 0)
                                     * monster.BaseExperience * monster.BonusExperienceRate;

            return new ExperienceData()
            {
                BaseExperience = baseExperience,
                HuntingCount = huntingCount,
                BonusExperience = bonusExperience
            };
        }

        private static double ApplyGuildAward(
            ExperienceData experienceData,
            GuildAward guildAward)
        {
            double guildAwardPerMonster = (experienceData.BaseExperience > guildAward.BonusExperienceThreshold)
                ? guildAward.HighExperiencePerMonster : guildAward.NormalExperiencePerMonster;
            double guildExperience = experienceData.HuntingCount * guildAwardPerMonster;
            return experienceData.BaseExperience + experienceData.BonusExperience + guildExperience;
        }
    }
}
