namespace Task5
{
    public partial class ReplaceForm : Form
    {
        public delegate void ReplaceTextHandler(string s1, string s2);

        public ReplaceForm()
        {
            InitializeComponent();
        }

        public event ReplaceTextHandler ReplaceText;

        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            ReplaceText?.Invoke(SearchTextBox.Text, ReplaceTextBox.Text);
        }
    }
}
