struct Triangle
{
    public Triangle(int sideA, int sideB, int sideC)
    {
        SideA = sideA;
        SideB = sideB;
        //SideC = sideC;
    }

    public int sideC;

    public int SideA { get; set; }
    public int SideB { get; set; }
    public int SideC { get; set; }

    public string Name
    {
        get => "треугольник";
    }

    public int GetPerimeter()
        => SideA + SideB + SideC;
}