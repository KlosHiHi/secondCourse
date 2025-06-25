var files = Directory.GetFiles("C:");

var result = files
    .Where(f => f.StartsWith("a"))
    .OrderBy(f => f)
    .Take(100);  //эти вычисления будут пропущены, так как не исопльзуются, а это lazy 

Console.WriteLine();

int n = 5;
// var x = Math.Pow(n, 2); - плохой вариант
int x = n * n;

//x = 1024 * n; // 1024 = 2^10 - плохой вариант
x = n << 10;

int bits = 800;
// int bytes = bits / 8; // 8 = 2^3
int bytes = bits >> 3;

int sum = 0;
//for (int i = 0; i <= n; i++)
//    sum += 1; плохой вариант
sum = (1 + n) * n / 2;

int GetAbs(int x)
{
    if (x < 0)
        x = -x; // x = x *(-1) - плохой вариант
    return x;
}

double GetPower(double x, int n)
{
    if (n==0) 
        return 1;
    if (n < 0) 
        return 1/GetPower(x, -n);
    return x * GetPower(x, n - 1);
}

var lines = File.ReadAllLines("miyau.mp3"); // выйграли во времени, но не по памяти

string? line;
StreamReader reader = new("miymiyau.mp4");
while (true)
{
    line = reader.ReadLine();
}

while ((line = reader.ReadLine()) != null)
{
}

