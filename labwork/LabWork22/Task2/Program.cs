await WriteNumbersAsync("data.txt", 100_000);

Console.WriteLine("Конец программы");

async Task WriteNumbersAsync(string fileName, int numbersQuantity)
{
    Console.WriteLine($"запись в файл {fileName} начата");

    Random random = new();

    using (StreamWriter writer = new(fileName, false))
    {
        for (int i = 1; i <= numbersQuantity; i++)
            await writer.WriteLineAsync($"Число {i}: {random.Next()}");
    }

    Console.WriteLine($"запись в файл {fileName} окончена");
}