namespace AbstractFactory;

public class WildAnimalFactory : IAnimalFactory
{
    private static WildAnimalFactory? _instance;
    private static readonly Lock _lock = new();

    private WildAnimalFactory()
    {

    }

    public static WildAnimalFactory Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                    _instance ??= new WildAnimalFactory();
            }
            return _instance;
        }
    }

    public IDog CreateDog()
    {
        return new WildDog();
    }

    public ICat CreateCat()
    {
        return new WildCat();
    }
}