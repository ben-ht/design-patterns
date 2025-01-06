using DesignPatterns.Adapter;
using DesignPatterns.ChainOfResponsibility;
using DesignPatterns.Command;
using DesignPatterns.Composite;
using DesignPatterns.Decorator;
using DesignPatterns.Factory;
using DesignPatterns.Iterator;
using DesignPatterns.Observer;
using DesignPatterns.Prototype;
using DesignPatterns.Strategy;

// Adapter
SamsungPhone samsung = new SamsungPhone(new ChargerAdapter());
samsung.OnCharge();

// Factory
IShape rectangle = ShapeFactory.GetShape(ShapeFactory.RECTANGLE);
rectangle.Draw();
IShape circle = ShapeFactory.GetShape(ShapeFactory.CIRCLE);
circle.Draw();

// Command
Stock keyboardStock = new Stock();
Broker broker = new Broker();
broker.TakeOrder(new Buy(keyboardStock));
broker.TakeOrder(new Sell(keyboardStock));
broker.PlaceOrders();

// Iterator
FruitList fruitList = new FruitList();
fruitList.AddFruit("Apple");
fruitList.AddFruit("Orange");
fruitList.AddFruit("Cherry");
foreach (var fruit in fruitList)
{
    Console.WriteLine(fruit);
}

// Prototype
Person p1 = new Person(new Id(1), 24, "Ben");
Person p2 = p1.ShallowCopy();
Person p3 = p1.DeepClone();
Console.WriteLine("Original values of p1, p2, p3");
Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);

p1.Name = "Jordan";
p1.Age = 30;
p1.Id.IdNumber = 999;
Console.WriteLine("New values of p1, p2, p3");
Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);

// Composite
Branch tree = new Branch();
Branch branch1 = new Branch();
branch1.Add(new Leaf());
branch1.Add(new Leaf());
Branch branch2 = new Branch();
branch2.Add(new Leaf());
tree.Add(branch1);
tree.Add(branch2);
Console.WriteLine(tree);

// Decorator
Coffee coffee = new Coffee();
Console.WriteLine("A simple coffee:");
coffee.MakeCoffee();
CoffeeWithMilk coffeWithMilk = new CoffeeWithMilk(new Coffee());
Console.WriteLine();
Console.WriteLine("A coffee with milk:");
coffeWithMilk.MakeCoffee();
CoffeeWithSugar coffeeWithMilkAndSugar = new CoffeeWithSugar(coffeWithMilk);
Console.WriteLine();
Console.WriteLine("A coffee with milk and sugar:");
coffeeWithMilkAndSugar.MakeCoffee();
Console.WriteLine();

// Observer
Subject subject = new Subject();
subject.AddObserver(new BinaryOberver(subject));
subject.AddObserver(new HexaObserver(subject));
Console.WriteLine("Setting value to 15:");
subject.Number = 15;
Console.WriteLine("Setting value to 283:");
subject.Number = 283;

// Strategy
Character archer = new Character("Archer", new Bow());
archer.Attack();
Character warrior = new Character("Warrior", new TwoHandedSword());
warrior.Attack();

// Chain of responsibility
AuthenticationHandler authenticationHandler = new AuthenticationHandler();
AuthorizationHandler authorizationHandler = new AuthorizationHandler();
ValidationHandler validationHandler = new ValidationHandler();
authenticationHandler.SetNextHandler(authorizationHandler);
authorizationHandler.SetNextHandler(validationHandler);
Request request = new Request { Content = "Sample request"};
authenticationHandler.HandleRequest(request);