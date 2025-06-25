Console.WriteLine("The World!");

Factory factory = new() { Name = "СевMаш", Income = 1000000 };
factory.ShowInfo();
factory++;
factory.ShowInfo();

Factory bmw = new() { Name = "BMW", Income = 1000000000 };
Factory autovaz = new() { Name = "AutoVAZ", Income = -100000 };

if (bmw)
    Console.WriteLine("income > 0");
else
    Console.WriteLine("income <= 0");

if (autovaz)
    Console.WriteLine("выручка > 0");
else
    Console.WriteLine("выручка <= 0");

Factory bmwvaz = bmw + autovaz;
bmwvaz.ShowInfo();

Factory factory1 = new() { Name = "СевMаш", Income = 1000000 };
Factory factory2 = new() { Name = "СевMаш", Income = 1000000 };

if (factory1 == factory2)
    Console.WriteLine("factory1 == factory2");
else
    Console.WriteLine("factory1 != factory2");

