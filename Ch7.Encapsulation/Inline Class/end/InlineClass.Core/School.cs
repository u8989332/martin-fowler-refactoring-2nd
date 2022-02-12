namespace InlineClass.Core
{
    public class School
    {
        public string PrincipalInfo => $"{PrincipalOffice} : {PrincipalName}";

        public string PrincipalName
        {
            get;
            set;
        }

        public string PrincipalOffice
        {
            get;
            set;
        }
    }
}
