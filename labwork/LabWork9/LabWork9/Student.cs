class Student : IPrinter
{
    public string FullName { get; set; } = "Алексей Смирнов";
    public string Speciality { get; set; } = "врач-ветеринар";
    public int Course { get; set; } = 2;

    public void Print()
    {
        Console.WriteLine($"Имя: {FullName}, специальность: {Speciality}, курс: {Course}");
    }
}