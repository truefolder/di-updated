namespace TagCloud.WordsProviders;

public interface IWordsProvider
{
    public IEnumerable<string> ReadWords();
}