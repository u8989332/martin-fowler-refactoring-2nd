namespace RCWP.Core
{
    internal class CalculatedHandgun : CalculatedGun
    {
        public CalculatedHandgun(Gun gun) : base(gun)
        {
        }

        public override int Damage => 30;

        public override string Size => "Small";
    }
}