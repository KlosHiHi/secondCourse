using Excel = Microsoft.Office.Interop.Excel;

var app = new Excel.Application();
app.Visible = true;

var template = Path.Combine(Environment.CurrentDirectory, "template.xlsx");
var workbook = app.Workbooks.Add(template);

var firstWorkSheet = workbook.Worksheets[1];
firstWorkSheet.Name = "Файлы";
firstWorkSheet.Cells[1, 1].Value = "номер файла";
firstWorkSheet.Cells[1, 2].Value = "имя файла";
firstWorkSheet.Cells[1, 3].Value = "размер файла";

var secondWorkSheet = workbook.Worksheets[2];
secondWorkSheet.Name = "Подпапки";
secondWorkSheet.Cells[1, 1].Value = "номер подпапки";
secondWorkSheet.Cells[1, 2].Value = "имя подпапки";

Console.WriteLine("Введите нужный путь: ");
string path = Console.ReadLine();

DirectoryInfo mainDirectory = new(path);
DirectoryInfo[] directories = mainDirectory.GetDirectories();
FileInfo[] files = mainDirectory.GetFiles();

for (int i = 1; i <= files.Length; i++)
{
    firstWorkSheet.Cells[i + 1, 1].Value = i;
    firstWorkSheet.Cells[i + 1, 2].Value = files[i - 1].Name;
    firstWorkSheet.Cells[i + 1, 3].Value = files[i - 1].Length;
}

for (int i = 1; i <= directories.Length; i++)
{
    secondWorkSheet.Cells[i + 1, 1].Value = i;
    secondWorkSheet.Cells[i + 1, 2].Value = directories[i - 1].Name;
}

var saveFileName = $@"{path}\directoryinfo.xlsx";
workbook.SaveAs(saveFileName);
app.Quit();