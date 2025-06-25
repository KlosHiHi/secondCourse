using System.Windows;

namespace LabWork36
{
    public partial class ClosingWindow : Window
    {
        public ClosingWindow()
        {
            InitializeComponent();
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
