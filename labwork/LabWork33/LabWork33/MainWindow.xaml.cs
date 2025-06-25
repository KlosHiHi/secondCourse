using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace LabWork33
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //var files = new DirectoryInfo(@"Y:\МДК.01.01").GetFiles();
            var files = new DirectoryInfo(@"C:\Users\Вячеслав\Desktop\5\МонтажВидео\Файлы\Packages\dynamictransitionspack1\resources").GetFiles();

            FilesListView.ItemsSource = files;
        }

        private void FileInfoButton_Click(object sender, RoutedEventArgs e)
        {
            var file = (e.Source as Button)?.DataContext as FileInfo;
            MessageBox.Show(file.FullName);
        }
    }
}