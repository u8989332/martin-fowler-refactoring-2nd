namespace RCWP.Core
{
    internal class CalculatedRifle : CalculatedGun
    {
        public CalculatedRifle(Gun gun) : base(gun)
        {
        }

        public override string Size => IsScoped ? "Large" : "Medium";
        public override int Damage => IsScoped ? 80 : 60;
    }
}