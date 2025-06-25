using System.Text.RegularExpressions;

string dataFormatOne = "12.02.2005";
string dataFormatTwo = "23/12/1997";

Regex regex = new(@"\b(\d{1,2})(/|\.)(\d{1,2})(/|\.)(\d{2}|\d{4})\b");

string replacement = "$5-$3-$1";

Console.WriteLine(regex.Replace(dataFormatOne, replacement));
Console.WriteLine(regex.Replace(dataFormatTwo, replacement));
