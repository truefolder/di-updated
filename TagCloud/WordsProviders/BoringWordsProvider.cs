namespace TagCloud.WordsProviders;

public class BoringWordsProvider(string path, IWordsProviderResolver wordsProvider) : IBoringWordsProvider
{
    private readonly HashSet<string> _words = wordsProvider.ReadWords(path).ToHashSet();

    public HashSet<string> GetWords() => _words;
}