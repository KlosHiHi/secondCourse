class Worker : Person
{
    public string Post { get; set; }

    public Worker(int age, string name, string post)
        : base(age, name)
    {
        Post = post;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();    // необязательно base.ShowInfo()
        Console.WriteLine($"должность: {Post}");
    }

    //public override string ToString() 
    //    => $"{Name}, должность: {Post}";
}
