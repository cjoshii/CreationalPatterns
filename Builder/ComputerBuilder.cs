namespace Builder;

public class ComputerBuilder : IComputerBuilder
{
    private readonly IComputer _computer;

    public ComputerBuilder()
    {
        _computer = new Computer();
    }

    public IComputer Build()
    {
        return _computer;
    }

    public IComputerBuilder SetCPU(string cpu)
    {
        _computer.CPU = cpu;
        return this;
    }

    public IComputerBuilder SetGPU(string gpu)
    {
        _computer.GPU = gpu;
        return this;
    }

    public IComputerBuilder SetMemory(string memory)
    {
        _computer.Memory = memory;
        return this;
    }

    public IComputerBuilder SetStorage(string storage)
    {
        _computer.Storage = storage;
        return this;
    }
}