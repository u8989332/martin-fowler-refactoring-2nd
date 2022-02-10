namespace EncapsulateCollection.Core
{
    public class Product
    {
        public int Price { get; }
        public string Name { get; }
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}