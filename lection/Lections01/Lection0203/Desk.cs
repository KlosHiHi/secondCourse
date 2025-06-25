
class Desk : IComparable
{
    public string Wood { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }

    public override string ToString()
    {
        return $"{Wood} стол, [{Height};{Width}]";
    }

    int IComparable.CompareTo(object? obj) 
        => throw new NotImplementedException(); // явная реализация интерфейса

    /*public int CompareTo(object? obj)
    {
        if (obj is Desk desk)
            return Wood.CompareTo(desk?.Wood);
        throw new ArgumentException();

        //var desk = obj as Desk;
        //return Height.CompareTo(desk?.Height);

        if (Height > desk.Height)
            return 1;
        if (Height < desk.Width)
            return -1;
        return 0;
    }*/
}