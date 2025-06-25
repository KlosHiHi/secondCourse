CancellationTokenSource cts = new();

await Task.Run(async () =>
{
    ReadLinesAsync("numbers.txt");
    await Task.Delay(3000, cts.Token);
    Console.WriteLine("Операция выполнялась дольше 3 секунд");
}, cts.Token);

async Task ReadLinesAsync(string fileName)
{
    Console.WriteLine($"чтение из файла {fileName} начато");

    using (StreamReader reader = new(fileName))
    {
        string? line;
        while ((line = await reader.ReadLineAsync()) != null)
        {
            Console.WriteLine($"{fileName}:{line}");
        }
    }

    Console.WriteLine($"чтение из файла {fileName} закончено");
}