namespace RenameVariable.Core
{
    public class EncapsulatingVariableExample
    {
        private static int _height = 999;

        public static int Height
        {
            get => _height;
            set => _height = value;
        }
    }

}
