namespace Ball.Common
{

    public class BilliardBall : MoveBall
    {
        public event EventHandler<HitEventArgs> OnHited;
        public BilliardBall(Form form, Brush brush) : base(form, brush)
        {
            radius = 10;
        }
        public bool InLeftOfCenter()
        {
            return centreX + radius < form.ClientSize.Width / 2;
        }

        public bool InRightOfCenter()
        {
            return centreX - radius > form.ClientSize.Width / 2;
        }

        public Brush GetBrush()
        {
            return brush;
        }

        protected override void Go()
        {
            base.Go();

            if (centreX <= LeftSide())
            {
                centreX = LeftSide();
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Left));
            }
            if (centreX >= RightSide())
            {
                centreX = RightSide();
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Right));
            }

            if (centreY <= TopSide())
            {
                centreY = TopSide();
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Top));
            }

            if (centreY >= DownSide())
            {
                centreY = DownSide();
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Down));
            }
        }
    }
}
