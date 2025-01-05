namespace DesignPatterns.Command;
internal class Sell : ICommand
{
    private readonly Stock stock;

    public Sell(Stock stock)
    {
        this.stock = stock;
    }

    public void Execute()
    {
        stock.Sell();
    }

    public void Undo()
    {
        stock.Cancel();
    }
}
