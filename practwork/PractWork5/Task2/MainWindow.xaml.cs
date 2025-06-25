using System.Windows;

namespace Task2
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorization = new()
            {
                Owner = this,
                WindowStartupLocation = WindowStartupLocation.CenterOwner
            };

            Hide();
            authorization.ShowDialog();
            Show();
        }
    }
}