Console.WriteLine("Interfaces");

Car car = new() { Brand = "bently"};

Desk[] desks = [
    new () { Wood = "береза", Height = 200, Width = 100 },
    new () { Wood = "ясень", Height = 100, Width = 350 },
    new () { Wood = "дуб", Height = 400, Width = 100 }
    ];

foreach (Desk desk in desks)
    Console.WriteLine(desk);

Console.WriteLine();
Array.Sort(desks);

foreach (Desk desk in desks)
    Console.WriteLine(desk);