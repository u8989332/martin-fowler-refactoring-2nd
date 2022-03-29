using System;

namespace DecomposeConditional.Core
{
    public class AnnualBonusPlan
    {
        public AnnualBonusPlan(DateTime juniorJoinDate, double juniorRatio, double seniorRatio)
        {
            JuniorJoinDate = juniorJoinDate;
            JuniorRatio = juniorRatio;
            SeniorRatio = seniorRatio;
        }

        public DateTime JuniorJoinDate { get; }
        public double JuniorRatio { get; }
        public double SeniorRatio { get; }
    }
}