using System.Configuration;
using System.Windows;

namespace Task2
{
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoginTextBox.Text = ConfigurationManager.AppSettings["Login"];
            PasswordTextBox.Text = ConfigurationManager.AppSettings["Password"];
            EmailTextBox.Text = ConfigurationManager.AppSettings["Email"];
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            string hash = ProgramManager.PasswordHasher(PasswordTextBox.Text);

            config.AppSettings.Settings["Login"].Value = LoginTextBox.Text;
            config.AppSettings.Settings["Password"].Value = hash;
            config.AppSettings.Settings["Email"].Value = EmailTextBox.Text;

            config.Save();

            ConfigurationManager.RefreshSection("appSettings");

            MessageBox.Show("Данные успешно сохранены", "Успех", MessageBoxButton.OK);
        }


    }
}
