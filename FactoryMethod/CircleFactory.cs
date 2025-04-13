namespace FactoryMethod;

public class CircleFactory : ShapeFactory
{
    public override IShape GetShape()
    {
        return new Circle();
    }
}