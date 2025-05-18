using Ball.Common;

namespace FireworksWinFormsApp
{
    public class StartFireworkBall : FireworkBall
    {
        private const float MinVerticalSpeed = -10f;
        private const float MaxVerticalSpeed = -6f;
        public event EventHandler<TopReachedEventArgs> TopReached;

        public StartFireworkBall(Form form, Brush brush) : base(
               form, brush, form.ClientSize.Width / 2, form.ClientSize.Height)
        {
            radius = 15;
            vx = 0;
            vy = (float)random.NextDouble() * (MaxVerticalSpeed - MinVerticalSpeed) + MinVerticalSpeed;
            this.brush = brush;
            this.centreX = random.Next(LeftSide(), RightSide());
        }

        protected override void Go()
        {
            base.Go();

            if (vy > 0)
            {
                TopReached?.Invoke(this, new TopReachedEventArgs(centreX, centreY));
                ClearPrevious();
            }

        }
    }
}
