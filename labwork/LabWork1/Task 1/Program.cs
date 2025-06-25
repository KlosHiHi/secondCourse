Console.WriteLine("Selection Sort\n");

int[] numbers = { 7, 0, -4, 3, 1, -2, 5 };

PrintArray(numbers);

SelectionSort(numbers);

static void SelectionSort(int[] numbers)
{
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        int min = numbers[i];
        int index = i;

        for (int j = i + 1; j < numbers.Length; j++)
        {
            if (numbers[j] < min)
            {
                min = numbers[j];
                index = j;
            }
        }

        if (index != i)
        {
            int temp = numbers[i];
            numbers[i] = min;
            numbers[index] = temp;
        }
        PrintArray(numbers);
    }
}

static void PrintArray(int[] numbers)
{
    foreach (int n in numbers)
        Console.Write(n + " ");
    Console.WriteLine();
} 

//Сложность О(n^2)