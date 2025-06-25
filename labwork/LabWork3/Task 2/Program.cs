Console.WriteLine(Power(2, 0));
Console.WriteLine(Power(2, 1));
Console.WriteLine(Power(2, 3));
Console.WriteLine(Power(2, -3));
Console.WriteLine(Power(6, -5));

Console.Write("Введите основание: ");
double.TryParse(Console.ReadLine(), out double number);

Console.Write("\nВведите степень числа: ");
int.TryParse(Console.ReadLine(), out int degree);

Console.WriteLine("\n" + Power(number, degree));

static double Power(double x, int n)
{
    return n < 0 
        ? 1 / x * Power(x, n - 1) : n == 0 
        ? 1 : n == 1 
        ? x : n > 0 
        ? x * Power(x, n - 1) : -1;
}