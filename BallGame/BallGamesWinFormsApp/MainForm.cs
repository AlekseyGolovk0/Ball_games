using Ball.Common;
using System;
namespace BallGamesWinFormsApp
{
    public partial class MainForm : Form
    {
        private static int _countBalls = 10;
        private int _countCatchBalls = 0;
        private List<MoveBall> _moveBalls = new List<MoveBall>();
        private Brush _ballBrush = Brushes.Red;


        public MainForm()
        {
            InitializeComponent();
        }

        private void GenerateBallsButton_Click(object sender, EventArgs e)
        {
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


        private void StopBallsButton_Click(object sender, EventArgs e)
        {
            _countCatchBalls = 0;
            foreach (var ball in _moveBalls)
            {
                if (ball.IsBallIntoForm())
                {
                    _countCatchBalls++;
                }
            }

            MessageBox.Show($"Поймано шариков: {_countCatchBalls}");
        }
    }
}
