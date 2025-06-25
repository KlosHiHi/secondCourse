public class Cat(string name, int age)
{
    public int breed { get; set; }

    private string master = "Узбек";

    public string Master
    {
        get { return master; }
        set { master = value; }
    }

    public Cat() : this("kis-kisich", 4)
    {
    }

    public void Print() 
        => Console.WriteLine($"name: {name}\nage: {age}\n");
}
