using NUnit.Framework;
using SplitPhase.Core;

namespace SplitPhase.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Call_HuntingMonsterExample_Get_Correct_Experience()
        {
            // arrange
            Monster monster = new Monster()
            {
                BaseExperience = 500,
                BonusExperienceHuntingCount = 60,
                BonusExperienceRate = 0.6
            };

            GuildAward guildAward = new GuildAward()
            {
                BonusExperienceThreshold = 20000,
                HighExperiencePerMonster = 150,
                NormalExperiencePerMonster = 50
            };

            // act
            var result1 = HuntingMonsterExample.GetExperience(monster, 80, guildAward);
            var result2 = HuntingMonsterExample.GetExperience(monster, 44, guildAward);

            // assert
            Assert.AreEqual(58000, result1, 0.01);
            Assert.AreEqual(28600, result2, 0.01);
        }
    }
}