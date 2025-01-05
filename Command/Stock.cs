namespace DesignPatterns.Command;
internal class Stock
{
    private readonly string name = "Keyboard";
    private readonly int quantity = 123;

    public void Buy()
    {
        Console.WriteLine($"Stock [ Name: {name}, Quantity: {quantity}] bought");
    }

    public void Cancel()
    {
        Console.WriteLine("Canceled last operation");
    }

    public void Sell()
    {
        Console.WriteLine($"Stock [ Name: {name}, Quantity: {quantity}] sold");
    }
}
