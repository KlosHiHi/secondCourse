IService service = new DataService();
service.Execute();

Console.WriteLine();

service = new LoggingDecorator(service);
service.Execute();

Console.WriteLine();

IPizza pizza = new BasePizza();
Console.WriteLine($"{pizza.GetDescription()} {pizza.GetCost()}");

pizza = new Cheese(pizza);
pizza = new Cheese(pizza);
pizza = new Tomato(pizza);
pizza = new Pepperoni(pizza);
pizza = new Pepperoni(pizza);

Console.WriteLine($"{pizza.GetDescription()} {pizza.GetCost()}");

Console.WriteLine();