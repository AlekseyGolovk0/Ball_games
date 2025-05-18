using Ball.Common;
using System.Drawing;
namespace CatchBall2WinFormsApp
{
    public partial class MainForm : Form
    {
        private static int _countBalls = 10;
        private int _countCatchBalls = 0;
        private List<MoveBall> _moveBalls = new List<MoveBall>();
        private Brush _ballBrush = Brushes.Green;

        public MainForm()
        {
            InitializeComponent();
        }

        private void GenerateBallsButton_Click(object sender, EventArgs e)
        {
            _countCatchBalls = 0;
            amountBallsLabel.Text = _countCatchBalls.ToString();
            foreach (var ball in _moveBalls)
            {
                ball.ClearPrevious();
            }
            _moveBalls = new List<MoveBall>();
            for (int i = 0; i < _countBalls; i++)
            {
                var ball = new MoveBall(this, _ballBrush);
                _moveBalls.Add(ball);
                ball.Start();
            }
        }

        private void ClearBallsButton_Click(object sender, EventArgs e)
        {
            foreach (var ball in _moveBalls)
            {
                ball.ClearPrevious();
            }

            MessageBox.Show($"Поймано шариков: {_countCatchBalls}");

            _countCatchBalls = 0;
            amountBallsLabel.Text = _countCatchBalls.ToString();
        }


        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < _countBalls; i++)
            {
                if (_moveBalls != null)
                {
                    if (_moveBalls[i].IsMovable() && _moveBalls[i].IsMouseInCircle(e.X, e.Y))
                    {
                        _countCatchBalls++;
                        amountBallsLabel.Text = _countCatchBalls.ToString();
                        _moveBalls[i].Stop();
                    }
                }
            }
        }
    }
}