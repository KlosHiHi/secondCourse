await ShowPowerAsync(3, 4);
await ShowPowerAsync(-2, 7);
await ShowPowerAsync(5.2, 2);

Console.WriteLine();

await Task.WhenAll(ShowPowerAsync(-3, 3), ShowPowerAsync(2.4, 2), ShowPowerAsync(5, -3));

async Task ShowPowerAsync(double a, int x)
{
    Console.WriteLine($"{a}^{x}={Math.Pow(a, x)}");
}