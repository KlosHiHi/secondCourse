Console.Write("Введите число для поиска: ");
int.TryParse(Console.ReadLine(), out int value);

int[] sortedNumbers = { 2, 5, 11, 13, 17, 33, 42 };

Console.WriteLine($"Индекс элемента (прыжками): {JumpSearch(sortedNumbers, value)}");

static int JumpSearch(int[] numbers, int value)
{
    int step = (int)Math.Sqrt(numbers.Length);
    int previousStep = 0;
    int nextStep = step;

    while (numbers[nextStep] < value)
    {
        previousStep = nextStep;
        nextStep += step;

        if (previousStep >= numbers.Length)
            return -1;
    }

    for (int i = previousStep; i <= nextStep; i++)
        if (numbers[i] == value)
            return i;

    return -1;
}