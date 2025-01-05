namespace DesignPatterns.Decorator;
internal class CoffeeWithSugar : CoffeeDecorator
{
    public CoffeeWithSugar(ICoffee coffee) : base(coffee)
    {
    }

    public override void MakeCoffee()
    {
        coffee.MakeCoffee();
        AddSugar();
    }

    public void AddSugar()
    {
        Console.Write(" + sugar");
    }
}
