using Ball.Common;

namespace FireworksWinFormsApp
{
    public partial class MainForm : Form
    {
        private Color _color;
        private Brush _brush;

        private readonly Random _random = new Random();

        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            GenerateFireworkParticles(e.X, e.Y);
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            var ball = new StartFireworkBall(this, Brushes.Black);
            ball.TopReached += OnTopReached;
            ball.Start();

        }

        private void OnTopReached(object? sender, TopReachedEventArgs e)
        {
            GenerateFireworkParticles(e.X, e.Y);
        }

        private void GenerateFireworkParticles(float centreX, float centreY)
        {
            var _randomCountBalls = _random.Next(1, 11);
            for (int i = 0; i < _randomCountBalls; i++)
            {

                _color = Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));
                _brush = new SolidBrush(_color);
                var fireworkBall = new FireworkBall(this, _brush, centreX, centreY);
                fireworkBall.Start();
            }
        }
    }
}
