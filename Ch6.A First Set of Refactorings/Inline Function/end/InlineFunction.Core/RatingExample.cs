namespace InlineFunction.Core
{
    public class RatingExample
    {
        public static int Rating(Man man)
        {
            return man.Money > 100000 ? 80 : 30;
        }
    }
}
