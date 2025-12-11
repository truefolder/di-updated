namespace TagCloud.WordsProcessing;

public class WordProcessor(IWordNormalizer normalizer, IWordFilter filter) : IWordProcessor
{
    public IEnumerable<string> Process(IEnumerable<string> words) =>
        words.Select(normalizer.Normalize)
            .Where(word => !string.IsNullOrWhiteSpace(word))
            .Where(word => !filter.IsValid(word));
}