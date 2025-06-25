using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Arkanoid
{
    public partial class GameWindow : Window
    {
        private DispatcherTimer _gameFrameTimer = new(DispatcherPriority.Render);
        private Random _random = new();
        private Ellipse _ball;

        private int _roundNumber = 1;
        private int _racketSpeed = 10;
        private int _ballSpeedX = -2;
        private int _ballSpeedY = -2;
        private int _score = 0;

        public GameWindow()
        {
            InitializeComponent();

            _gameFrameTimer.Interval = TimeSpan.FromMilliseconds(15);
            _gameFrameTimer.Tick += GameFrameTimer_Tick;
            _gameFrameTimer.Start();

            ShowHighScore();

            SpawnBall();
        }

        private void GameFrameTimer_Tick(object? sender, EventArgs e)
        {
            MoveBall();
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MoveRacket(e);
        }

        private void NewGameButton_Click(object sender, RoutedEventArgs e)
        {
            StartNewGame();
        }

        private void StartNewGame()
        {
            SaveHighScore();
            AddNewRound();
            RefreshBallSpeed();
            GameCanvas.Children.Remove(_ball);
            SpawnBall();
            UpdateScore(-_score);
            _gameFrameTimer.Start();
        }

        private void RefreshBallSpeed()
        {
            _ballSpeedX = -2;
            _ballSpeedY = -2;
        }

        private void AddNewRound()
        {
            _roundNumber++;
            RoundTextBlock.Text = _roundNumber.ToString();
        }

        private void SpawnBall()
        {
            ImageBrush image = new()
            {
                ImageSource = new BitmapImage(new Uri(@".\snowball.png", UriKind.RelativeOrAbsolute))
            };

            _ball = new Ellipse()
            {
                Width = 20,
                Height = 20,
                Fill = image
            };

            GameCanvas.Children.Add(_ball);

            Canvas.SetLeft(_ball, _random.Next(200, 500));
            Canvas.SetTop(_ball, _random.Next(300, 400));
        }

        private void MoveBall()
        {
            var topBorder = Canvas.GetTop(_ball);
            var bottomBorder = Canvas.GetTop(_ball) + _ball.Height;
            var leftBorder = Canvas.GetLeft(_ball);
            var rightBorder = Canvas.GetLeft(_ball) + _ball.Width;

            if (topBorder < 0 || (bottomBorder > Canvas.GetTop(RacketRectangle)
                && leftBorder > Canvas.GetLeft(RacketRectangle)
                && rightBorder < Canvas.GetLeft(RacketRectangle) + RacketRectangle.Width))
            {
                _ballSpeedY = -_ballSpeedY;
                UpdateScore(5);
            }
            if (leftBorder < 0 || rightBorder > GameCanvas.ActualWidth)
            {
                _ballSpeedX = -_ballSpeedX;
                UpdateScore(2);
            }

            if (bottomBorder > Canvas.GetTop(RacketRectangle) + RacketRectangle.Height)
            {
                EndGame();
            }

            Canvas.SetTop(_ball, topBorder + _ballSpeedY);
            Canvas.SetLeft(_ball, leftBorder + _ballSpeedX);
        }

        private void MoveRacket(KeyEventArgs e)
        {
            var leftborder = Canvas.GetLeft(RacketRectangle);
            var rightborder = Canvas.GetLeft(RacketRectangle) + RacketRectangle.Width;

            if (leftborder > 0 && e.Key == Key.A)
            {
                Canvas.SetLeft(RacketRectangle, Canvas.GetLeft(RacketRectangle) - _racketSpeed);
            }
            if (rightborder < GameCanvas.ActualWidth && e.Key == Key.D)
            {
                Canvas.SetLeft(RacketRectangle, Canvas.GetLeft(RacketRectangle) + _racketSpeed);
            }
        }

        private void UpdateScore(int value)
        {
            _score += value;
            ScoreTextBox.Text = _score.ToString();
        }

        private void EndGame()
        {
            _gameFrameTimer.Stop();
            MessageBox.Show("Игра окончена");
        }

        private void SaveHighScore()
        {
            if (int.Parse(HighScoreTextBox.Text) < _score)
            {

                Properties.Settings.Default.HighScore = _score;

                Properties.Settings.Default.Save();

                ShowHighScore();
            }
        }

        private void ShowHighScore()
        {
            HighScoreTextBox.Text = Properties.Settings.Default.HighScore.ToString().PadLeft(4, '0');
        }
    }
}