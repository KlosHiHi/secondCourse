var task1 = ReadLinesAsync("numbers.txt");
var task2 = ReadLinesAsync("source.txt");
var task3 = ReadLinesAsync("data.txt");

await Task.WhenAll(task1, task2, task3);

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