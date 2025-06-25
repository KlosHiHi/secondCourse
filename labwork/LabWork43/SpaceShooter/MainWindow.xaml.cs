using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace SpaceShooter
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer = new(DispatcherPriority.Render);

        private ImageBrush _enemyImage = new()
        {
            ImageSource = new BitmapImage(new Uri(@".\enemy.png", UriKind.RelativeOrAbsolute))
        };

        private List<Rectangle> _bullets = new();
        private List<Rectangle> _enemies = new();
        private List<Rectangle> _healths = new();

        private Rectangle _enemyBullet = new();
        private Random _random = new();

        private int _playerSpeed = 10;
        private int _playerBulletSpeed = 30;
        private int _enemyBulletSpeed = -3;
        private int _enemySpeedX;
        private int _enemySpeedY = 50;
        private int _count = 0;
        private int _health;

        public MainWindow()
        {
            InitializeComponent();

            _timer.Interval = TimeSpan.FromMilliseconds(20);
            _timer.Tick += GameFrameTimer_Tick;


            StartNemGame();
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MovePlayer(e);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SpawnPlayerButton();
        }

        private void StartNemGame()
        {
            SpawnEneminies();
            _enemySpeedX = 7;
            _health = 3;
            _timer.Start();
        }

        private void GameFrameTimer_Tick(object? sender, EventArgs e)
        {
            _count++;

            foreach (Rectangle bullet in _bullets)
            {
                MovePlayerBullet(bullet);
            }

            foreach (Rectangle enemy in _enemies)
            {
                MoveEnemy(enemy);
            }

            if (_count == 175)
            {
                _count = 0;
                _enemySpeedX = -_enemySpeedX;
                SpawnEnemyBullet();
            }

            MoveEnemyBullet();

            HitEnemy();

            HitPlayer();
        }



        private void HitPlayer()
        {
            Rect playerProection = new(Canvas.GetLeft(PlayerRectangle),
                    GameCanvas.ActualHeight - Canvas.GetBottom(PlayerRectangle) - PlayerRectangle.Height,
                    PlayerRectangle.Width,
                    PlayerRectangle.Height);

            Rect enemyBulletProection = new(Canvas.GetLeft(_enemyBullet),
                    GameCanvas.ActualHeight - Canvas.GetBottom(_enemyBullet) - _enemyBullet.Height,
                    _enemyBullet.Width,
                    _enemyBullet.Height);

            if (playerProection.IntersectsWith(enemyBulletProection))
            {
                GameCanvas.Children.Remove(_enemyBullet);
                _health--;
            }
        }

        private void HitEnemy()
        {
            Rect enemyProection;
            Rect playerBulletProection;

            for (int i = 0; i < _enemies.Count(); i++)
            {
                enemyProection = new Rect(Canvas.GetLeft(_enemies[i]),
                                          Canvas.GetTop(_enemies[i]),
                                          _enemies[i].Width,
                                          _enemies[i].Height);

                for (int j = 0; j < _bullets.Count(); j++)
                {
                    playerBulletProection = new Rect(Canvas.GetLeft(_bullets[j]),
                                             GameCanvas.ActualHeight - Canvas.GetBottom(_bullets[j]) - _bullets[j].Height,
                                             _bullets[j].Width,
                                             _bullets[j].Height);

                    if (enemyProection.IntersectsWith(playerBulletProection))
                    {
                        GameCanvas.Children.Remove(_enemies[i]);
                        GameCanvas.Children.Remove(_bullets[j]);
                        _enemies.Remove(_enemies[i]);
                        _bullets.Remove(_bullets[j]);
                        break;
                    }
                }
            }
        }

        private void MovePlayer(KeyEventArgs e)
        {
            var leftBorder = Canvas.GetLeft(PlayerRectangle);
            var rightBorder = Canvas.GetLeft(PlayerRectangle) + PlayerRectangle.Width;

            if (e.Key == Key.A && leftBorder >= GameCanvas.Margin.Left)
            {
                Canvas.SetLeft(PlayerRectangle, Canvas.GetLeft(PlayerRectangle) - _playerSpeed);
            }
            if (e.Key == Key.D && rightBorder <= GameCanvas.ActualWidth - GameCanvas.Margin.Right)
            {
                Canvas.SetLeft(PlayerRectangle, Canvas.GetLeft(PlayerRectangle) + _playerSpeed);
            }
        }

        private void SpawnEneminies()
        {
            Rectangle enemy;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    enemy = new()
                    {
                        Height = 25,
                        Width = 25,
                        Fill = _enemyImage
                    };

                    Canvas.SetLeft(enemy, j * 55 + 80);
                    Canvas.SetTop(enemy, i * 35 + 50);

                    _enemies.Add(enemy);
                    GameCanvas.Children.Add(enemy);
                }
            }
        }

        private void MoveEnemy(UIElement enemy)
        {
            if (_count % 25 == 0)
            {
                Canvas.SetLeft(enemy, Canvas.GetLeft(enemy) + _enemySpeedX);
            }
            if (_count % 175 == 0)
            {
                Canvas.SetTop(enemy, Canvas.GetTop(enemy) + _enemySpeedY);
            }
        }

        private void SpawnEnemyBullet()
        {
            _enemyBullet = new()
            {
                Height = 15,
                Width = 2,
                Fill = new SolidColorBrush(Colors.White)
            };

            Canvas.SetLeft(_enemyBullet, Canvas.GetLeft(PlayerRectangle));
            Canvas.SetBottom(_enemyBullet, Canvas.GetTop(_enemies[_random.Next(_enemies.Count - 1)]));

            GameCanvas.Children.Add(_enemyBullet);
        }

        private void MoveEnemyBullet()
        {
            if (Canvas.GetBottom(_enemyBullet) >= GameCanvas.ActualHeight)
            {
                GameCanvas.Children.Remove(_enemyBullet);
                return;
            }

            Canvas.SetBottom(_enemyBullet, Canvas.GetBottom(_enemyBullet) + _enemyBulletSpeed);
        }

        private void SpawnPlayerButton()
        {
            Rectangle bullet = new()
            {
                Height = 15,
                Width = 2,
                Fill = new SolidColorBrush(Colors.LawnGreen)
            };

            Canvas.SetLeft(bullet, Canvas.GetLeft(PlayerRectangle) + PlayerRectangle.Width / 2);
            Canvas.SetBottom(bullet, Canvas.GetBottom(PlayerRectangle) + PlayerRectangle.Height);

            _bullets.Add(bullet);
            GameCanvas.Children.Add(bullet);
        }

        private void MovePlayerBullet(UIElement bullet)
        {
            if (Canvas.GetBottom(bullet) <= 0)
            {
                GameCanvas.Children.Remove(bullet);
                return;
            }

            Canvas.SetBottom(bullet, Canvas.GetBottom(bullet) + _playerBulletSpeed);
        }
    }
}