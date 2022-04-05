namespace RCWP.Core
{
    public class Shareholder
    {
        public Shareholder(int reputation, string liveCity)
        {
            Reputation = reputation;
            LiveCity = liveCity;
        }

        public int Reputation { get; }
        public string LiveCity { get; }
    }
}