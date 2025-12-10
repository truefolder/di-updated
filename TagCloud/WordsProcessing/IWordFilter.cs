namespace TagCloud.WordsProcessing;

public interface IWordFilter
{
    public bool IsValid(string word);
}