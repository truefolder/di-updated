namespace TagCloud.WordsProviders;

public interface IWordsProviderResolver
{
    IEnumerable<string> ReadWords(string path);
}