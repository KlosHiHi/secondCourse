using Microsoft.Win32;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace ImageCircle
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer = new DispatcherTimer();
        private BitmapImage image = new();
        private int _imageNumber = 0;
        private string[] _images;

        public MainWindow()
        {
            InitializeComponent();

            _timer.Interval = TimeSpan.FromMilliseconds(300);
            _timer.Tick += timer_Tick;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            image = new();
            image.BeginInit();
            image.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            image.CacheOption = BitmapCacheOption.OnLoad;
            image.UriSource = new Uri(_images[_imageNumber], UriKind.RelativeOrAbsolute);
            image.EndInit();

            _imageNumber++;

            if (_imageNumber == _images.Length)
                _imageNumber = 0;

            ShownImage.Source = image;

        }

        private void SetImagesButton_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openFileDialog = new()
            {
                Multiselect = true,
                Filter = "PNG|*.png|JPG, JPEG|*.jpg;*.jpeg|BMP|*.bmp|Все файлы|*.*"
            };

            if (openFileDialog.ShowDialog() != true)
                return;

            _images = openFileDialog.FileNames;

            _timer.Start();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            _timer.Stop();
        }
    }
}