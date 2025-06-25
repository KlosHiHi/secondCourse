using System.IO;
using System.Windows;

namespace Task3
{
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var txt = File.ReadAllLines("userData.txt");

            LoginTextBox.Text = txt[0];
            PasswordTextBox.Text = txt[1];
            EmailTextBox.Text = txt[2];

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            File.Delete("userData.txt");
            StreamWriter sw = new StreamWriter("userData.txt");
            sw.WriteLine($"{LoginTextBox.Text}");
            sw.WriteLine($"{PasswordTextBox.Text}");
            sw.WriteLine($"{EmailTextBox.Text}");
            sw.Close();

            MessageBox.Show("Данные успешно сохранены", "Успех", MessageBoxButton.OK);
        }
    }
}
