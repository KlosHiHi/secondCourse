internal class Person
{
    public int Age { get; set; }
    public string Name { get; set; }

    public Person(int age, string name)
    {
        Age = age;
        Name = name;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"\n{Name}, возвраст: {Age}");
    }

    public sealed override string ToString()
        => $"{Name}, возвраст: {Age}";

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(this, obj))
            return true;

        return obj is Person person && Name == person.Name && Age == person.Age;
    }
}