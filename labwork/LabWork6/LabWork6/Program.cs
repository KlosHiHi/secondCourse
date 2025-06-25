internal class Program
{
    static int Square(int side) => side * side;

    static int Square(int height, int width) => height * width;

    static double RatFunction(double x) 
        => x == 0 ? -1 : 1 / x;

    static double RatFunction(double x, int n)
    {
        if (n > 0 && x != 0)
        {
            double y = x;
            for (int i = 0; i < n - 1; i++)
                x *= y;

            return 1 / x;
        }
        if (n == 0 && x != 0)
            return 1;

        return -1;
    }

    private static void Main(string[] args)
    {
        Console.WriteLine(Square(4));
        Console.WriteLine(Square(3, 6));

        Console.WriteLine(RatFunction(3));
        Console.WriteLine(RatFunction(0, 2));

        Student student = new();
        Student dmitry = new("Володин Дмитрий Кондратьевич", "автомеханик", 2);

        Console.WriteLine(student[1]);
        Console.WriteLine(dmitry["speciality"]);
    }
}