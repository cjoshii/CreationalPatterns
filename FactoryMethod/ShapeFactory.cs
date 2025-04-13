namespace FactoryMethod;

public abstract class ShapeFactory
{
    public abstract IShape GetShape();

    public ShapeFactory()
    {
        Console.WriteLine("ShapeFactory created!");
    }
}