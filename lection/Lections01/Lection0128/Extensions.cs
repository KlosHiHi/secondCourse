public static class Extensions
{
    public static string FormatName(this string name)
        => Char.ToUpper(name[0]) + name.Substring(1).ToLower();
    //Метод расширения для строки

    public static int ToInt(this double value) => (int)value;
}
