Console.WriteLine(FastPower(2, 5));
Console.WriteLine(FastPower(2, 15));
Console.WriteLine(FastPower(1, -4));
Console.WriteLine(FastPower(6, 0));

Console.Write("Введите основание: ");
double.TryParse(Console.ReadLine(), out double number);

Console.Write("\nВведите степень числа: ");
int.TryParse(Console.ReadLine(), out int degree);

Console.WriteLine("\n" + FastPower(number, degree));

static double FastPower(double x, int n)
{
    return n < 0
        ? -1 : n == 0
        ? 1 : n == 1
        ? x : n % 2 == 0
        ? FastPower(x * x, n / 2) : x * FastPower(x * x, (n - 1) / 2);
}