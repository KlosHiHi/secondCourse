int[] numbers = { 1, 3, 7, 5, 8 };
Console.WriteLine(LocalMax(numbers));
int[] numbers1 = { 10, 3, 7, 5, 8 };
Console.WriteLine(LocalMax(numbers1));
int[] numbers2 = { 1, 3, 4, 5, 8 };
Console.WriteLine(LocalMax(numbers2));

static int LocalMax(int[] numbers)
{
    int max = numbers[0];
    if (numbers[0] > numbers[1])
        return numbers[0];
    for (int i = 1; i < numbers.Length - 1; i++)
    {
        if (numbers[i] > max)
            max = numbers[i];

        if (numbers[i - 1] < max && numbers[i + 1] < max)
            return max;
    }
    if (numbers[numbers.Length - 1] > numbers[numbers.Length - 2])
        return numbers[numbers.Length - 1];

    return -1;
}
