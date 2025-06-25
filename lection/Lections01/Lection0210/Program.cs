using System.Text.RegularExpressions;

#region enumeration
ConsoleColor color = ConsoleColor.Green;
DayOfWeek dayOfWeek = DayOfWeek.Monday;

for (int i = 0; i < 16; i++)
{
    ConsoleColor coloric = (ConsoleColor)i;
    Console.BackgroundColor = (ConsoleColor)i;
    Console.WriteLine(coloric);
}

Console.BackgroundColor = ConsoleColor.Black;

RegexOptions regOpt = RegexOptions.Multiline | RegexOptions.IgnoreCase | RegexOptions.RightToLeft;

SummerMonth month = SummerMonth.July;

Color purple = Color.Red | Color.Blue;
Color purple1 = Color.Purple;

Season season = (Season)3; // Season.Winter
int monthNumber = (int)month;  // 7
int purpleValue = (int)purple; // 1 + 4 = 5
#endregion

#region tuple(кортеж)
var point = (2, 5);
var point2d = (x: 0, y: 0);

Console.WriteLine(point2d);
point2d.x = 3; // тоже point2D.Item1 = 3;
point2d.y = 2;
Console.WriteLine(point2d);

(double, double, double) point3d = (0, 3, 5);

(int, string) user = (Id: 123, Login: "admin");
Console.WriteLine(user);
#endregion