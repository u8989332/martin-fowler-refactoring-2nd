namespace RCWP.Core
{
    public class Gun
    {
        public Gun(string name, string type, int numberOfBullet, bool isScoped)
        {
            Name = name;
            Type = type;
            NumberOfBullet = numberOfBullet;
            IsScoped = isScoped;
        }

        public string Name { get; }
        public string Type { get; }
        public int NumberOfBullet { get; }
        public bool IsScoped { get; }
    }
}