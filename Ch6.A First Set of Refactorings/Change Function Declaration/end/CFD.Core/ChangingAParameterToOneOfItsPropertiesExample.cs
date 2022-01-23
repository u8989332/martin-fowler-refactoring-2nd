using System.Linq;

namespace CFD.Core
{
    public class ChangingAParameterToOneOfItsPropertiesExample
    {
        public static bool Is2022ZodiacLuckyPerson(string zodiacName)
        {
            return new[] { "Aries", "Leo", "Aquarius" }.Contains(zodiacName);
        }
    }
}
