namespace FactoryMethod;

public class Circle : IShape
{
    public Circle() { }

    public void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
}
