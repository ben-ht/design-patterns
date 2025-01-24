namespace DesignPatterns.Builder;
internal class BuildDirector
{
    public void Construct(IBuilder builder)
    {
        builder.BuildCPU();
        builder.BuildStorage();
        builder.BuildRAM();
    }
}
