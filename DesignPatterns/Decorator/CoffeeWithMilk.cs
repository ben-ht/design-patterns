namespace DesignPatterns.Decorator;
internal class CoffeeWithMilk : CoffeeDecorator
{
    public CoffeeWithMilk(ICoffee coffee) : base(coffee)
    {
    }

    public override void MakeCoffee()
    {
        coffee.MakeCoffee();
        AddMilk();
    }

    public void AddMilk()
    {
        Console.Write(" + milk");
    }
}
