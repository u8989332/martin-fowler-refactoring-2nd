using System.Collections.Generic;
using System.Linq;

namespace RCWP.Core
{
    public class ASimpleExample
    {
        public static List<GunDamage> GunDamages(List<Gun> guns)
        {
            return guns.Select(x => new GunDamage(x.Name, CalculateGunDamage(x))).ToList();
        }

        public static List<GunSize> GunSizes(List<Gun> guns)
        {
            return guns.Select(x => new GunSize(x.Name, CalculateGunSize(x))).ToList();
        }

        private static string CalculateGunSize(Gun gun)
        {
            return CreateCalculatedGun(gun).Size;
        }

        private static CalculatedGun CreateCalculatedGun(Gun gun)
        {
            switch (gun.Type)
            {
                case "Handgun":
                    return new CalculatedHandgun(gun);
                case "Shotgun":
                    return new CalculatedShotgun(gun);
                case "Rifle":
                    return new CalculatedRifle(gun);
                default:
                    return new CalculatedGun(gun);
            }
        }

        private static int CalculateGunDamage(Gun gun)
        {
            return CreateCalculatedGun(gun).Damage;
        }
    }
}