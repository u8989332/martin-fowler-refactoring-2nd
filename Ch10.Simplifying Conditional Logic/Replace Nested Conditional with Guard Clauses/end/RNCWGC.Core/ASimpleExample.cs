namespace RNCWGC.Core
{
    public class ASimpleExample
    {
        public static CarStatus GetCarStatus(Car car)
        {
            if (car.HasBrokenWindows)
            {
                return CarStatus.Bad;
            }

            if (car.IsEngineOld)
            {
                return CarStatus.Normal;
            }

            return CarStatus.Good;
        }
    }
}