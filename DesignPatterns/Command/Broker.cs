namespace DesignPatterns.Command;
internal class Broker
{
    private readonly List<ICommand> orderList = new List<ICommand>();

    public void TakeOrder(ICommand command)
    {
        orderList.Add(command);
    }

    public void PlaceOrders()
    {
        foreach(var order in orderList)
        {
            order.Execute();
        }

        orderList.Clear();
    }
}
