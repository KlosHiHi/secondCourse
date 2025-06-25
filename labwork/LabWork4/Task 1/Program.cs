//int[] coins = { 10, 5, 2, 1 };
int[] coins = { 4, 3, 1 };

GiveCoins(coins, -12);
Console.WriteLine();
GiveCoins(coins, 0);
Console.WriteLine();
GiveCoins(coins, 6);
Console.WriteLine();

Console.Write("Размер сдачи: ");
int.TryParse(Console.ReadLine(), out int value);

GiveCoins(coins, value);

static void GiveCoins(int[] coins, int value)
{
    int[] result = new int[100];
    int counter = 0;

    for (int i = 0; i < coins.Length; i++)
    {
        while (value >= coins[i])
        {
            result[counter] = coins[i];
            value -= coins[i];
            counter++;
        }
    }

    if (value == 0)
        PrintArray(result);
    else
        Console.WriteLine("Ошибка");
}

static void PrintArray(int[] array)
{
    foreach (int i in array)
        if (i != 0)
            Console.WriteLine(i + " ");
}