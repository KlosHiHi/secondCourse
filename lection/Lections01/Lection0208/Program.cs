#region generics
using System.Reflection;
using System.Text.RegularExpressions;

Print(123);
Print("123");
Print(123.0);
Print<double>(123);

int a = 4, b = 5;
Console.WriteLine($"a - {a}, b - {b}");
Swap(ref a, ref b);
Console.WriteLine($"a - {a}, b - {b}");

Console.WriteLine($"min = {MinValue(a, b)}");
Console.WriteLine();

static void Print<T>(T item)
    => Console.WriteLine($"{item} - {item?.GetType()}");

static void Swap<T>(ref T item1, ref T item2)
    => (item1, item2) = (item2, item1);

static T MinValue<T>(T x, T y)
    where T : IComparable
{
    return x.CompareTo(y) < 0 ? x : y;
}
#endregion

#region list
List<string> users = [ "admin", "prostak" ];

users.Add("dimon");
users.AddRange(["androind", "killer", "androind", "androind"]);

users.Insert(3, "forth");
users.InsertRange(0, ["guest1", "quoter"]);

users.Remove("killer");
users.RemoveAt(2);
users.RemoveAt(users.Count - 1);
users.RemoveRange(0, 2);
//users.Clear();
users.RemoveAll(u => u.StartsWith("guest"));

if(users.Contains("androind"))
    Console.WriteLine("androind is finded");
int firstIndex = users.IndexOf("androind");
int lastIndex = users.LastIndexOf("androind");

users.Sort();
users.Reverse();
users.BinarySearch("androind");

foreach (var user in users)
    Console.WriteLine(user);

Console.WriteLine();

//users[0] = "admin12";
//for (int i = 0; i < users.Count; i++)
//    Console.WriteLine(users[i]);
#endregion

#region dictionary
Dictionary<int, string> products = new();
products[100] = "tea";
products[200] = "coffee";
products[300] = "milk";

foreach(var product in products)
    Console.WriteLine($"{product.Key} - {product.Value}");

foreach(var key in products.Keys)
    Console.WriteLine($"{key} - {products[key]}");

foreach (var value in products.Values)
    Console.WriteLine($"- {value}");

if (products.ContainsKey(100))
    ;

if (products.ContainsValue("coffee"))
    ;

Console.WriteLine();
#endregion

#region структуры, записи
Person person1 = new() { Id=123, FullName="Bro" };
Console.WriteLine(person1);

Person person2 = new() { Id=123, FullName="Bro" };
Console.WriteLine(person2);
// Console.WriteLine(person.ToString());

if (person1.Equals(person2))
    Console.WriteLine("same");
else
    Console.WriteLine("not same");

Console.WriteLine();

Point2D point = new();
Console.WriteLine(point);

point = new(5);
Console.WriteLine(point);

point = new(15, 76);
Console.WriteLine(point);
#endregion
