namespace FactoryMethod;

public class RectangleFactory : ShapeFactory
{
    public override IShape GetShape()
    {
        return new Rectangle();
    }
}