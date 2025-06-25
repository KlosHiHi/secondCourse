Console.Write("Введите число для поиска: ");
int.TryParse(Console.ReadLine(), out int value);

int[] sortedNumbers = { 1, 4, 7, 11, 17, 22, 54 };

Console.WriteLine($"Индекс элемента (бинарный): {BinarySearch(sortedNumbers, value)}");

static int BinarySearch(int[] numbers, int value)
{
    int left = 0;
    int right = numbers.Length - 1;

    do
    {
        int middle = (left + right) / 2;

        if (value == numbers[middle])
            return middle;

        if (value < numbers[middle])
            right = middle - 1;
        else
            left = middle + 1;

    } while (right >= left);

    return -1;
}