using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

public class ExcelManager : IDisposable
{
    private Excel.Application _app;
    private Excel.Workbook _workbook;
    private Excel.Worksheet _worksheet;
    private bool _disposed;

    public void SaveAs(string openFileName, string saveFileName)
    {
        _app = new Excel.Application();
        _app.Visible = true;

        _workbook = _app.Workbooks.Open(openFileName);

        _workbook.SaveAs(saveFileName);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (_disposed)
            return;

        if (disposing)
        {
            // TODO: освободить управляемое состояние (управляемые объекты)
        }

        // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить метод завершения
        // TODO: установить значение NULL для больших полей
        ReleaseComObject(_worksheet);
        ReleaseComObject(_workbook);
        if (_app != null)
        {
            _app.Quit();
            ReleaseComObject(_app);
        }

        _disposed = true;
    }

    // // TODO: переопределить метод завершения, только если "Dispose(bool disposing)" содержит код для освобождения неуправляемых ресурсов
    ~ExcelManager()
    {
        // Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
        Dispose(disposing: false);
    }

    public void Dispose()
    {
        // Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    private void ReleaseComObject(object comObject)
    {
        if (comObject is null) 
            return;

        Marshal.ReleaseComObject(comObject);
        comObject = null;
    }
}

