Console.Write("Введите число для поиска: ");
int.TryParse(Console.ReadLine(), out int value);

int[] numbers = { 5, 2, 3, 9, 4, 7 };

Console.WriteLine($"Индекс элемента (линейный): {LinearSearch(numbers, value)}");

static int LinearSearch(int[] numbers, int value)
{
    for (int i = 0; i < numbers.Length; i++)
        if (numbers[i] == value)
            return i;
    return -1;
}