struct Point2D
{
    public int X;
    public int Y;

    public Point2D(int n) : this(n, n)
    {
    }

    public Point2D(int x, int y)
    {
        X = x;
        Y = y;
    }
    public override string ToString()
        => $"x = {X} y = {Y}";
}