namespace RCWP.Core
{
    internal class CalculatedShotgun : CalculatedGun
    {
        public CalculatedShotgun(Gun gun) : base(gun)
        {
        }

        public override string Size => (NumberOfBullet > 2) ? "Large" : "Medium";
        public override int Damage => 20 * NumberOfBullet;
    }
}