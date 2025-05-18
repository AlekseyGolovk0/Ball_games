using Timer = System.Windows.Forms.Timer;


namespace FruitNinjaWinFormsApp
{
    public partial class MainForm : Form
    {
        private Timer timer = new Timer();
        private Timer _delayTimer = new Timer();
        private List<FruitNinjaBall> _balls = new List<FruitNinjaBall>();
        private int _countCatchBalls = 0;
        private Random _random = new Random();

        private Color _color;
        private Brush _randomBrush;
        private Brush _bombBlackBrush = Brushes.Black;
        private Brush _bananaYellowBrush = Brushes.Yellow;


        public MainForm()
        {
            InitializeComponent();

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            _delayTimer.Interval = 4000;
            _delayTimer.Tick += DelayTimer_Tick;
        }

        private void DelayTimer_Tick(object? sender, EventArgs e)
        {
            foreach (var ball in _balls)
            {
                ball.SetNormalMoveBall();
            }
            _delayTimer.Stop();
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var ball in _balls)
            {
                if (ball.IsMouseInCircle(e.X, e.Y) && ball.IsMovable())
                {
                    if (ball is BombBall)
                    {
                        EndGame();
                        return;
                    }
                    if (ball is BananaBall)
                    {
                        foreach (var fruit in _balls)
                        {
                            fruit.SetSlowMoveBall();
                            _delayTimer.Start();
                        }
                        if (_delayTimer.Enabled)
                        {
                            _delayTimer.Stop();
                        }
                        _delayTimer.Start();
                    }
                    _countCatchBalls++;
                    amountBallsLabel.Text = _countCatchBalls.ToString();
                    ball.ClearPrevious();
                }
            }
        }

        private void EndGame()
        {
            foreach (var ball in _balls)
            {
                ball.ClearPrevious();
                timer.Stop();
            }
            MessageBox.Show("Игра окончена!");
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            for (int i = 0; i < _random.Next(4, 10); i++)
            {
                _color = Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));
                _randomBrush = new SolidBrush(_color);

                var randomBoll = _random.Next(6);
                FruitNinjaBall fruitNinjaBall;

                if (randomBoll == 4)
                {
                    fruitNinjaBall = new BombBall(this, _bombBlackBrush);
                }
                else if (randomBoll == 5)
                {
                    fruitNinjaBall = new BananaBall(this, _bananaYellowBrush);
                }
                else
                {
                    fruitNinjaBall = new FruitNinjaBall(this, _randomBrush);
                }

                _balls.Add(fruitNinjaBall);
                fruitNinjaBall.Start();
            }
            if (_delayTimer.Enabled)
            {
                foreach (var fruit in _balls)
                {
                    fruit.SetSlowMoveBall();
                }
            }
            timer.Interval = _random.Next(4000, 7000);
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            if (_delayTimer.Enabled)
            {
                _delayTimer.Stop();
            }
            foreach (var ball in _balls)
            {
                ball.ClearPrevious();
                timer.Stop();
            }
            _countCatchBalls = 0;
            amountBallsLabel.Text = _countCatchBalls.ToString();

            timer.Interval = 1000;
            timer.Start();
        }
    }
}
