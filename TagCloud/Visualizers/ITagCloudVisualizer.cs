using SixLabors.ImageSharp;

namespace TagCloud.Visualizers;

public interface ITagCloudVisualizer
{
    public void Draw(List<Rectangle> rectangles, Size canvasSize, string savePath);
}