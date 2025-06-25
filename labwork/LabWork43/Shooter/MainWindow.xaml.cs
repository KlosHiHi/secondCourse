using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Shooter
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer _spawnEnemyTimer = new(DispatcherPriority.Render);
        private DispatcherTimer _timerMove = new(DispatcherPriority.Render);

        private Random _random = new();

        private int _enemySpeed = 3;
        private int _score = 0;

        public MainWindow()
        {
            InitializeComponent();

            _spawnEnemyTimer.Interval = TimeSpan.FromMilliseconds(500);
            _spawnEnemyTimer.Tick += SpawnEnemyTimer_Tick;
            _spawnEnemyTimer.Start();

            _timerMove.Interval = TimeSpan.FromMilliseconds(50);
            _timerMove.Tick += MoveEnemyTimer_Tick;
            _timerMove.Start();
        }

        private void MoveEnemyTimer_Tick(object? sender, EventArgs e)
        {
            double EnemyPositionY;

            foreach (Shape enemy in GameCanvas.Children.OfType<Shape>())
            {
                EnemyPositionY = (double)enemy.GetValue(Canvas.TopProperty);

                Canvas.SetTop(enemy, EnemyPositionY + _enemySpeed);

                if (EnemyPositionY >= Height - enemy.Height)
                {
                    _timerMove.Stop();

                    MessageBox.Show("Игра окончена");

                    break;
                }
            }
        }

        private void SpawnEnemyTimer_Tick(object? sender, EventArgs e)
        {
            Ellipse enemy = new()
            {
                Width = 30,
                Height = 30,
                Fill = new SolidColorBrush(Colors.White),
                StrokeThickness = 1,
                Stroke = new SolidColorBrush(Colors.Black),
            };

            GameCanvas.Children.Add(enemy);

            double EnemyPositionX = _random.NextDouble() * Width;

            Canvas.SetLeft(enemy, EnemyPositionX);
            Canvas.SetTop(enemy, -enemy.Height);

            enemy.MouseDown += Enemy_MouseDown;
        }

        private void Enemy_MouseDown(object sender, MouseButtonEventArgs e)
        {
            GameCanvas.Children.Remove(sender as UIElement);

            _score += 1;
            ScoreTextBlock.Text = $"Cчёт: {_score}";
        }
    }
}