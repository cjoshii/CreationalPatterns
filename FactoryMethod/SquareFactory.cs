namespace FactoryMethod;

public class SquareFactory : ShapeFactory
{
    public override IShape GetShape()
    {
        return new Square();
    }
}