namespace CCE.Core
{
    public class Product
    {
        public Product(ProductType type, double price, bool isExpired)
        {
            Type = type;
            Price = price;
            IsExpired = isExpired;
        }

        public ProductType Type { get; }
        public double Price { get; }
        public bool IsExpired { get; }
    }
}