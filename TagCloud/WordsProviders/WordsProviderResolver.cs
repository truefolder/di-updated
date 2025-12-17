namespace TagCloud.WordsProviders;

public class WordsProviderResolver(IEnumerable<IWordsProvider> providers) : IWordsProviderResolver
{
    public IEnumerable<string> ReadWords(string path)
        => providers.First(s => s.CanRead(path)).ReadWords(path);
}