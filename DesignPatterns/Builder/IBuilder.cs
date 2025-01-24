namespace DesignPatterns.Builder;
internal interface IBuilder
{
    void BuildCPU();
    void BuildRAM();
    void BuildStorage();
}
