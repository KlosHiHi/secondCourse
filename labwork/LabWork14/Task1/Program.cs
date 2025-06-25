using System.Text.RegularExpressions;

Console.Write("Введите номер телефона: ");
string number = Console.ReadLine();

Regex regex = new Regex(@"^(\+7\(9|8\(9)\d\d\)\d\d\d-\d\d-\d\d$");

if(regex.IsMatch(number))
    Console.WriteLine(number);
else
    Console.WriteLine("Введён некорректный номер");

//8(923)049-90-90   - true
//+7(923)088-29-29  - true
//+7(923)0884-29-29 - false
//8(987654321-00    - false
//9(876)543-21-00   - false