using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var radioButton = e.OriginalSource as RadioButton;
            int.TryParse(radioButton.Content.ToString(), out int fontSize);

            MainTextBox.FontSize = fontSize;
        }

        private void LeftAligmentRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MainTextBox.TextAlignment = TextAlignment.Left;
        }

        private void CenterAligmentRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MainTextBox.TextAlignment = TextAlignment.Center;
        }

        private void RightAligmentRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MainTextBox.TextAlignment = TextAlignment.Right;
        }
    }
}