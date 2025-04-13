namespace Builder;

public class ComputerBuilderDirector
{
    private readonly IComputerBuilder computerBuilder;

    public ComputerBuilderDirector(IComputerBuilder computerBuilder)
    {
        this.computerBuilder = computerBuilder;
    }

    public IComputer BuildGamingPC(){
        return computerBuilder.SetCPU("Intel i9")
            .SetMemory("32GB")
            .SetGPU("Nvidia RTX 3090")
            .SetStorage("1TB SSD")
            .Build();
    }

    public IComputer BuildMiningPC(){
        return computerBuilder.SetCPU("Intel i9")
            .SetMemory("128GB")
            .SetGPU("Nvidia RTX 3090")
            .SetStorage("4TB SSD")
            .Build();
    }

    public IComputer BuildDevelopmentPC(){
        return computerBuilder.SetCPU("AMD Ryzen 9")
            .SetMemory("64GB")
            .SetGPU("Nvidia RTX 3090")
            .SetStorage("2TB SSD")
            .Build();
    }

    public IComputer BuildCustomPC(string cpu, string memory, string gpu, string storage){
        return computerBuilder.SetCPU(cpu)
            .SetMemory(memory)
            .SetGPU(gpu)
            .SetStorage(storage)
            .Build();
    }
    
}
