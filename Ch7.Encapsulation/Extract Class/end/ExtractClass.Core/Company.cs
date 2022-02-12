namespace ExtractClass.Core
{
    public class Company
    {
        private readonly Office _office;

        public Company()
        {
            _office = new Office();
        }

        public string Name { get; set; }
        public string Office => _office.ToString();

        public string OfficeCountry
        {
            get => _office.Country;
            set => _office.Country = value;
        }

        public string OfficeRoad
        {
            get => _office.Road;
            set => _office.Road = value;
        }
    }
}
