Console.WriteLine("[Построчное чтение файла]");

Console.Write("Введите имя текстового файла: ");
string fileName = Console.ReadLine();
Console.Write("Введите искомое предложение, слово или символ: ");
string searchItem = Console.ReadLine();

FindLines(fileName, searchItem);

static void FindLines(string fileName, string searchLine)
{
    if (!File.Exists(fileName))
        return;

    string[] lines = File.ReadAllLines(fileName);

    for (int i = 0; i < lines.Length; i++)
    {
        if (lines[i].Contains(searchLine))
            Console.WriteLine($"[{i}] {lines[i]}");
    }
}