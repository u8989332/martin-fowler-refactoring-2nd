namespace RCWP.Core
{
    public class Restaurant
    {
        public Restaurant(int tableSize, string city)
        {
            TableSize = tableSize;
            City = city;
        }

        public int TableSize { get; }
        public string City { get; }
    }
}