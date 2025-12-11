using SixLabors.Fonts;
using SixLabors.ImageSharp;
using TagCloud.WordsProcessing;

namespace TagCloud.Sizing;

public class TextTagSizeCalculator : ITextTagSizeCalculator
{
    public Size CalculateSize(TextTag tag, string fontName)
    {
        var fontFamily = SystemFonts.Families.FirstOrDefault(f => f.Name == fontName);
        
        var font = fontFamily.CreateFont(tag.FontSize);
        
        var size = TextMeasurer.MeasureSize(tag.Word, new TextOptions(font));
        return new Size((int)Math.Ceiling(size.Width), (int)Math.Ceiling(size.Height));
    }
}