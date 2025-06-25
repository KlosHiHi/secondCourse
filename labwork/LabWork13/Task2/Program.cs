using System.Text;

// Task 2
Console.Write("Введите строку: ");
string text = Console.ReadLine();

Console.WriteLine(text);

text = text.Trim();

while (text.Contains("  "))
    text = text.Replace("  ", " ");

Console.WriteLine(text);

Console.WriteLine();

Console.Write("Регистр [В] верхний, [Н] нижний, [И] инвентрированный: ");
char letterCase = Char.ToUpper(Console.ReadKey().KeyChar);

Console.WriteLine();
if (letterCase == 'В' || letterCase == 'D')
{
    Console.WriteLine(text.ToUpper());
}
else if (letterCase == 'Н' || letterCase == 'Y')
{
    Console.WriteLine(text.ToLower());
}
else if (letterCase == 'И' || letterCase == 'B')
{
    StringBuilder builder = new(text);
    for (int i = 0; i < builder.Length; i++)
    {
        if (Char.IsLower(builder[i]))
            builder[i] = Char.ToUpper(builder[i]);
        else
            builder[i] = Char.ToLower(builder[i]);
    }

    Console.WriteLine(builder);
}
