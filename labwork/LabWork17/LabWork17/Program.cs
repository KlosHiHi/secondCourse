DirectoryInfo directory = new DirectoryInfo(@"C:\Temp\ispp31\РПМ");
FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);

var task1File = files
    .Select(file => new { file.Name, file.DirectoryName, file.Length, file.CreationTime })
    .OrderBy(file => file.Name)
    .ThenByDescending(file => file.CreationTime);


Console.Write("Введите имя файла или его часть: ");
string name = Console.ReadLine();

var task2File = files
    .Where(file => file.Name.Contains(name));

int count = files.Count(file => file.Name.Contains(name));

Console.WriteLine($"Количество файлов: {count}");


var task3File1 = files
    .Select(file => file.Extension)
    .Distinct();

var task3File2 = files
    .GroupBy(file => file.Extension)
    .Select(group => new { Extension = group.Key, Count = group.Count() });


var task4File = files
    .Where(file => file.CreationTime.Date == DateTime.Now.Date)
    .OrderByDescending(file => file.CreationTime.Date)
    .Take(10);


var task5File = files
    .Select(file => new 
    { 
        file.Name,  
        file.Extension, 
        file.FullName,
        Length = file.Length >= 1048576 
            ? (file.Length >> 20).ToString() + "Мб" 
            : file.Length >= 1024 ? (file.Length >> 10).ToString() + "Кб" 
            : file.Length.ToString() + "Б",
    });