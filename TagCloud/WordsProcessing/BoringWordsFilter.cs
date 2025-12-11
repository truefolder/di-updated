using TagCloud.WordsProviders;

namespace TagCloud.WordsProcessing;

public class BoringWordsFilter(IBoringWordsProvider provider) : IWordFilter
{
    public bool IsValid(string word) =>
        !provider.GetWords().Contains(word);
}