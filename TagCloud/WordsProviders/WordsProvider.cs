namespace TagCloud.WordsProviders;

public class WordsProvider : IWordsProvider
{
    public IEnumerable<string> ReadWords(string? path)
    {
        if (!File.Exists(path))
            throw new FileNotFoundException($"Words file not found with path {path}");
        
        return File.ReadAllLines(path);
    }
}