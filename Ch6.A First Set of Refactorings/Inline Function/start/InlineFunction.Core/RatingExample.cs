namespace InlineFunction.Core
{
    public class RatingExample
    {
        public static int Rating(Man man)
        {
            return IsThisManRich(man) ? 80 : 30;
        }

        private static bool IsThisManRich(Man man)
        {
            return man.Money > 100000;
        }
    }
}
