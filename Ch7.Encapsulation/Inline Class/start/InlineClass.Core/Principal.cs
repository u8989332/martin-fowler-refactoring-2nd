namespace InlineClass.Core
{
    public class Principal
    {
        public string Name { get; set; }
        public string Office { get; set; }

        public string Display => $"{Office} : {Name}";
    }
}