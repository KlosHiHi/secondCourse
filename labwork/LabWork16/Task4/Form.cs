namespace Task4
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void DigitButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            numberTextBox.Text += button.Text;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            numberTextBox.Text = "";
        }
    }
}
