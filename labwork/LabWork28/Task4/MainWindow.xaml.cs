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
        private void DarkButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeTheme("DarkTheme");
        }

        private void LightButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeTheme("LightTheme");
        }

        private void ChangeTheme(string name)
        {
            var uriDictionary = new Uri($"/Themes/{name}.xaml", UriKind.Relative);
            var dictionary = Application.LoadComponent(uriDictionary) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(dictionary);
        }
    }
}