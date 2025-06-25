using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace Task3
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateMultiplicationTable_Click(object sender, EventArgs e)
        {
            var app = new Excel.Application();
            app.Visible = true;

            var workbook = app.Workbooks.Add();
            var worksheet = workbook.Worksheets[1];

            worksheet.Name = "Умножение";

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    worksheet.Cells[i + 9, j + 3].Value = i * j;
                }
            }
            worksheet.Cells[10, 4].Value = "";

            #region Task4
            var titleRange = worksheet.range[worksheet.Cells[9, 4], worksheet.Cells[9, 12]];
            titleRange.Merge();

            worksheet.Cells[9, 4].Value = "Таблица Умножения";
            worksheet.Cells[9, 4].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            worksheet.Cells[9, 4].Font.Bold = true;
            worksheet.Cells[9, 4].Font.Italic = true;
            worksheet.Cells[9, 4].Font.Size = 20;

            var cellRange = worksheet.range[worksheet.Cells[10, 4], worksheet.Cells[18, 12]];
            cellRange.Font.Size = 15;
            #endregion

            #region Task5
            titleRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            cellRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

            var multipliersRow = worksheet.range[worksheet.Cells[10, 4], worksheet.Cells[10, 12]];
            multipliersRow.Interior.Color = ColorTranslator.ToOle(Color.AliceBlue);
            var multipliersColumn = worksheet.range[worksheet.Cells[11, 4], worksheet.Cells[18, 4]];
            multipliersColumn.Interior.Color = ColorTranslator.ToOle(Color.AliceBlue);
            #endregion

            string fileName = Path.Combine(Environment.CurrentDirectory, "multiply.xlsx");
            workbook.SaveAs(fileName);

            MessageBox.Show("Таблица успешно создана");
            app.Quit();
        }
    }
}
