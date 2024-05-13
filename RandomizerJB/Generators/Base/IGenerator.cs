namespace RandomizerJB.Randoms
{
    public interface IGenerator
    {
        GeneratorType GeneratorType { get; }
        int Random(int start, int max);
    }
}