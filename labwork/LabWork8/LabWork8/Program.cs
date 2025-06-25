Student student = new()
{
    FullName = "Алексей Дудин",
    Speciality = "автомеханик",
    Course = 3
};

Student jack = new()
{
    FullName = "Джек",
    Speciality = "повар",
    Course = 2
};

Student clone = new()
{
    FullName = "Джек",
    Speciality = "повар",
    Course = 2
};

Console.WriteLine(student.ToString());
Console.WriteLine(student);

Console.WriteLine();

if(jack.Equals(student))
    Console.WriteLine("Объекты одинаковые!");
else
    Console.WriteLine("Объекты разные :(");

if(jack.Equals(clone))
    Console.WriteLine("Объекты одинаковые");
else
    Console.WriteLine("Объекты разные :(");