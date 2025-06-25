class Student
{
    public string FullName { get; set; }
    public string Speciality { get; set; }
    public int Course { get; set; }

    public void Print()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        return $"Имя: {FullName}, Специальность: {Speciality}, Курс: {Course}";
    }

    public override bool Equals(object other)
    {
        if (!(other is Student))
            return false;

        Student otherStudent = (Student)other;

        return otherStudent.FullName == FullName &&
            otherStudent.Speciality == Speciality &&
            otherStudent.Course == Course;
    }
}