class Student : IComparable, IComparable<Student>, IEquatable<Student>, ICloneable
{
    public string FullName { get; set; } = "Неизвестен";
    public string Speciality { get; set; } = "Неизвестен";
    public int Course { get; set; } = 2;

    public override string ToString()
    {
        return $"{FullName}, специальность: {Speciality} курс: {Course}";
    }

    public int CompareTo(object? obj)
    {
        if (obj is Student student)
            return Course.CompareTo(student?.Course);
        throw new ArgumentException();
    }

    public int CompareTo(Student? other)
    {
        if (Course > other?.Course)
            return 1;
        if (Course < other?.Course)
            return -1;
        return 0;
    }

    public bool Equals(Student? other)
    {
        return FullName == other?.FullName && 
            Course == other?.Course && 
            Speciality == other?.Speciality;
    }

    public object Clone()
    {
        return new Student { FullName = FullName, Speciality = Speciality, Course = Course};
    }
}