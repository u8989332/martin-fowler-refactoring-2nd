namespace CRTV.Core
{
    public class Student
    {
        private Address _address;

        public Student()
        {
            _address = new Address();
        }

        public string AddressCity
        {
            get => _address.City;

            set => _address.City = value;
        }

        public string AddressStreet
        {
            get => _address.Street;

            set => _address.Street = value;
        }
    }
}
