// Task 1
/*
Arithmetic math = Square;
Console.WriteLine($"квадрат: {math(2)}");

math = Factorial;
Console.WriteLine($"факториал: {math(6)}");

math = Absolute;
Console.WriteLine($"модуль: {math(-3)}");
Console.WriteLine();
*/

// Task 2
/*
PrintArithmetic arithmetic = (x, y) => Console.Write($"сумма: {x + y},");
arithmetic += (x, y) => Console.Write($" разность: {x - y},");
arithmetic += (x, y) => Console.Write($" произведение: {x * y},");
arithmetic += (x, y) => Console.Write($" частное: {x / y}.");

arithmetic(4, 2);
Console.WriteLine();
Console.WriteLine();
*/

// Task 4

Arithmetic[] arithmetics = [
    Square,
    Factorial,
    Absolute,
    ];

foreach (Arithmetic item in arithmetics)
    Console.Write($"{item(5)} ");
Console.WriteLine();
Console.WriteLine();

// Task 5
foreach (Arithmetic item in arithmetics)
    PrintArithmetic(item, 3);

static void PrintArithmetic(Arithmetic arithDelegate, int n)
    => Console.WriteLine(arithDelegate(n));


static int Square(int x)
    => x * x;

static int Factorial(int x)
    => x < 0 ? 0 : x <= 1 ? 1 : x * Factorial(x - 1);

static int Absolute(int x)
    => x < 0 ? -x : x;