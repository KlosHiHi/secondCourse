using System.IO;
using System.Windows;

namespace Task3
{
    public partial class AuthorizationWindow : Window
    {
        private string _login;
        private string _password;

        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var txt = File.ReadAllLines("userData.txt");
            _login = txt[0];
            _password = txt[1];

            if (_login == LoginTextBox.Text && _password == PasswordBox.Password)
            {
                SettingsWindow settings = new()
                {
                    Owner = this,
                    WindowStartupLocation = WindowStartupLocation.CenterScreen,
                };

                Hide();
                settings.ShowDialog();
                ShowDialog();
            }
            else
                MessageBox.Show("Введённые данные некоректны", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

        }
    }
}
