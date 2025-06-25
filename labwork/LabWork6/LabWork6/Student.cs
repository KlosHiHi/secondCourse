class Student
{
    private string _fullName;
    private string _speciality;
    private int _course;

    public Student()
        : this("unknown", "unknown", 0)
    { }

    public Student(string fullName, string speciality, int course)
    {
        this._fullName = fullName;
        this._speciality = speciality;
        this._course = course;
    }

    public object this[string index]
    {
        get
        {
            if (index == "fullName")
                return _fullName;
            if (index == "speciality")
                return _speciality;
            if (index == "course")
                return _course;
            return null;
        }
    }

    public char this[int index]
    {
        get
        {
            if (index >= 0 && index < _fullName.Length)
                return _fullName[index];
            return '\0';
        }
    }
}

