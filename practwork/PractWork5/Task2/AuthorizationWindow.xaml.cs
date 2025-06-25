using System.Configuration;
using System.Windows;

namespace Task2
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

            _login = ConfigurationManager.AppSettings["Login"];
            _password = ConfigurationManager.AppSettings["Password"];

            string hash = ProgramManager.PasswordHasher(PasswordBox.Password);

            if (_login == LoginTextBox.Text && _password == hash)
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
