using System.Text.RegularExpressions;

namespace TagCloud.WordsProcessing;

public class WordProcessor(IWordNormalizer normalizer, IWordFilter filter) : IWordProcessor
{
    public IEnumerable<string> Process(IEnumerable<string> words) =>
        words.SelectMany(text => Regex.Split(text, @"\P{L}+")) // защита от мусора в docx/doc файлах, сплитим только по небуквенным символам
            .Select(normalizer.Normalize)
            .Where(word => !string.IsNullOrWhiteSpace(word))
            .Where(filter.IsValid);
}