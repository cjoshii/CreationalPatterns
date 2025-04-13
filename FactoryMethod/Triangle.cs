namespace FactoryMethod;

public class Triangle : IShape
{
    public Triangle()
    {
        // Constructor
    }

    public void Draw()
    {
        Console.WriteLine("Drawing Triangle");
    }
}