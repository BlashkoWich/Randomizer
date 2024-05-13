using RandomizerJB.Randoms;

namespace RandomizerJB.Generators.Realization
{
    public class LinearCongruentialGenerator : IGenerator
    {
        private int _multiplier;
        private int _increment;
        private int _modulus;
        private int _seed;

        public LinearCongruentialGenerator()
        {
            _seed = 123;
            _multiplier = 1103515245;
            _increment = 12345;
            _modulus = 12443;
        }
        
        public GeneratorType GeneratorType => GeneratorType.LinearCongruent;
        
        public int Random(int start, int max)
        {
            _seed = (_multiplier * _seed + _increment) % _modulus;
            return (int)((_seed / (double)_modulus) * (max - start + 1)) + start;
        }
    }
}