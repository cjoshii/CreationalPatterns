namespace FactoryMethod.Logistics;

public abstract class Logistics
{
    public abstract Transport CreateTransport();

}

public class RoadLogistics : Logistics
{
    public override Transport CreateTransport()
    {
        return new Truck();
    }
}
public class SeaLogistics : Logistics
{
    public override Transport CreateTransport()
    {
        return new Ship();
    }
}
public class AirLogistics : Logistics
{
    public override Transport CreateTransport()
    {
        return new Airplane();
    }
}

public interface Transport
{
    void Deliver();
}
public class Truck : Transport
{
    public void Deliver()
    {
        Console.WriteLine("Delivering by truck");
    }
}
public class Ship : Transport
{
    public void Deliver()
    {
        Console.WriteLine("Delivering by ship");
    }
}
public class Airplane : Transport
{
    public void Deliver()
    {
        Console.WriteLine("Delivering by airplane");
    }
}
