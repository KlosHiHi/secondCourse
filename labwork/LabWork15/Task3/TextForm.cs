namespace Task3
{
    public partial class TextForm : Form
    {
        public TextForm()
        {
            InitializeComponent();
        }

        private void OpenChangeFormButton_Click(object sender, EventArgs e)
        {
            ChangeForm form = new();
            form.ChangeText = ReplaceText;
            form.ShowDialog(); 
        }

        private void ReplaceText(string searchText, string changeText)
        {
            MainTextBox.Text = MainTextBox.Text.Replace(searchText, changeText);
        }
    }
}
