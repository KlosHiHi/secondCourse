#region объявление объектов
Student unknown = new();
Student ivan = new("Иванов Иван Васильевич", "автомеханик", 1);
Student igor = new("Царетеев Игорь Пантелеевич", "автомеханик", 2);
Student ilya = new("Виноградов Илья Попович", "врач-хирург", 1);
Student jack = new("Джек Ричер", "авиаконструктор", 3);
Student koshi = new("Коши Чи Вуа", "врач-хирург", 8);

Student[] students = { unknown, ivan, igor, ilya, jack, koshi };
#endregion

Console.Write("Специальность: ");
string findValue = Console.ReadLine();
Console.WriteLine();

FirstFind(students, findValue);

Console.Write("Специальность: ");
findValue = Console.ReadLine();
Console.Write("Курс: ");
int.TryParse(Console.ReadLine(), out int findCourse);
Console.WriteLine();

SecondFind(students, findCourse, findValue );

void FirstFind(Student[] students, string special)
{
    foreach (Student s in students)
    {
        if (s.Speciality == special)
        {
            s.Print();
            Console.WriteLine();
        }
    }
}

void SecondFind(Student[] students, int course, string special)
{
    foreach (Student s in students)
    {
        if (s.Speciality == special && s.Course == course)
        {
            s.Print();
            Console.WriteLine();
        }
    }
}