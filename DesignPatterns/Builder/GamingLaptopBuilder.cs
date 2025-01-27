namespace DesignPatterns.Builder;
internal class GamingLaptopBuilder : IBuilder
{
    public Laptop Laptop { get; }

    public GamingLaptopBuilder()
    {
        Laptop = new Laptop();
    }

    public void BuildCPU()
    {
        Laptop.CPU = "i7 12700";
    }

    public void BuildRAM()
    {
        Laptop.RAM = "16GB DDR4";
    }

    public void BuildStorage()
    {
        Laptop.Storage = "1TB SSD";
    }
}
