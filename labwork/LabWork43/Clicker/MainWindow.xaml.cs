using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace Clicker
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer _addCookiesTimer = new(DispatcherPriority.Render);

        private int _cookiesQuantity = 0;
        private int _grandmothersQuantity = 0;
        private int _helpPrice = 15;
        private int _oneCookie = 1;

        public MainWindow()
        {
            InitializeComponent();

            _addCookiesTimer.Tick += new EventHandler(CookiesTimer_Tick);
            _addCookiesTimer.Interval = TimeSpan.FromSeconds(1);

            BackgroundMedieElement.Source = new Uri(Path.Combine(Environment.CurrentDirectory, "background.mp4"));
            BackgroundMedieElement.Play();

            IsGrandmaEnable();
        }

        private void BackgroundMedieElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            MediaElement media = sender as MediaElement;
            media.Stop();
            media.Play();
        }

        private void CookieEllipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateCookiesQuantity(_oneCookie);

            IsGrandmaEnable();
        }

        private void GrandmaImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateCookiesQuantity(-_helpPrice);

            IsGrandmaEnable();

            _grandmothersQuantity += 1;
            GrandmothersQuantityTextBlock.Text = $"бабушки: {_grandmothersQuantity}";
            _addCookiesTimer.Interval = new TimeSpan(0, 0, 0, 0, 1000 / (_grandmothersQuantity));
            _addCookiesTimer.Start();
        }

        void CookiesTimer_Tick(object sender, EventArgs e)
        {
            UpdateCookiesQuantity(_oneCookie);

            IsGrandmaEnable();
        }

        private void BackgroundTimer_Tick(object? sender, EventArgs e)
        {
            BackgroundMedieElement.Stop();
            BackgroundMedieElement.Source = new Uri(Path.Combine(Environment.CurrentDirectory, "background.mp4"));
            BackgroundMedieElement.Play();
        }

        private void UpdateCookiesQuantity(int count)
        {
            _cookiesQuantity += count;
            CookiesQuantityTextBlock.Text = $"печенье: {_cookiesQuantity}";

        }

        private void IsGrandmaEnable()
        {
            GrandmaImage.IsEnabled = (_cookiesQuantity >= _helpPrice);
            GrandmaImage.Opacity = (_cookiesQuantity >= _helpPrice) ? 1 : 0.5;
        }
    }
}