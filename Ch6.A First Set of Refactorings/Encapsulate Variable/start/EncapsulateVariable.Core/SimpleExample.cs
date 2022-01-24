namespace EncapsulateVariable.Core
{
    public static class SimpleExample
    {
        public static User DefaultUser = new User("John", "Donald");
    }

    public class User
    {
        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; }
        public string LastName { get; }
    }
}
