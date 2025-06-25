Console.WriteLine("[Чтение текста из файла]");
Console.Write("Введите название файла: ");
string fileName = Console.ReadLine();

ReadText(fileName);

static void ReadText(string fileName)
{
    if (!File.Exists(fileName))
    {
        Console.WriteLine($"Файл {fileName} не существует");
        return;
    }

    Console.WriteLine(File.ReadAllText(fileName));
}