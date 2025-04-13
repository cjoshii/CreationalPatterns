namespace AbstractFactory.Furniture;

public interface IFurnitureFactory
{
    IChair CreateChair();
    ISofa CreateSofa();
    ITable CreateTable();
}

public class ModernFurnitureFactory : IFurnitureFactory
{

    // Singleton implementation
    private ModernFurnitureFactory()
    {
        // Private constructor to prevent instantiation
    }
    public static Lazy<IFurnitureFactory> _instance = new(() => new ModernFurnitureFactory());
    public static IFurnitureFactory Instance => _instance.Value;

    public IChair CreateChair()
    {
        return new ModernChair();
    }

    public ISofa CreateSofa()
    {
        return new ModernSofa();
    }

    public ITable CreateTable()
    {
        return new ModernTable();
    }
}

//Classic furniture factory
public class ClassicFurnitureFactory : IFurnitureFactory
{

    // Singleton implementation
    private ClassicFurnitureFactory()
    {
        // Private constructor to prevent instantiation
    }
    public static Lazy<IFurnitureFactory> _instance = new(() => new ClassicFurnitureFactory());
    public static IFurnitureFactory Instance => _instance.Value;
    public IChair CreateChair()
    {
        return new ClassicChair();
    }

    public ISofa CreateSofa()
    {
        return new ClassicSofa();
    }

    public ITable CreateTable()
    {
        return new ClassicTable();
    }
}

// Abstract product interfaces
public interface IChair
{
    string GetDescription();
}
public interface ISofa
{
    string GetDescription();
}
public interface ITable
{
    string GetDescription();
}
// Concrete products for modern furniture
public class ModernChair : IChair
{
    public string GetDescription()
    {
        return "Modern Chair";
    }
}
public class ModernSofa : ISofa
{
    public string GetDescription()
    {
        return "Modern Sofa";
    }
}
public class ModernTable : ITable
{
    public string GetDescription()
    {
        return "Modern Table";
    }
}
// Concrete products for classic furniture
public class ClassicChair : IChair
{
    public string GetDescription()
    {
        return "Classic Chair";
    }
}
public class ClassicSofa : ISofa
{
    public string GetDescription()
    {
        return "Classic Sofa";
    }
}
public class ClassicTable : ITable
{
    public string GetDescription()
    {
        return "Classic Table";
    }
}


// Client code
public class FurnitureClient
{
    private readonly IChair _chair;
    private readonly ISofa _sofa;
    private readonly ITable _table;

    public FurnitureClient(IFurnitureFactory factory)
    {
        _chair = factory.CreateChair();
        _sofa = factory.CreateSofa();
        _table = factory.CreateTable();
    }

    public void DescribeFurniture()
    {
        Console.WriteLine(_chair.GetDescription());
        Console.WriteLine(_sofa.GetDescription());
        Console.WriteLine(_table.GetDescription());
    }
}