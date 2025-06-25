Console.WriteLine("methods"); //статический метод

Person person1 = new();
Person person2 = new("vanya");
Person person3 = new("vanya", 14);

var login = "admin";
login = login.FormatName(); //параметр.МетодРасширения()
Console.WriteLine(login);

double x = 10.322;
int y = x.ToInt();

//имяПараметра: значениеАргумента

Add(b: 5, a: 2); // 5+2 = 7
Subtract(5, 2); // 5-2 = 7
Subtract(b: 5, a: 2); // 2-5 = -3

static int Add(int a, int b = 1) => a + b;

static int Subtract(int a, int b) => a - b;

static void PrintValueInfo(params object[] values)
{
    foreach (object value in values)
        Console.WriteLine($"{value} - {value.GetType()}");
    Console.WriteLine();
}

static void GetAbs(ref double x)
{
    if (x < 0)
        x = -x;
}

static void Swap(ref int x, ref int y) => (x, y) = (y, x);

static void Sum(int a, int b, out int sum) => sum = a + b;

x = Add(5, 2); // x = 7
x = Add(y, 3); // x = 13

PrintValueInfo(x, y);
PrintValueInfo(12, "gg", 0.1, true);
PrintValueInfo([23, "vsd", 9.8, false]);

// in
// ref (reference)

x = -50;
Console.WriteLine(x);
GetAbs(ref x);
Console.WriteLine(x);

int a = 5, b = 3;
Swap(ref a, ref b);

// out

int count;
Int32.TryParse("123", out count);
Console.WriteLine(count); // 123

Int32.TryParse("123abs", out count);
Console.WriteLine(count); // 0

Sum(12, 7, out a); // a = 19