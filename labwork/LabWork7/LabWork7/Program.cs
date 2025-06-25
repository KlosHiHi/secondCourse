Student jack = new() { Name = "jack", Speciality = "UI", Course = 2 };
Student bob = new() { Name = "bob", Speciality = "OO", Course = -1 };
Student clone = new() { Name = "jack", Speciality = "UI", Course = 2 };
Student student = new();

Console.WriteLine($"до применения (++): курс = {student.Course}");
student++;
Console.WriteLine($"после применения (++): курс = {student.Course}");

Console.WriteLine("\nдо применения (+):");
jack.Print();
bob.Print();
student = bob + jack;
Console.WriteLine("после применения (bob + jack):");
student.Print();

Console.WriteLine($"\nприменение (==)");
jack.Print();
clone.Print();
Console.WriteLine(jack == clone);

Console.WriteLine($"\nприменение (!=)");
Console.WriteLine(jack != clone);

Console.WriteLine("\nприменение операторов true и false");
if (jack)
    Console.WriteLine("(jack) курс - положительно число!");
else
    Console.WriteLine("(jack) курс - отрицательный :(");

if (bob)
    Console.WriteLine("(bob) курс - положительно число!");
else
    Console.WriteLine("(bob) курс - отрицательный :(");