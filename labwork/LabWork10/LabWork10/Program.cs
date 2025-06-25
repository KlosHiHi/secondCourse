Student student1 = new() { FullName = "Михаил", Speciality = "автомеханик", Course = 1 };
Student student2 = new() { FullName = "Сергей", Speciality = "инженер", Course = 3 };
Student student3 = new() { FullName = "Алексей", Speciality = "врач-нарколог", Course = 2 };
Student clone = new() { FullName = "Михаил", Speciality = "автомеханик", Course = 2 };

Student[] students = { student1, student2, student3, clone };
//PrintArray(students);

//Console.WriteLine();
//Array.Sort(students);
//PrintArray(students);

//Console.WriteLine();
//Array.Sort(students);
//PrintArray(students);

//Console.WriteLine();
//if (clone.Equals(student1))
//    Console.WriteLine("clone == student1");
//else
//    Console.WriteLine("clone != student1");

//Console.WriteLine();
Student student4 = new();
Console.WriteLine(student4);
student4 = (Student)student3.Clone();
Console.WriteLine(student4);

Console.WriteLine();
PrintArray(students);
Array.Sort(students, new StringComparer());
Console.WriteLine();
PrintArray(students);

Array.Sort(students, new DescendingComparer());
Console.WriteLine();
PrintArray(students);

static void PrintArray(object[] array)
{
    foreach (Student item in array)
        Console.WriteLine(item);
}