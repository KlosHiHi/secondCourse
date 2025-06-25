class Square : IPrinter, IFigure
{
    public double Side { get; set; } = 10;
    public string Name { get; } = "Квадрат";

    public double GetPerimeter()
        => Side * 4;

    public double GetSquare()
        => Side * Side;

    public void ShowInfo()
    {
        Console.WriteLine($"{Name} со стороной {Side}");
    }

    public void Print()
    {
        Console.WriteLine($"Длина стороны: {Side} см");
    }
}