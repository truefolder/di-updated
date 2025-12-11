using FluentAssertions;
using SixLabors.ImageSharp;
using TagCloud;
using TagCloud.CoordinatesProviders;
using TagCloud.CoordinatesProviders.ArchimedesSpiral;
using TagCloud.Layouters;
using TagCloud.Visualizers;
using TagCloud.WordsProcessing;

namespace TagCloudTests;

public class TagCloudVisualizerTests
{
    private ITagCloudVisualizer _visualizer;
    private ICoordinatesProvider _coordinatesProvider;
    private readonly Random _random = new();

    [SetUp]
    public void SetUp()
    {
        var center = new Point(0, 0);
        _visualizer = new TagCloudVisualizer(Color.CadetBlue);
        _coordinatesProvider = new ArchimedesSpiral(center, 3, 1);
    }
    
    [Test]
    public void Draw_ShouldSaveImageInPath_WhenCorrectPathIsProvided()
    {
        var items = new List<DrawnTag>
        {
            new(new TextTag("Hello world!", 10, 30), new Rectangle(100, 100, 200, 100), Color.Black),
        };

        var savePath =
            $"{AppDomain.CurrentDomain.BaseDirectory}/{nameof(Draw_ShouldSaveImageInPath_WhenCorrectPathIsProvided)}.png";
        
        _visualizer.Draw(items, new Size(1920, 1080), 
            savePath, "Arial");

        File.Exists(savePath).Should().Be(true);
    }
}