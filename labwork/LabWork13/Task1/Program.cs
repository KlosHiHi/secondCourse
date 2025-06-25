//Task 1
Console.Write("Введите строку: ");
string text = Console.ReadLine();

Console.WriteLine($"\nДлина строки [{text.Length}]");
Console.WriteLine($"Длина строки (без пробелов) [{text.Replace(" ", "").Length}]");

int countLetters = 0;

foreach (char c in text)
    if (Char.IsLetter(c))
        countLetters++;

Console.WriteLine($"Количество букв [{countLetters}]");

Console.Write($"\nКакой символ нужно найти: ");
string symbol = Console.ReadLine();

int index = text.IndexOf(symbol);

if (index == -1)
{
    Console.WriteLine("Такого символа нет!");
    return;
}

Console.Write("Индексы вашего символа: ");

while (index != -1)
{
    Console.Write(index + " ");
    index = text.IndexOf(symbol, index + 1);
}