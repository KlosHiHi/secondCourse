using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace MediaPlayer
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer = new DispatcherTimer();
        private string[] _videos;
        public MainWindow()
        {
            InitializeComponent(); 

            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += timer_Tick;
            _timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (MainMediaElement.Source != null)
            {
                if (MainMediaElement.NaturalDuration.HasTimeSpan)
                    StatusTextBlock.Text = String.Format("{0} / {1}", MainMediaElement.Position.ToString(@"hh\:mm\:ss"), MainMediaElement.NaturalDuration.TimeSpan.ToString(@"hh\:mm\:ss"));
            }
            else
                StatusTextBlock.Text = "Файл не выбран...";
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            MainMediaElement.Play();
            _timer.Start();
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            MainMediaElement.Pause();
            _timer.Stop();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            MainMediaElement.Stop();
            StatusTextBlock.Text = String.Format("{0} / {1}", MainMediaElement.Position.ToString(@"hh\:mm\:ss"), MainMediaElement.NaturalDuration.TimeSpan.ToString(@"hh\:mm\:ss"));
            _timer.Stop();
        }

        private void SelectFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Multiselect = true,
                Filter = "MP4|*.mp4|MOV|*.mov|Все файлы|*.*"
            };

            if (openFileDialog.ShowDialog() != true)
                return;

            VideosListView.ItemsSource = openFileDialog.FileNames;
        }

        private void VideosListView_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            MainMediaElement.Source = new Uri((string)((ListView)sender).SelectedValue) ;
        }
    }
}