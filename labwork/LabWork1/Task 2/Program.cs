Console.WriteLine("Bubble Sort\n");

int[] numbers = { 7, 0, -4, 3, 1, -2, 5 };

PrintArray(numbers);

BubbleSort(numbers);

static void BubbleSort(int[] numbers)
{
    for (int i = 0; i < numbers.Length - 2; i++)
    {
        for (int j = 0; j < numbers.Length - 1; j++)
        {
            if (numbers[j] > numbers[j + 1] )
            {
                int temp = numbers[j];
                numbers[j] = numbers[j + 1];
                numbers[j + 1] = temp;
            }

            PrintArray(numbers);
        }
    }
}

static void PrintArray(int[] numbers)
{
    foreach (int n in numbers)
        Console.Write(n + " ");
    Console.WriteLine();
}

//Сложность О(n^2)