namespace HideDelegate.Core
{
    public class Order
    {
        public string Name { get; }

        public Order(string name)
        {
            Name = name;

            // simulate from db
            Customer = new Customer()
            {
                Name = "Jack",
                Address = "Hello Road"
            };
        }

        public Customer Customer { get; }
    }
}
