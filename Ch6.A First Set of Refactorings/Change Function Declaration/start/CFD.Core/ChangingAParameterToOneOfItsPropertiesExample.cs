using System.Linq;

namespace CFD.Core
{
    public class ChangingAParameterToOneOfItsPropertiesExample
    {
        public static bool Is2022ZodiacLuckyPerson(Member member)
        {
            return new[] { "Aries", "Leo", "Aquarius" }.Contains(member.ZodiacSign.Name);
        }
    }
}
