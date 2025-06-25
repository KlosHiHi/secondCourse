using System.Text.RegularExpressions;

Console.WriteLine("[Сортировка файлов по папкам]");

Console.Write("Введите имя папки:");
string directoryName = Console.ReadLine();

SortFiles(directoryName);

static void SortFiles(string directoryName)
{
    DirectoryInfo directoryInfo = new(directoryName);
    Regex regex = new(@"\b(\d{1,2})(\.)(\d{1,2})(\.)(\d{2}|\d{4})( \d{1,2}:\d{2}:\d{2})\b");
    string replacement = @"$5\$3\$1";

    foreach (FileInfo file in directoryInfo.GetFiles())
    {
        string creationDate = regex.Replace(file.CreationTime.Date.ToString(), replacement);
        string filePath = Path.Combine(directoryName, creationDate);

        Console.WriteLine(filePath);

        if (Directory.Exists(filePath))
            file.MoveTo($@"{filePath}\{file.Name}");
        else
        {
            Directory.CreateDirectory(filePath);
            file.MoveTo($@"{filePath}\{file.Name}");
        }
    }
}
