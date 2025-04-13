namespace FactoryMethod;

public class TriangleFactory : ShapeFactory
{
    public override IShape GetShape()
    {
        return new Triangle();
    }
}