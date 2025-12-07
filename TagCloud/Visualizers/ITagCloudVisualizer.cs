using SixLabors.ImageSharp;

namespace TagCloud.Visualizers;

public interface ITagCloudVisualizer
{
    public void DrawRectangles(List<Rectangle> rectangles, Size canvasSize, string savePath);
}