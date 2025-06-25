using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LabWork26
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Task1Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 form = new();
            form.ShowDialog();
        }

        private void Task2Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 form = new();
            form.ShowDialog();
        }

        private void Task3Button_Click(object sender, RoutedEventArgs e)
        {
            Window3 form = new();
            form.ShowDialog();
        }

        private void Task4Button_Click(object sender, RoutedEventArgs e)
        {
            Window4 form = new();
            form.ShowDialog();
        }

        private void Task5Button_Click(object sender, RoutedEventArgs e)
        {
            Window5 form = new();
            form.ShowDialog();
        }
    }
}