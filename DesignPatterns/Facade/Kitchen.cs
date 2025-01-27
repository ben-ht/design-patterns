namespace DesignPatterns.Facade;
internal class Kitchen
{
    public void PrepareFood()
    {
        Console.WriteLine("Cook food");
    }

    public void CallWaiter()
    {
        Console.WriteLine("Call waiter");
    }

    public void WashDishes()
    {
        Console.WriteLine("Wash the dishes");
    }
}
