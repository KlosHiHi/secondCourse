struct Student
{
    private string _fullName;
    private string _speciality;
    private int _course;
    public EducationalLevel edLevel;

    public string FullName
    {
        get => _fullName;
        set
        {
            if (value.Length > 1)
                _fullName = value;
        }
    }

    public string Speciality
    {
        get => _speciality;
        set
        {
            if (value.Length > 1)
                _speciality = value;
        }
    }

    public int Course
    {
        get => _course;
        set
        {
            if (value >= 0)
                _course = value;
        }
    }

    public Student() : this("unknown", "unknown", 0) { }

    public Student(string fullName, string speciality, int course)
    {
        FullName = fullName;
        Speciality = speciality;
        Course = course;
        edLevel = EducationalLevel.Baccalaureate;
    }

    public void ShowInfo()
        => Console.WriteLine($"{FullName} - {Speciality} {Course} курс [{edLevel}]");
}