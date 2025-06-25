using System.Security.Cryptography;

foreach(string file in Directory.GetFiles("Y:\\МДК.01.01"))
    await ShowGetFileHash(file);

string CalculateHash(byte[] data)
{
    using var sha256 = SHA256.Create();
    return Convert.ToHexString(sha256.ComputeHash(data));
}

async Task ShowGetFileHash(string fileName)
{
    var data = await File.ReadAllBytesAsync(fileName);

    var hash = await Task.Run(async () => CalculateHash(data));

    Console.WriteLine($"{fileName} : {hash}");
}
