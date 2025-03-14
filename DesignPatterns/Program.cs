﻿using DesignPatterns.Adapter;
using DesignPatterns.Bridge;
using DesignPatterns.Builder;
using DesignPatterns.ChainOfResponsibility;
using DesignPatterns.Command;
using DesignPatterns.Composite;
using DesignPatterns.Decorator;
using DesignPatterns.Facade;
using DesignPatterns.Factory;
using DesignPatterns.FlyWeight;
using DesignPatterns.Iterator;
using DesignPatterns.Memento;
using DesignPatterns.Observer;
using DesignPatterns.Prototype;
using DesignPatterns.Proxy;
using DesignPatterns.State;
using DesignPatterns.Strategy;
using DesignPatterns.Template;
using DesignPatterns.Visitor;

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

// Bridge
Radio radio = new Radio();
BaseRemote remote = new BaseRemote(radio);
remote.Power();
Console.WriteLine(radio);
Tv tv = new Tv();
AdvancedRemote advRemote = new AdvancedRemote(tv);
advRemote.Power();
advRemote.Mute();
Console.WriteLine(tv);

// State
VendingMachineContext vendingMachine =  new VendingMachineContext();
vendingMachine.SetState(new ReadyState());
vendingMachine.Request();
vendingMachine.SetState(new ProductSelectedState());
vendingMachine.Request();
vendingMachine.SetState(new PaymentPendingState());
vendingMachine.Request();
vendingMachine.SetState(new OutOfStockState());
vendingMachine.Request();

// Builder
GamingLaptopBuilder builder = new GamingLaptopBuilder();
BuildDirector director = new BuildDirector();
director.Construct(builder);
Console.WriteLine(builder.Laptop);

// Memento
CodeEditor codeEditor = new CodeEditor();
History history  = new History();
codeEditor.Content = "Content 1";
history.Push(codeEditor.CreateState());
codeEditor.Content = "Content 2";
history.Push(codeEditor.CreateState());
codeEditor.Content = "Content 3";
history.Push(codeEditor.CreateState());
codeEditor.Content = "Content 4";
codeEditor.Restore(history.Pop());
Console.WriteLine(codeEditor.Content);
codeEditor.Restore(history.At(0));
Console.WriteLine(codeEditor.Content);

// Facade
Order order = new Order();
order.OrderFood();

// Flyweight
Forest forest = new Forest();
for (int i = 0; i < 100000; i++)
{
    forest.PlantTree(0, 0, "Oak");
}

// Template
string message = "This is the template pattern";
Facebook fb = new Facebook("user", "123");
Instagram ig = new Instagram("user", "123");
fb.Post(message);
ig.Post(message);

// Visitor
Computer computer = new Computer();
computer.Accept(new ComputerPartDisplayVisitor());

// Proxy
ImageProxy image = new ImageProxy("test.jpg");
image.Display();
image.Display();