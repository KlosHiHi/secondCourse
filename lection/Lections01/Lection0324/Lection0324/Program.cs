Console.WriteLine("async");

//CancellationTokenSource cts = new();
//cts.CancelAfter(1000);

//CancellationToken token = cts.Token;

//try
//{

//}
//catch (OperationCanceledException) 
//{

//}

var task1 = GetFactorialAsync(5);
var task2 = GetFactorialAsync(3);
var task3 = GetFactorialAsync(6);

var results = await Task.WhenAll(task1, task2, task3);

foreach (var result in results)
    Console.WriteLine(result);


//await Task.Run(async () =>
//{
//    if (token.IsCancellationRequested)
//        token.ThrowIfCancellationRequested();

//    Console.WriteLine("старт");
//    await Task.Delay(3000, token);
//    Console.WriteLine("финиш");
//}, token);


/*
cts.Cancel(); // отмена сразу после вызова метода
cts.CancelAfter(1000); // отмена после одной секунды

HttpClient client = new();
client.GetStreamAsync("...", cts.Token);


CancellationToken token = cts.Token;
Task.Run(() => { }, token);
*/

var json = await GetJsonAsync("example.com");
Console.WriteLine(json);

/*
Task task1 = Task.Run(() => ShowFactorial(3)); // проблема CPU
Task task2 = ShowFactorialAsync(6); // проблема ввода/вывода (IO)

await Task.WhenAll([task1, task2]);
await Task.WhenAll(task1, task2);

List<Task> tasks = [task1, task2];
await Task.WhenAll(tasks);*/

/*
var text = await ReadFileAsync("1.txt");
await ReadFileAsync("1.txt");

await Task.Run(() => ShowFactorial(5));
var f = await Task.Run(() => GetFactorial(5));
Console.WriteLine(f);

Console.ReadKey();*/



static void ShowFactorial(int n) //синхронный и не возвращает
{
    long result = 1;
    for (int i = 2; i <= n; i++)
        result *= i;
    Console.WriteLine($"{n}! = {result}");
}

static async Task ShowFactorialAsync(int n)
    => await Task.Run(() => ShowFactorial(n));

static long GetFactorial(int n) //асинхронный и возвращает
{
    long result = 1;
    for (int i = 2; i <= n; i++)
        result *= i;
    return result;
}

static async Task<string> GetFactorialAsync(int n) 
    => $"{n}! = {GetFactorial(n)}";

static async Task<string> ReadFileAsync(string fileName)
{
    using StreamReader reader = new(fileName);
    return await reader.ReadToEndAsync();
}

static async Task<string> ReadFileAsync2(string fileName)
{
    using (StreamReader reader = new(fileName))
    {
        return await reader.ReadToEndAsync();
    }
    return null;
}

static async Task<string> GetJsonAsync(string url)
{
    Console.WriteLine("start");
    await Task.Delay(3000); //3000ms = 3s
    Console.WriteLine("finish");
    return "[]";
}