namespace RNCWGC.Core
{
    public class Stone
    {
        public Stone(int hardness, int fluorescence, int clarity)
        {
            Hardness = hardness;
            Fluorescence = fluorescence;
            Clarity = clarity;
        }

        public int Hardness { get; }
        public int Fluorescence { get; }
        public int Clarity { get; }
    }
}