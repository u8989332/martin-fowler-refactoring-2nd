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
            switch (gun.Type)
            {
                case "Handgun":
                    return "Small";
                case "Shotgun":
                    return (gun.NumberOfBullet > 2) ? "Large" : "Medium";
                case "Rifle":
                    return (gun.IsScoped) ? "Large" : "Medium";
                default:
                    return "Unknown";
            }
        }

        private static int CalculateGunDamage(Gun gun)
        {
            switch (gun.Type)
            {
                case "Handgun":
                    return 30;
                case "Shotgun":
                    return 20 * gun.NumberOfBullet;
                case "Rifle":
                    return (gun.IsScoped) ? 80 : 60;
                default:
                    return 0;
            }
        }
    }
}