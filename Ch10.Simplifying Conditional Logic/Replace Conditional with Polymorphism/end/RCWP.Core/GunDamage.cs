namespace RCWP.Core
{
    public class GunDamage
    {
        public GunDamage(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }

        public string Name { get; }
        public int Damage { get; }
    }
}