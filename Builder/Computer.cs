namespace Builder;

public class Computer : IComputer
{
    public string? CPU { get; set; }
    public string? Memory { get; set; }
    public string? GPU { get; set; }
    public string? Storage { get; set; }

    public void Display()
    {
        Console.WriteLine($"CPU: {CPU}");
        Console.WriteLine($"Memory: {Memory}");
        Console.WriteLine($"GPU: {GPU}");
        Console.WriteLine($"Storage: {Storage}");
    }
}