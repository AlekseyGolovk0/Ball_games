
namespace Ball.Common
{

    public class MoveBall : RandomSizeAndPointBall
    {

        protected System.Windows.Forms.Timer _timer;

        public MoveBall(Form form, Brush brush) : base(form, brush)
        {
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 20;
            _timer.Tick += Timer_Tick;
        }

        public bool IsMovable()
        {
            return _timer.Enabled;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Move();
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }

        public void ClearPrevious()
        {
            Stop();
            Clear();
        }

        public bool IsBallIntoForm()
        {
            Stop();
            return IsOnForm();
        }
        public void Show()
        {
            base.Show();
        }
        public void Clear()
        {
            base.Clear();
        }

    }
}


