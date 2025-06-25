#region Список книг
List<string> books = ["Гарри Поттер", "Вий", "О, дивный новый мир"];

Console.Write("Сколько элементов вы хотите добавить: ");
int.TryParse(Console.ReadLine(), out int quantity);

for (int i = 0; i < quantity; i++)
{
    Console.Write($"- ");
    books.Add(Console.ReadLine());
}

for (int i = 0; i < books.Count; i++)
    Console.WriteLine($"[{i + 1}] - {books[i]}");

Console.WriteLine($"Количество элементов списка - {books.Count}");
#endregion

#region Словарь книг
Console.WriteLine();

Dictionary<int, string> students = new()
{
    [1] = "Крас Мазов",
    [2] = "Гарри Дюбуа",
    [3] = "Дик Маллен"
};

Console.Write("Сколько элементов вы хотите добавить: ");
int.TryParse(Console.ReadLine(), out int studentQuantity);

for (int i = 1; i <= studentQuantity; i++)
{
    Console.Write($"{i} - ");
    Console.Write("Введите номер зачётной книжки: ");
    int.TryParse(Console.ReadLine(), out int studentKey);
    Console.Write("Введите имя студента: ");
    if (students.TryAdd(studentKey, Console.ReadLine()))
        continue;
    else
    {
        i--;
        Console.WriteLine("Ошибка - такой ключ уже существует");
    }
}

foreach (var key in students.Keys)
    Console.WriteLine($"[{key}] - {students[key]}");

Console.WriteLine($"Количество студентов - {students.Count}");
#endregion

#region Работа со словарём
Console.WriteLine();

Console.Write("Введите ключ для поиска: ");
int.TryParse(Console.ReadLine(), out int findKey);
if (students.ContainsKey(findKey))
    Console.WriteLine($"Ключ существует - {students[findKey]}");
else
    Console.WriteLine("Ключа не существует!");

Console.WriteLine();

Console.Write("Какое значение ищете: ");
var findValue = Console.ReadLine();
int valueCount = 0;

foreach (var value in students.Values)
    if (value == findValue)
        valueCount++;

Console.WriteLine($"Количество совпадений - {valueCount}");

Console.WriteLine();

Console.Write("Введите ключ для удаления: ");
int.TryParse(Console.ReadLine(), out int deleteKey);
if (students.ContainsKey(deleteKey))
{ 
    Console.WriteLine($"Элемент удалён - {students[deleteKey]}");
    students.Remove(deleteKey);
}
else
    Console.WriteLine("Ключа не существует!");

foreach (var key in students.Keys)
    Console.WriteLine($"[{key}] - {students[key]}");
#endregion

Console.WriteLine();

Console.Write("Введите букву: ");
char findChar = Console.ReadKey().KeyChar;
Console.WriteLine();
foreach (string book in books)
{
    if (findChar == book[0])
        Console.WriteLine($"[{findChar}] - {book}");
}