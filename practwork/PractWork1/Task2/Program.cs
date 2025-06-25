Console.WriteLine("[Запись текста в файл]");

Console.Write("Введите имя файла: ");
string fileName = Console.ReadLine();

WriteText(fileName);

Console.WriteLine("Запись окончена");

static void WriteText(string fileName)
{
    if (File.Exists(fileName))
        Console.WriteLine($"Файл {fileName} открыт на дозапись: ");
    else
        Console.WriteLine($"Файл {fileName} будет создан: ");

    string? line = "";

    do
    {
        File.AppendAllText(fileName, $"{line}\n");
        line = Console.ReadLine();
    } while (!(line == "end"));
}