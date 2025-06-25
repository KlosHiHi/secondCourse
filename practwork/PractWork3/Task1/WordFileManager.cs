using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;

class WordFileManager
{
    private Word.Application _app;
    private Word.Document _document;
    private Word.Range _range;
    private Word.Paragraph _paragraph;
    private Word.InlineShape _imageShape;
    private Word.Table _table;

    private const int FirstTable = 1;
    private const int FirstColumn = 1;
    private const int FirstRow = 1;
    private const int SecondColumn = 2;
    private const int FirstParagraph = 1;

    public void OpenTemplateFile(string templateName)
    {
        _app = new Word.Application();
        _app.Visible = true;
        string template = Path.Combine(Environment.CurrentDirectory, templateName);
        _document = _app.Documents.Add(template);
    }

    public void ReplaceText(string findText, string replaceText)
        => _document.Content.Find.Execute(FindText: findText, ReplaceWith: replaceText);

    public void AddRowsToTable(int rowsQuantity)
    {
        _table = _document.Tables[FirstTable];
        for (int i = 1; i <= rowsQuantity; i++)
        {
            _table.Rows.Add();
            _table.Cell(i + 1, FirstColumn).Range.Text = $"{i}";
        }
    }

    public void SaveAs(string fileName, int documentFormat)
    {

        if (documentFormat == 1)
            _document.SaveAs(fileName);
        else
            _document.SaveAs(fileName, Word.WdSaveFormat.wdFormatPDF);
    }

    public void CreateNewFile()
    {
        _app = new Word.Application();
        _app.Visible = true;
        _document = _app.Documents.Add();
    }

    public void InsertText(string text)
    {
        _paragraph = _document.Paragraphs.Add();
        _paragraph.Range.Text = $"{text}\n";
    }

    public void FormatStandart()
    {
        _document.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

        foreach (Word.Paragraph paragraph in _document.Paragraphs)
        {
            paragraph.Range.Font.Name = "Times New Roman";
            paragraph.Range.Font.Size = 14;
        }
    }

    public void InsertTable(int rowsQuantity)
    {
        _paragraph = _document.Paragraphs.Add();
        _paragraph.Range.Text = "Таблица 1 - Задания\n";

        _range = _paragraph.Range;
        _table = _document.Tables.Add(_range, rowsQuantity + 1, 2);

        _table.Cell(FirstRow, FirstColumn).Range.Text = "№";
        _table.Cell(FirstRow, SecondColumn).Range.Text = "Задания";

        for (int i = 1; i <= rowsQuantity; i++)
        {
            _table.Cell(i + 1, FirstColumn).Range.Text = $"{i}";
        }

        _table.Borders.InsideLineStyle = _table.Borders.OutsideLineStyle = 
            Word.WdLineStyle.wdLineStyleSingle;
    }

    public void InsertPicture(string imageName)
    {
        _paragraph = _document.Paragraphs[FirstParagraph];
        _paragraph.Range.Text = $"\n{_paragraph.Range.Text}";

        var image = Path.Combine(Environment.CurrentDirectory, imageName);
        _imageShape = _document.Paragraphs[FirstParagraph].Range.InlineShapes.AddPicture(image);

        _document.Paragraphs[FirstParagraph].Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
        _imageShape.Height = 50;
        _imageShape.Width = 50;
    }

    public void InsertDate()
    {
        _paragraph = _document.Paragraphs.Add();
        _paragraph.Range.InsertDateTime();
    }
}