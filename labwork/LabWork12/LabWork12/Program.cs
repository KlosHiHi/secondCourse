Student student1 = new();
Student student2 = new( "Виктория Полумракова", "детский воспитатель", 3);

student1.ShowInfo();
student2.ShowInfo();

Console.WriteLine();

student1 = new() { FullName = "s", Speciality = "эл", Course = -1};
student2 = new() { FullName = "Андрей Воронин", Speciality = "врач-педиатр", Course = 1};

student1.ShowInfo();
student2.ShowInfo();

Console.WriteLine();

Applicant applicant1 = new("Юлия Филлиповская", 11, 4.7);
Applicant applicant2 = new("Григорий Малкович", 9, 3.3);
Applicant applicant3 = new("Юлия Филлиповская", 11, 4.7);

Console.WriteLine(applicant1);
Console.WriteLine(applicant2);
Console.WriteLine(applicant3);

Console.WriteLine();

if(applicant1.Equals(applicant2))
    Console.WriteLine("applicant1 == applicant2");
else
    Console.WriteLine("applicant1 != applicant2");

if (applicant1.Equals(applicant3))
    Console.WriteLine("applicant1 == applicant3");
else
    Console.WriteLine("applicant1 != applicant3");