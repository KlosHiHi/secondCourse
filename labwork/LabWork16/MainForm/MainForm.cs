using Task5;

namespace MainForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ReplaceForm form = new ReplaceForm();
            form.ReplaceText += Form_ReplaceText;
        }

        public void Form_ReplaceText(string s1, string s2)
        {
            MainTextBox.Text = MainTextBox.Text.Replace(s1, s2);
        }

        private void OpenReplaceFormButton_Click(object sender, EventArgs e)
        {
            ReplaceForm form = new();
            form.Show();
        }
    }
}
