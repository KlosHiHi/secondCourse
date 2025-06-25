class Student
{
    public string Name { get; set; } = "unknown";
    public string Speciality { get; set; } = "unknown";
    public int Course { get; set; } = 0;

    public void Print()
        => Console.WriteLine($"ФИО: {Name}, cпециальность: {Speciality}, курс: {Course}");

    public static Student operator ++(Student student)
        => new()
        {
            Name = student.Name,
            Speciality = student.Speciality,
            Course = student.Course + 1
        };

    public static Student operator +(Student student1, Student student2)
        => new()
        {
            Name = student1.Name,
            Speciality = student1.Speciality,
            Course = student1.Course + student2.Course
        };

    public static bool operator ==(Student student1, Student student2)
    {
        if (ReferenceEquals(student1, student2))
            return true;

        return student1.Name == student2.Name &&
            student1.Speciality == student2.Speciality &&
            student1.Course == student2.Course;
    }

    public static bool operator !=(Student student1, Student student2)
        => !(student1 == student2);

    public static bool operator true(Student student)
        => student.Course >= 0;

    public static bool operator false(Student student)
        => student.Course < 0;
}