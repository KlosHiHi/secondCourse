using System.Text.RegularExpressions;

Regex regex = new(@"^.*(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!.?]).{6,}$");

while (true)
{
    Console.Write("Введите пароль: ");
    string password = Console.ReadLine();

    if (regex.IsMatch(password))
    {
        Console.WriteLine($"{password} - надёжный пароль");
        return;
    }
    else
        Console.WriteLine("Пароль не надёжный");

    Console.WriteLine();
}

// 12dedSus!   - true
// 451D.e      - true
// 12dde2D     - false
// d?F1!       - false
// geGggeR1.d! - true