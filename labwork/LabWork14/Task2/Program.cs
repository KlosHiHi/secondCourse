using System.Text.RegularExpressions;

Console.Write("Введите строку: ");
string str = Console.ReadLine();

Regex regex = new(@"\s{2,}");

string result = regex.Replace(str, " ");

Console.WriteLine(result);

//ghb  sdd    sd    sd    d