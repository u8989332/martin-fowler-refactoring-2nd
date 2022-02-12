namespace InlineClass.Core
{
    public class School
    {
        private Principal _principal;
        public string PrincipalInfo => Principal.Display;

        public Principal Principal
        {
            get => _principal;
            set => _principal = value;
        }
    }
}
