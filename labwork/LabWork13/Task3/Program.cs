//Task 3
Console.Write("Введите текст: ");
string text = Console.ReadLine();

string[] textSentences = text.Split(['!', '.', '?'], StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine();
foreach (string item in textSentences)
    Console.WriteLine(item.Trim());

//Небольшой текст для проверки. Он нужен для проверки!! Вы же правильно его написали? Надеюсь на вас.