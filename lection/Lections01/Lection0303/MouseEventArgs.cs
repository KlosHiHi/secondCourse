using System.Drawing;

public class MouseEventArgs : EventArgs
{

    public int X { get; }
    public int Y { get; }

    public Point Location => new(X, Y);

    public MouseEventArgs(int x, int y)
    {
        X = x;
        Y = y;
    }
}