namespace Singleton;

public class SimpleSingletonExample
{

    //private static SimpleSingletonExample _instance;
    private static readonly Lazy<SimpleSingletonExample> _instance = new(() => new SimpleSingletonExample());
    //private readonly static Lock _lock = new();

    private SimpleSingletonExample()
    {
    }

    public static SimpleSingletonExample Instance => _instance.Value;

    // public static SimpleSingletonExample Instance {
    //     get {
    //         if(_instance == null){
    //            lock(_lock)
    //                 _instance ??= new SimpleSingletonExample();
    //         }

    //         return _instance;
    //     }
    // }

    public void DoSomething()
    {
        Console.WriteLine("Doing something");
    }
}