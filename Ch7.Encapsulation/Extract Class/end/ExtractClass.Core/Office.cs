namespace ExtractClass.Core
{
    public class Office
    {
        public string Country { get; set; }
        public string Road { get; set; }
        public override string ToString()
        {
            return $"{Country} {Road}";
        }
    }
}