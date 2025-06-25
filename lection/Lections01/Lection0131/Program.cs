Console.WriteLine("Наследование классов");

var random = new PowerfullRandom();
Console.WriteLine(random.NextDouble(-7.8, 9));

object obj = new(); 
var factory = new Factory();

Console.WriteLine(obj.ToString());
Console.WriteLine(obj);
Console.WriteLine(factory);

Console.WriteLine(obj.Equals(factory)); //через экземпляр
Console.WriteLine(Factory.Equals(obj, factory)); // через класс

Console.WriteLine(obj.GetHashCode());

Console.WriteLine(obj.GetType());


Person person = new(20, "ubermarginal");
Worker worker = new(34, "german", "heavy");

person.ShowInfo();
Console.WriteLine(person.ToString());

worker.ShowInfo();
Console.WriteLine(worker.ToString());
Console.WriteLine(worker);