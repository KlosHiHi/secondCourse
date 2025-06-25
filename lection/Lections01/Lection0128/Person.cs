public class Person
{
    // данные класса - field
    private string _fullName;
    public static string Country;
    public const int MajorityAge = 18;
    private int _age;

    // функции класса

    public string FullName
    {
        get => _fullName;
        set
        {
            if (value.Trim() != "")
                _fullName = value.Trim();
        }
    }

    public int Age
    {
        get => _age;
        set
        {
            if (value >= 0)
                _age = value;
        }
    }

    public int BirthYear()
        => DateTime.Now.Year - Age;

    public void Print()
    {
        // this.поле
        Console.WriteLine($"name: {FullName}");
        Console.WriteLine($"country: {Country}");
        Console.WriteLine($"majority age: {MajorityAge}\n");
    }

    public Person(string fullName = "unknowm", int age = 18)
    {
        FullName = fullName;
        Age = age;
    }
}