namespace CRTV.Core
{
    public class Student
    {
        private Address _address = new Address();

        public string AddressCity
        {
            get => _address.City;

            set => _address = new Address(value, AddressStreet);
        }

        public string AddressStreet
        {
            get => _address.Street;

            set => _address = new Address(AddressCity, value);
        }
    }
}
