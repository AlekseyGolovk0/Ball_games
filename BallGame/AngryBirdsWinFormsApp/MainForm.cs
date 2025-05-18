using Timer = System.Windows.Forms.Timer;

namespace AngryBirdsWinFormsApp
{
    public partial class MainForm : Form
    {
        private Timer _timer = new Timer();
        private Brush _pigBrush = Brushes.Green;
        private Brush _birdBrush = Brushes.Red;
        private int _caughtPigCount = 0;

        private bool _isFly = false;
        private Bird _bird;
        private Pig _pig;

        public MainForm()
        {
            InitializeComponent();
            _timer.Interval = 20;
            _timer.Tick += PigCollisionTimer_Tick;
            _timer.Start();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (!_isFly)
            {
                _bird.LaunchBird(e.X, e.Y);
                _bird.Start();
                _isFly = true;
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            _bird = new Bird(this, _birdBrush);
            _bird.Show();

            _pig = new Pig(this, _pigBrush);
            _pig.Show();
        }

        private void ReturnBirdButton_Click(object sender, EventArgs e)
        {
            ResetBird();
        }

        private void PigCollisionTimer_Tick(object? sender, EventArgs e)
        {
            if (_bird.IsOutOfRight() || _bird.IsOutOfLeft())
            {
                ResetBird();
            }
            if (_bird.IsColliding(_pig))
            {
                _caughtPigCount++;
                caughtPigCount.Text = _caughtPigCount.ToString();
                _pig.Clear();
                _pig = new Pig(this, _pigBrush);
                _pig.Show();
            }
        }

        private void ResetBird()
        {
            _bird.ResetPosition();
            _isFly = false;
            _bird.Show();
        }
    }
}
