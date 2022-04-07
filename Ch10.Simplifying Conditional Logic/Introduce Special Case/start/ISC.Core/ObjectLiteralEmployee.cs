namespace ISC.Core
{
    public class ObjectLiteralEmployee
    {
        public ObjectLiteralEmployee(ObjectLiteralJob job)
        {
            Job = job;
        }

        public ObjectLiteralJob Job { get; }
    }
}