using System.Windows;

namespace Task1
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
            _login = Properties.Settings.Default.Login;
            _password = Properties.Settings.Default.Password;
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
