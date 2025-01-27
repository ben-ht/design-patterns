namespace DesignPatterns.Facade;
internal class Order : IFacade
{
    private readonly Waiter waiter;
    private readonly Kitchen kitchen;

    public Order()
    {
        waiter = new Waiter();
        kitchen = new Kitchen();
    }

    public void OrderFood()
    {
        waiter.WriteOrder();
        waiter.SendToKitchen();
        kitchen.PrepareFood();
        kitchen.CallWaiter();
        waiter.ServeCustomer();
        kitchen.WashDishes();
    }
}
