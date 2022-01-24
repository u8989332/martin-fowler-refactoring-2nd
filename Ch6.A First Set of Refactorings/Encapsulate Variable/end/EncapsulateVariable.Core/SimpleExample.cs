namespace EncapsulateVariable.Core
{
    public static class SimpleExample
    {
        public static User DefaultUser { get; set; } = new User("John", "Donald");
    }

    public class User
    {
        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public User(User user)
        {
            FirstName = user.FirstName;
            LastName = user.LastName;
        }

        public string FirstName { get; }
        public string LastName { get; }
    }
}
