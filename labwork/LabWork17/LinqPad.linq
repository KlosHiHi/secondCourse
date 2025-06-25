<Query Kind="Statements">
  <Output>DataGrids</Output>
  <AutoDumpHeading>true</AutoDumpHeading>
</Query>

DirectoryInfo directory = new DirectoryInfo(@"C:\Temp\ispp31\РПМ");
FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);


var task3File1 = files
    .Select(file => file.Extension)
    .Distinct()
	.Dump();

var task3File2 = files
    .GroupBy(file => file.Extension)
    .Select(group => new { Extension = group.Key, Count = group.Count() })
	.Dump();


var task4File = files
    .Where(file => file.CreationTime.Date == DateTime.Now.Date)
    .OrderByDescending(file => file.CreationTime.Date)
    .Take(10)
	.Dump();


var task5File = files
    .Select(file => new 
    { 
        file.Name, 
        file.Extension, 
        file.FullName,
        Length = file.Length >= 1048576 
            ? $"{(file.Length >> 20).ToString()} Мб" 
            : file.Length >= 1024 
			? $"{(file.Length >> 10).ToString()} Кб" 
            : $"{file.Length.ToString()} Б",
    })
	.Dump();