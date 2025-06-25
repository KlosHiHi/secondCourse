using LabWork41.Tasks;
using System.Windows;

namespace LabWork41
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Task1Button_Click(object sender, RoutedEventArgs e)
        {
            OpenDialog(new Task1());
        }

        private void Task2Button_Click(object sender, RoutedEventArgs e)
        {
            OpenDialog(new Task2());
        }

        private void Task3Button_Click(object sender, RoutedEventArgs e)
        {
            OpenDialog(new Task3());
        }

        private void Task4Button_Click(object sender, RoutedEventArgs e)
        {
            OpenDialog(new Task4());
        }

        private void Task5Button_Click(object sender, RoutedEventArgs e)
        {
            OpenDialog(new Task5());
        }

        private void OpenDialog<T>(T item)
        {
            if (item is Window window)
            {
                window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                window.Owner = this;

                Hide();
                window.ShowDialog();
                Show();
            }
            else
                throw new TypeLoadException();
        }
    }
}