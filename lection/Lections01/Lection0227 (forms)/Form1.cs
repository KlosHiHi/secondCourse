namespace Lection0227__forms_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenButtonton_Click(object sender, EventArgs e)
        {
            Form2 form = new();
            form.FormAction = ChangeText;
            form.ShowDialog();
        }

        private void ChangeText(string text)
        {
            label1.Text = text;
        }
    }
}
