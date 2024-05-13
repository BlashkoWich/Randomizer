using System.Collections.Generic;
using System.Linq;
using RandomizerJB.Generators.Realization;
using RandomizerJB.Randoms;

namespace RandomizerJB
{
    public static class GeneratorStore
    {
        private static readonly IGenerator[] Generators = {
            new FibonacciGenerator(),
            new LinearCongruentialGenerator(),
            new MiddleSquareGenerator()
        };

        private static readonly List<int> results = new List<int>();

        public static List<int> Generate(GeneratorType generatorType, int start, int max, int resultCount)
        {
            results.Clear();
            
            for (int i = 0; i < resultCount; i++)
            {
                var generator = Generators.First(x => x.GeneratorType == generatorType);
                var random = generator.Random(start, max);
                results.Add(random);
            }

            return results;
        }
    }
}