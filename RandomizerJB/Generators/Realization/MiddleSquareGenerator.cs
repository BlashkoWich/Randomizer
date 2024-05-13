using RandomizerJB.Randoms;

namespace RandomizerJB.Generators.Realization
{
    public class MiddleSquareGenerator : IGenerator
    {
        public GeneratorType GeneratorType => GeneratorType.MiddleSquare;
        
        private int seed;


        public MiddleSquareGenerator()
        {
            seed = 99912;
        }

        public int Random(int min, int max)
        {
            seed *= seed;
            string seedString = seed.ToString().PadLeft(8, '0');
            string middleDigits = seedString.Substring(2, 4);
            seed = int.Parse(middleDigits);
            return (int) ((seed / 9999.0) * (max - min + 1)) + min;
        }
    }
}