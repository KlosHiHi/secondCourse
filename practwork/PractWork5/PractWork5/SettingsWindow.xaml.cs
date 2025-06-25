using System.Windows;

namespace Task1
{
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoginTextBox.Text = Properties.Settings.Default.Login;
            PasswordTextBox.Text = Properties.Settings.Default.Password;
            EmailTextBox.Text = Properties.Settings.Default.Email;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Login = LoginTextBox.Text;
            Properties.Settings.Default.Password = PasswordTextBox.Text;
            Properties.Settings.Default.Email = EmailTextBox.Text;

            Properties.Settings.Default.Save();

            MessageBox.Show("Данные успешно сохранены", "Успех", MessageBoxButton.OK);
        }
    }
}
