using Microsoft.Win32;
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

namespace Task4
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

        private void OpenImageButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "PNG (*.png)|*.png|" +
                                    "JPG, JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                                    "BMP (*.bmp)|*.bmp";
            if (openFileDialog.ShowDialog().Value)
                ImageListView.ItemsSource = openFileDialog.FileNames;
        }
    }
}