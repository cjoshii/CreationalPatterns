namespace Builder;

public interface IComputerBuilder
{
    IComputerBuilder SetCPU(string cpu);
    IComputerBuilder SetMemory(string memory);
    IComputerBuilder SetGPU(string gpu);
    IComputerBuilder SetStorage(string storage);
    IComputer Build();
}