namespace RNCWGC.Core
{
    public class ASimpleExample
    {
        public static CarStatus GetCarStatus(Car car)
        {
            CarStatus result;
            if (car.HasBrokenWindows)
            {
                result = CarStatus.Bad;
            }
            else
            {
                if (car.IsEngineOld)
                {
                    result = CarStatus.Normal;
                }
                else
                {
                    result = CarStatus.Good;
                }
            }

            return result;
        }
    }
}