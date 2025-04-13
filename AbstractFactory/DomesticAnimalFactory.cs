namespace AbstractFactory;

public class DomesticAnimalFactory : IAnimalFactory
{
    private DomesticAnimalFactory()
    {
    }

    private static Lazy<DomesticAnimalFactory> _instance = new(() => new DomesticAnimalFactory());

    public static DomesticAnimalFactory Instance => _instance.Value;

    public IDog CreateDog()
    {
        return new DomesticDog();
    }

    public ICat CreateCat()
    {
        return new DomesticCat();
    }
}