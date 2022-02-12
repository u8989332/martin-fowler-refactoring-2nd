namespace ExtractClass.Core
{
    public class Company
    {
        public string Name { get; set; }
        public string Office => $"{OfficeCountry} {OfficeRoad}";
        public string OfficeCountry { get; set; }
        public string OfficeRoad { get; set; }
    }
}
