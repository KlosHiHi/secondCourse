Console.WriteLine("[Поиск и вывод списка файлов на экран]");

Console.Write("Введите имя папки:");
string directoryName = Console.ReadLine();
Console.Write("Введите часть имени файла:");
string searchFileName = Console.ReadLine();

FindFiles(directoryName, searchFileName);

static void FindFiles(string directoryName, string searchFileName)
{
    DirectoryInfo directoryInfo = new(directoryName);
    DirectoryInfo[] directories = directoryInfo.GetDirectories();
    directories.Append(directoryInfo);

    foreach (DirectoryInfo directory in directories)
    {
        foreach (FileInfo file in directory.GetFiles())
        {
            if (file.Name.Contains(searchFileName))
            {
                Console.WriteLine($"{file.FullName} [{file.Length}]");
            }
        }
    }
}