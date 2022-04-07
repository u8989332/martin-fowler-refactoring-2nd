namespace ISC.Core
{
    public class ObjectLiteralFactory
    {
        public static IObjectLiteralJob CreateUnassignedJob()
        {
            return new ObjectLiteralUnassignedJob();
        }
    }
}