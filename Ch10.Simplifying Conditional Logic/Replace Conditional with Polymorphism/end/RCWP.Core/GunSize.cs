namespace RCWP.Core
{
    public class GunSize
    {
        public GunSize(string name, string size)
        {
            Name = name;
            Size = size;
        }

        public string Name { get; }
        public string Size { get; }
    }
}