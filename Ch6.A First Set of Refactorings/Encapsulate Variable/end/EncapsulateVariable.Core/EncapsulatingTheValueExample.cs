namespace EncapsulateVariable.Core
{
    public class EncapsulatingTheValueExample
    {
        private static User _defaultUser = new User("John", "Donald");

        public static User DefaultUser
        {
            get => new User(_defaultUser);
            set => _defaultUser = value;
        }
    }
}
