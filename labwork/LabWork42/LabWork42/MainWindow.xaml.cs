using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Paint
{
    public partial class MainWindow : Window
    {
        public SolidColorBrush PenColor { get; set; } = new SolidColorBrush(Colors.Black);

        public int PenSize { get; set; } = 1;

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
        }

        private void SetColorButton_Click(object sender, RoutedEventArgs e)
        {
            SetColorWindow setColor = new()
            {
                Owner = this,
                WindowStartupLocation = WindowStartupLocation.CenterOwner
            };

            if (setColor.ShowDialog().Value)
                PenColor = new SolidColorBrush(setColor.Color);

            SetColor();

            Show();
        }

        private void PenSizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            PenSize = (int)((Slider)sender).Value;

            if (!(PenSizeTextBlock is null))
                PenSizeTextBlock.Text = $"{PenSize}px";

            if (!(MainInkCanvas is null))
            {
                MainInkCanvas.DefaultDrawingAttributes.Height = PenSize;
                MainInkCanvas.DefaultDrawingAttributes.Width = PenSize;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PenColor = ((SolidColorBrush)((Rectangle)((Button)sender).Content).Fill);

            SetColor();
        }

        private void SetColor()
        {
            BtnContentRectangle.Fill = PenColor;
            MainInkCanvas.DefaultDrawingAttributes.Color = PenColor.Color;
        }

        private void SetImageButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new();
            dialog.Filter = "PNG|*.png|JPG, JPEG|*.jpg;*.jpeg|BMP|*.bmp|Все файлы|*.*";

            if (dialog.ShowDialog() != true)
                return;

            var fileName = dialog.FileName;

            BitmapImage image = new();

            image.BeginInit();
            image.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            image.CacheOption = BitmapCacheOption.OnLoad;
            image.UriSource = new Uri(fileName, UriKind.RelativeOrAbsolute);
            image.EndInit();

            InkCanvasImage.Source = image;
        }
    }
}