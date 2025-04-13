namespace Builder;

public interface IComputer
{

    string? CPU { get; set; }
    string? Memory { get; set; }
    string? GPU { get; set; }
    string? Storage { get; set; }

    void Display();

}