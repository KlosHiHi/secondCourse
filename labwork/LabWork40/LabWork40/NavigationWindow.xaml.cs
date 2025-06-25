using System.Windows;

namespace LabWork40
{
    public partial class NavigationWindow : Window
    {
        public NavigationWindow()
        {
            InitializeComponent();
        }

        private void ToTask1Button_Click(object sender, RoutedEventArgs e)
        {
            Task1 task = new()
            {
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Owner = this
            };
            Hide();
            task.ShowDialog();
            Show();
        }

        private void ToTask3Button_Click(object sender, RoutedEventArgs e)
        {
            Task3 task = new()
            {
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Owner = this
            };
            Hide();
            task.ShowDialog();
            Show();
        }

        private void ToTask4Button_Click(object sender, RoutedEventArgs e)
        {
            Task4 task = new()
            {
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Owner = this
            };
            Hide();
            task.ShowDialog();
            Show();
        }
    }
}
