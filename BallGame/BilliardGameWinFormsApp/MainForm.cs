using Ball.Common;
using Timer = System.Windows.Forms.Timer;


namespace BilliardGameWinFormsApp
{
    public partial class MainForm : Form
    {
        private Timer timer = new Timer();
        private int _ballsCount = 20;
        List<BilliardBall> balls = new List<BilliardBall>();

        public MainForm()
        {
            InitializeComponent();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;

        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            ShowVerticalCenterLine();

            int leftOfCenterBlueCount = 0;
            int rightOfCenterBlueCount = 0;

            int leftOfCenterRedCount = 0;
            int rightOfCenterRedCount = 0;
            foreach (var ball in balls)
            {
                if (ball.InLeftOfCenter())
                {
                    if (ball.GetBrush() == Brushes.Red)
                    {
                        leftOfCenterRedCount++;
                    }
                    else if (ball.GetBrush() == Brushes.Blue)
                    {
                        leftOfCenterBlueCount++;
                    }
                }
                else if (ball.InRightOfCenter())
                {
                    if (ball.GetBrush() == Brushes.Red)
                    {
                        rightOfCenterRedCount++;
                    }
                    else if (ball.GetBrush() == Brushes.Blue)
                    {
                        rightOfCenterBlueCount++;
                    }
                }
            }
            if (leftOfCenterBlueCount == rightOfCenterBlueCount &&
                leftOfCenterRedCount == rightOfCenterRedCount &&
               (leftOfCenterBlueCount + leftOfCenterRedCount + rightOfCenterBlueCount + rightOfCenterRedCount) == _ballsCount)
            {
                foreach (var ball in balls)
                {
                    ball.Stop();
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < _ballsCount / 2; i++)
            {
                var ball = new BilliardBall(this, Brushes.Red);
                ball.OnHited += RedBall_OnHited;
                ball.Start();
                balls.Add(ball);

                ball = new BilliardBall(this, Brushes.Blue);
                ball.OnHited += BlueBall_OnHited;
                ball.Start();
                balls.Add(ball);
            }
        }

        private void ShowVerticalCenterLine()
        {
            using (var graphics = CreateGraphics())
                graphics.DrawLine(Pens.Black, ClientSize.Width / 2, 0, ClientSize.Width / 2, ClientSize.Height);
        }

        private void RedBall_OnHited(object? sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    leftRedLabel.Text = (Convert.ToInt32(leftRedLabel.Text) + 1).ToString(); break;
                case Side.Right:
                    rightRedLabel.Text = (Convert.ToInt32(rightRedLabel.Text) + 1).ToString(); break;
                case Side.Top:
                    topRedLabel.Text = (Convert.ToInt32(topRedLabel.Text) + 1).ToString(); break;
                case Side.Down:
                    downRedLabel.Text = (Convert.ToInt32(downRedLabel.Text) + 1).ToString(); break;

            }
        }
        private void BlueBall_OnHited(object? sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    leftBlueLabel.Text = (Convert.ToInt32(leftBlueLabel.Text) + 1).ToString(); break;
                case Side.Right:
                    rightBlueLabel.Text = (Convert.ToInt32(rightBlueLabel.Text) + 1).ToString(); break;
                case Side.Top:
                    topBlueLabel.Text = (Convert.ToInt32(topBlueLabel.Text) + 1).ToString(); break;
                case Side.Down:
                    downBlueLabel.Text = (Convert.ToInt32(downBlueLabel.Text) + 1).ToString(); break;

            }
        }
    }
}
