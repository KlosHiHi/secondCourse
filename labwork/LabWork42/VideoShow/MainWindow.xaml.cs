using System.IO;
using System.Media;
using System.Windows;

namespace VideoShow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            VideoMediaElement.Source = new Uri(Path.Combine(Environment.CurrentDirectory, "back.mp4"));
            IphoneSound.Source = new Uri(Path.Combine(Environment.CurrentDirectory, "iphone.mp3"));
            AndroidSound.Source = new Uri(Path.Combine(Environment.CurrentDirectory, "android.mp3"));
            HuaweiSound.Source = new Uri(Path.Combine(Environment.CurrentDirectory, "huawei-honor.mp3"));
        }
        private void AsteriskButton_Click(object sender, RoutedEventArgs e)
        {
            SystemSounds.Asterisk.Play();
        }

        private void HandButton_Click(object sender, RoutedEventArgs e)
        {
            SystemSounds.Hand.Play();
        }

        private void IphoneButton_Click(object sender, RoutedEventArgs e)
        {
            IphoneSound.Play();
        }

        private void AndroidButton_Click(object sender, RoutedEventArgs e)
        {
            AndroidSound.Play();
        }

        private void HuaweiButton_Click(object sender, RoutedEventArgs e)
        {
            HuaweiSound.Play();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            ResetSound();
        }

        private void ResetSound()
        {
            IphoneSound.Stop();
            AndroidSound.Stop();
            HuaweiSound.Stop();
        }
    }
}