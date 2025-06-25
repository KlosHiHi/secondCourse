namespace Task1
{
    public partial class MainForm : Form
    {
        

        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateFileButton_Click(object sender, EventArgs e)
        {
            WordFileManager manager = new();

            manager.OpenTemplateFile("״אבכמם.docx");

            manager.ReplaceText("ׂוךסעָחֿמכÿֲגמהא", DocumentTextBox.Text);
            manager.ReplaceText("הה.לל.דדדד קק:לל", DateTime.Now.ToString());

            manager.AddRowsToTable((int)TaskQuantityNumericUpDown.Value);

            DocumentSaveFileDialog.ShowDialog();
            manager.SaveAs(DocumentSaveFileDialog.FileName, DocumentSaveFileDialog.FilterIndex);
        }

        private void CreateNewFileButton_Click(object sender, EventArgs e)
        {
            WordFileManager manager = new();

            manager.CreateNewFile();

            manager.InsertText(DocumentTextBox.Text);

            manager.FormatStandart();

            manager.InsertPicture("dark_smile.png");

            manager.InsertTable((int)TaskQuantityNumericUpDown.Value);

            manager.InsertDate();

            DocumentSaveFileDialog.ShowDialog();
            manager.SaveAs(DocumentSaveFileDialog.FileName, DocumentSaveFileDialog.FilterIndex);
        }
    }
}
