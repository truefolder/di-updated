namespace TagCloud.WordsProcessing;

public interface IWordProcessor
{
    public IEnumerable<string> Process(IEnumerable<string> words);
}