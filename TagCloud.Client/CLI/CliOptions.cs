using CommandLine;

namespace TagCloud.Client.CLI;

public class CliOptions
{
    [Option("inputFile")] 
    public string InputFilePath { get; set; } = null!;
    
    [Option("boringWordsFile")]
    public string? BoringWordsFilePath { get; set; }

    [Option("outputFile")]
    public string OutputFilePath { get; set; } = "tagcloud.png";

    [Option("width")] 
    public int ImageWidth { get; set; } = 1920;

    [Option("height")] 
    public int ImageHeight { get; set; } = 1080;

    [Option("font")]
    public string FontName { get; set; } = "Arial";

    [Option("min-font-size")] 
    public float MinFontSize { get; set; } = 10;

    [Option("max-font-size")] 
    public float MaxFontSize { get; set; } = 60;
}