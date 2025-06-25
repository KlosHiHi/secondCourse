using System.Text.RegularExpressions;

Console.Write("Введите e-mail: ");
string email = Console.ReadLine();

Regex regex = new(@"^(?i)[\w-]+@(?i)[a-z]+(\.(?i)[a-z0-9]+)+$");

if(regex.IsMatch(email))
    Console.WriteLine(email);
else
    Console.WriteLine("Адрес некорректный");

// gigu-Lis312@mail.ru           - true
// 1skir@Ssks.sdvg.loe1.hu2.sus  - true
// foriS4@2giu.lol               - false
// foriS4@giu..lol.12ru          - false
// gistro@sd.                    - false