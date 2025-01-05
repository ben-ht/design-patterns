namespace DesignPatterns.Command;
internal class Buy : ICommand
{
    private readonly Stock stock;

    public Buy(Stock stock)
    {
        this.stock = stock;
    }

    public void Execute()
    {
        stock.Buy();
    }

    public void Undo()
    {
        stock.Cancel();
    }
}
