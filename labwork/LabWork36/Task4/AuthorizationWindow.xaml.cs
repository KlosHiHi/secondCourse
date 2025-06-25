using System.Windows;
using System.Windows.Controls;

namespace Task4
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {

            if (LoginTextBox.Text == "admin" && PasswordBox.Password == "qwerty")
            {
                AdminWindow admin = new();
                Hide();
                admin.ShowDialog();
                ShowDialog();
            }
            else if (LoginTextBox.Text == "manager" && PasswordBox.Password == "12345")
            {
                ManagerWindow manager = new();
                Hide();
                manager.ShowDialog();
                ShowDialog();
            }
            else
            {
                MessageBox.Show("Произошла непредвиденная ошибка", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
