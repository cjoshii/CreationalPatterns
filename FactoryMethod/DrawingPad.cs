namespace FactoryMethod;

public abstract class DrawingPad
{
    private IDrawingCategory _category;

    public DrawingPad()
    {
        _category = InitializeCategory();
    }

    public abstract IDrawingCategory InitializeCategory();

    public void Draw()
    {
        Console.WriteLine("Chose an object to draw:");
        var i = 1;
        foreach (var item in _category.Objects)
        {
            Console.WriteLine($"{i++}. " + item);
        }
        var inpup = Console.ReadLine();

        if (int.TryParse(inpup, out int input) && input > 0 && input <= _category.Objects.Length)
        {
            Console.WriteLine($"Drawing {_category.Objects[input - 1]}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please try again.");
        }
    }
}

public class AnimalDrawingPad : DrawingPad
{
    public override IDrawingCategory InitializeCategory()
    {
        return new Animals();
    }
}

public class VehicleDrawingPad : DrawingPad
{
    public override IDrawingCategory InitializeCategory()
    {
        return new Vehicles();
    }
}

public class ScienceDrawingPad : DrawingPad
{
    public override IDrawingCategory InitializeCategory()
    {
        return new Science();
    }
}


public interface IDrawingCategory
{
    string[] Objects { get; }
}

public class Animals : IDrawingCategory
{
    private static readonly string[] _objects = new string[] { "Dog", "Cat", "Bird", "Fish" };
    public string[] Objects => _objects;

}

public class Vehicles : IDrawingCategory
{

    private static readonly string[] _objects = new string[] { "Car", "Truck", "Bus", "Bike" };
    public string[] Objects => _objects;

}

public class Science : IDrawingCategory
{

    private static readonly string[] _objects = new string[] { "Sun", "Moon", "Earth", "Mountain", "River" };
    public string[] Objects => _objects;
}

