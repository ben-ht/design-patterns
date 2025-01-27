namespace DesignPatterns.Facade;
internal class Waiter
{
    public void WriteOrder()
    {
        Console.WriteLine("Waiter writes client's order");
    }

    public void SendToKitchen()
    {
        Console.WriteLine("Send order to kitchen");
    }

    public void ServeCustomer()
    {
        Console.WriteLine("Serves customer");
    }
}
