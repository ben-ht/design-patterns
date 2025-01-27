namespace DesignPatterns.Builder;
internal class Laptop
{
    public string Storage {  get; set; }
    public string RAM { get; set; }
    public string CPU { get; set; }

    public override string ToString()
    {
        return $"Computer (CPU : {CPU}, RAM : {RAM}, Storage : {Storage})";
    }
}
