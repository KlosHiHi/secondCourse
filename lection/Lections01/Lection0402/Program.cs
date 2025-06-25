using Word = Microsoft.Office.Interop.Word;
Console.WriteLine("MS Office");

WordWork();

using ExcelManager manager = new();
{
    var fileName1 = Path.Combine(Environment.CurrentDirectory, "4.xlsx");
    var fileName2 = Path.Combine(Environment.CurrentDirectory, "3.xlsx");
    manager.SaveAs(fileName1, fileName2);
}


void WordWork()
{
    var app = new Word.Application(); // запуск Excel
    app.Visible = true;

    var fileName = Path.Combine(Environment.CurrentDirectory, "1.docx");
    var document = app.Documents.Open(fileName);

    document.Save();

    var saveFileName = Path.Combine(Environment.CurrentDirectory, "1.pdf");
    document.SaveAs(saveFileName, Word.WdSaveFormat.wdFormatPDF);
}