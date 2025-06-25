using System.Text;

#region Task1
int Sum(int a, int b)
    => a + b;
#endregion

#region Task2
int r1 = 2, r2 = 1, n = 5, sum1;
double ringSquare = Math.PI * (r1 - r2) * (r1 + r2);
ringSquare = ringSquare >= 0 ? ringSquare : -ringSquare;

sum1 = (1 + n) * n / 2;

string GetSize(long bytes)
{
    return bytes >= 1 << 30
        ? $"{bytes >> 30} ГБ"
        : bytes >= 1 << 20
        ? $"{bytes >> 20} МБ"
        : bytes >= 1 << 10
        ? $"{bytes >> 10} КБ"
        : $"{bytes} Б";
}
#endregion

#region Task3
void FindSum(int[] numbers)
{
    if (numbers.Length == 0)
        throw new InvalidOperationException("в массиве нет чисел");

    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
        sum += numbers[i];

    Console.WriteLine($"sum = {sum}");
}

int GetDaysCount(short month, int year)
{
    if (month <= 0 || month > 12)
        return -1;
    if (month == 2)
        return year % 4 == 0 ? 29 : 28;
    if (month == 4 || month == 6 || month == 9 || month == 11)
        return 30;
    return 31;
}
#endregion

#region Task4
List<Cat> cats = new List<Cat>
{
    new Cat { Id = 1, Name = "Усатик", Breed = "Персидская", Color = "Белый", Age = 5 },
    new Cat { Id = 2, Name = "Варежка", Breed = "Сиамская", Color = "Сил-пойнт", Age = 3 },
    new Cat { Id = 3, Name = "Дымок", Breed = "Британская короткошерстная", Color = "Серый", Age = 7 },
    new Cat { Id = 4, Name = "Белла", Breed = "Мейн-кун", Color = "Рыжий", Age = 4 },
    new Cat { Id = 5, Name = "Макс", Breed = "Рэгдолл", Color = "Сил-миттед", Age = 2 },
    new Cat { Id = 6, Name = "Луна", Breed = "Персидская", Color = "Трехцветный", Age = 6 },
    new Cat { Id = 7, Name = "Оливер", Breed = "Британская короткошерстная", Color = "Черный", Age = 8 },
    new Cat { Id = 8, Name = "Клео", Breed = "Сиамская", Color = "Коричневый", Age = 3 },
    new Cat { Id = 9, Name = "Симба", Breed = "Мейн-кун", Color = "Рыжий", Age = 5 },
    new Cat { Id = 10, Name = "Ромашка", Breed = "Персидская", Color = "Белый", Age = 2 }
};

StringBuilder builder = new();
builder.Append("Id;Name;Breed;Color;Age");

foreach (Cat cat in cats)
    builder.Append($"\n{cat.Id};{cat.Name};{cat.Breed};{cat.Color};{cat.Age}");

Console.WriteLine(builder);
#endregion

Console.WriteLine();

#region Task5
Dictionary<int, long> factorialDictionary = new();

long Factorial(int a)
{
    if (factorialDictionary.ContainsKey(a))
        return factorialDictionary[a];
    long result = a <= 0 ? -1
        : a == 0 ? 1
        : a == 1 ? 1
        : a * Factorial(a - 1);
    factorialDictionary.Add(a, result);
    return result;
}

Console.WriteLine(Factorial(4));
Console.WriteLine(factorialDictionary[4]);

static double FastPower(double x, int n)
{
    return n < 0 
        ? -1 : n == 0
        ? 1 : n == 1
        ? x : n % 2 == 0 
        ? FastPower(x * x, n / 2) : x * FastPower(x * x, (n - 1) / 2);
}

Console.WriteLine(FastPower(3, 4));
Console.WriteLine(FastPower(2, 7));
#endregion