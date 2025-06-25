Console.WriteLine(Factorial(-4));
Console.WriteLine(Factorial(0));
Console.WriteLine(Factorial(1));
Console.WriteLine(Factorial(6));

Console.Write("Введите основание факториала: ");
int.TryParse(Console.ReadLine(), out int number);

Console.WriteLine(Factorial(number));

static int Factorial(int n)
{
    return n < 0 ? 0 : n == 0 ? 1 : n == 1 ? 1 : n * Factorial(n - 1);
}

// Сложность O(n!)