namespace TagCloud.WordsProviders;

public interface IWordsProvider
{
    IEnumerable<string> ReadWords(string path);
}