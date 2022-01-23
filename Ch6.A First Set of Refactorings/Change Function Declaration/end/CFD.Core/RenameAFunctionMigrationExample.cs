using System;

namespace CFD.Core
{
    public class RenameAFunctionMigrationExample
    {
        [Obsolete]
        public static int Seconds(int days)
        {
            return ConvertDaysToSeconds(days);
        }

        public static int ConvertDaysToSeconds(int days)
        {
            return days * 24 * 60 * 60;
        }
    }
}
