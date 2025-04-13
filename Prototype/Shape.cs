namespace Prototype;
public abstract class Shape
{
    public int X { get; set; }
    public int Y { get; set; }

    public Shape()
    {

    }

    public Shape(Shape source)
    {
        this.X = source.X;
        this.Y = source.Y;
    }

    public abstract Shape Clone();


}