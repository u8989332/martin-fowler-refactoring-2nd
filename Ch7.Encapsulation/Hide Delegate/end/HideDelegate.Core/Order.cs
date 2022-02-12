namespace HideDelegate.Core
{
    public class Order
    {
        public string Name { get; }
        private Customer _customer;

        public Order(string name)
        {
            Name = name;

            // simulate from db
            _customer = new Customer()
            {
                Name = "Jack",
                Address = "Hello Road"
            };
        }

        public string CustomerName => _customer.Name;
    }
}
