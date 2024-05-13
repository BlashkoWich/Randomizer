using RandomizerJB.Randoms;

namespace RandomizerJB.Generators.Realization
{
    public class FibonacciGenerator : IGenerator
    {
        public GeneratorType GeneratorType => GeneratorType.Fibonacci;
        
        private int current;
        private int previous;

        public FibonacciGenerator()
        {
            current = 91234;
            previous = 0;
        }

        public int Random(int min, int max)
        {
            int temp = current;
            current = current + previous;
            previous = temp;
            return (int)((current / (double)int.MaxValue) * (max - min + 1)) + min;
        }
    }
}