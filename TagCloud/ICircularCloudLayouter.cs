using SixLabors.ImageSharp;

namespace TagCloud;

public interface ICircularCloudLayouter
{
    public Rectangle PutNextRectangle(Size rectangleSize);
}