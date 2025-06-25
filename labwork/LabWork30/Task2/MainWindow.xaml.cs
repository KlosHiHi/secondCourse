using System.Windows;
using System.Windows.Controls;

namespace Task2
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

        private void ShowPasswordCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (ShowPasswordCheckBox.IsChecked.Value)
            {
                PasswordBox.Visibility = Visibility.Collapsed;
                PassworTextBox.Visibility = Visibility.Visible;
            }
            else
            {
                PasswordBox.Visibility = Visibility.Visible;
                PassworTextBox.Visibility = Visibility.Collapsed;
            }
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PassworTextBox.Text = PasswordBox.Password;
        }
    }
}