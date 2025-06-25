using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace LabWork40
{
    public partial class Task4 : Window
    {
        private Brush _brush;
        private Random _random = new();
        private Point _mousePosition;
        private byte _rValue = 0;
        private byte _bValue = 0;
        private byte _gValue = 0;
        private string[] tags = { "enemy", "hero", "treasure" };

        public Task4()
        {
            InitializeComponent();
        }

        private void CircleCanvas_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            _mousePosition = Mouse.GetPosition(CircleCanvas);

            SetColor();

            Ellipse ellipse = new()
            {
                Width = _random.Next(50, 90),
                Height = _random.Next(50, 90),
                Fill = _brush,
                Stroke = Brushes.Black,
                StrokeThickness = 2,
                Tag = tags[_random.Next(0, 3)],
            };

            ellipse.MouseDown += Ellipse_MouseDown;

            Canvas.SetTop(ellipse, _mousePosition.Y - ellipse.Height / 2);
            Canvas.SetLeft(ellipse, _mousePosition.X - ellipse.Width / 2);

            CircleCanvas.Children.Add(ellipse);

            TextBlock tag = new()
            {
                Text = ellipse.Tag.ToString(),
                FontSize = 15,
                FontFamily = new FontFamily("Comic Sans MS"),
            };

            Canvas.SetTop(tag, _mousePosition.Y - ellipse.Height);
            Canvas.SetLeft(tag, _mousePosition.X - ellipse.Width / 2);

            CircleCanvas.Children.Add(tag);
        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show($"{((Ellipse)sender).Tag}");
        }

        private void SetColor()
        {
            _rValue = (byte)_random.Next(0, 256);
            _bValue = (byte)_random.Next(0, 256);
            _gValue = (byte)_random.Next(0, 256);

            _brush = new SolidColorBrush(Color.FromRgb(_rValue, _bValue, _gValue));
        }
    }
}
