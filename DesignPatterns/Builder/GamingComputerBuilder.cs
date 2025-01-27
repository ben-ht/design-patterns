namespace DesignPatterns.Builder;
internal class GamingComputerBuilder : IBuilder
{
    public Computer Computer { get; }

    public GamingComputerBuilder()
    {
        Computer = new Computer();
    }

    public void BuildCPU()
    {
        Computer.CPU = "i7 12700";
    }

    public void BuildRAM()
    {
        Computer.RAM = "16GB DDR4";
    }

    public void BuildStorage()
    {
        Computer.Storage = "1TB SSD";
    }
}
