namespace DesignPatterns.Factory;
internal static class ShapeFactory
{
    public const string CIRCLE = "circle";
    public const string RECTANGLE = "rectangle";

    public static IShape GetShape(string shapeType)
    {
        if (shapeType == CIRCLE)
        {
            return new Circle();
        }
        if (shapeType == RECTANGLE)
        {
            return new Rectangle();
        }

        throw new ArgumentException("Unknown shape");
    }
}
