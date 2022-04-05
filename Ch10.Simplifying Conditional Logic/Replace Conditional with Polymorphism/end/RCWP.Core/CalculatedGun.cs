namespace RCWP.Core
{
    internal class CalculatedGun
    {
        public CalculatedGun(Gun gun)
        {
            Name = gun.Name;
            Type = gun.Type;
            IsScoped = gun.IsScoped;
            NumberOfBullet = gun.NumberOfBullet;
        }

        public bool IsScoped { get; }
        public string Type { get; }
        public string Name { get; }
        public int NumberOfBullet { get; }

        public virtual string Size => "Unknown";
        public virtual int Damage => 0;
    }
}