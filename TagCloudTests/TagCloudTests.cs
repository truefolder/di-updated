using Autofac;
using FluentAssertions;
using TagCloud;
using TagCloud.Client.DI;
using TagCloud.Options;
using TagCloudTests.Utils;

namespace TagCloudTests;

public class TagCloudTests
{
    [Test]
    public void Generate_ShouldCreatePngFromTxtFileWithPaletteColorizer_WhenCorrectDataIsProvided()
    {
        var testDir = FilesUtils.CreateTempDir();
        var inputPath = FilesUtils.WriteTextFile(testDir, "input.txt", ["hello", "world", "boring"]);
        var boringPath = FilesUtils.WriteTextFile(testDir, "boring.txt", ["boring"]);
        var outputPath = $"{testDir}/test.png";

        var builder = new ContainerBuilder();
        builder.RegisterModule(new TagCloudModule(boringPath));
        var container = builder.Build();
        
        var generator = container.Resolve<ITagCloudGenerator>();
        
        var options = new TagCloudOptions
        {
            InputFilePath = inputPath,
            BoringWordsFilePath = boringPath,
            OutputFilePath = outputPath,
            ImageWidth = 1920,
            ImageHeight = 1080,
            FontName = "Arial",
            MinFontSize = 10,
            MaxFontSize = 60,
            ColorizerName = "palette",
            Colors = "#ff0000,#00ff00,#0000ff"
        };
        
        generator.Generate(options);
        
        File.Exists(outputPath).Should().Be(true);
    }
    
    [Test]
    public void Generate_ShouldCreateJpgFromTxtFileWithPaletteColorizer_WhenCorrectDataIsProvided()
    {
        var testDir = FilesUtils.CreateTempDir();
        var inputPath = FilesUtils.WriteTextFile(testDir, "input.txt", ["hello", "world", "boring"]);
        var boringPath = FilesUtils.WriteTextFile(testDir, "boring.txt", ["boring"]);
        var outputPath = $"{testDir}/test.jpg";

        var builder = new ContainerBuilder();
        builder.RegisterModule(new TagCloudModule(boringPath));
        var container = builder.Build();
        
        var generator = container.Resolve<ITagCloudGenerator>();
        
        var options = new TagCloudOptions
        {
            InputFilePath = inputPath,
            BoringWordsFilePath = boringPath,
            OutputFilePath = outputPath,
            ImageWidth = 1920,
            ImageHeight = 1080,
            FontName = "Arial",
            MinFontSize = 10,
            MaxFontSize = 60,
            ColorizerName = "palette",
            Colors = "#ff0000,#00ff00,#0000ff"
        };
        
        generator.Generate(options);
        
        File.Exists(outputPath).Should().Be(true);
    }
    
    [Test]
    public void Generate_ShouldCreatePngFromDocxFileWithPaletteColorizer_WhenCorrectDataIsProvided()
    {
        var testDir = FilesUtils.CreateTempDir();
        var inputPath = FilesUtils.WriteDocxFile(testDir, "input.docx", "hello\nworld\nboring");
        var boringPath = FilesUtils.WriteDocxFile(testDir, "boring.docx", "boring");
        var outputPath = $"{testDir}/test.png";

        var builder = new ContainerBuilder();
        builder.RegisterModule(new TagCloudModule(boringPath));
        var container = builder.Build();
        
        var generator = container.Resolve<ITagCloudGenerator>();
        
        var options = new TagCloudOptions
        {
            InputFilePath = inputPath,
            BoringWordsFilePath = boringPath,
            OutputFilePath = outputPath,
            ImageWidth = 1920,
            ImageHeight = 1080,
            FontName = "Arial",
            MinFontSize = 10,
            MaxFontSize = 60,
            ColorizerName = "palette",
            Colors = "#ff0000,#00ff00,#0000ff"
        };
        
        generator.Generate(options);
        
        File.Exists(outputPath).Should().Be(true);
    }
    
    [Test]
    public void Generate_ShouldCreateJpgFromDocxFileWithPaletteColorizer_WhenCorrectDataIsProvided()
    {
        var testDir = FilesUtils.CreateTempDir();
        var inputPath = FilesUtils.WriteDocxFile(testDir, "input.docx", "hello\nworld\nboring");
        var boringPath = FilesUtils.WriteDocxFile(testDir, "boring.docx", "boring");
        var outputPath = $"{testDir}/test.jpg";

        var builder = new ContainerBuilder();
        builder.RegisterModule(new TagCloudModule(boringPath));
        var container = builder.Build();
        
        var generator = container.Resolve<ITagCloudGenerator>();
        
        var options = new TagCloudOptions
        {
            InputFilePath = inputPath,
            BoringWordsFilePath = boringPath,
            OutputFilePath = outputPath,
            ImageWidth = 1920,
            ImageHeight = 1080,
            FontName = "Arial",
            MinFontSize = 10,
            MaxFontSize = 60,
            ColorizerName = "palette",
            Colors = "#ff0000,#00ff00,#0000ff"
        };
        
        generator.Generate(options);
        
        File.Exists(outputPath).Should().Be(true);
    }
}