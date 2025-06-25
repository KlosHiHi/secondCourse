string[] strings = [
    "Здравствуйте! Чудесного дня.",
    "Привет!!!",
    "Здравствуй, как дела?",
    "Здравствуйте! Прекрасного вечара.",
    "Привет, ты где?",
    "Здраствуй, приедешь сегодня?"
    ];

bool check = false;

Console.Write("Введите начало строки: ");
string text = Console.ReadLine();

Console.WriteLine();

foreach (string item in strings)
    if (item.StartsWith(text))
    {
        Console.WriteLine(item);
        check = true;
    }

if(!check) 
    Console.WriteLine("Ничего не найдено");