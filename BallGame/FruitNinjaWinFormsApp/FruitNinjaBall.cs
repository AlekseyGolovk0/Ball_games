using Ball.Common;

namespace FruitNinjaWinFormsApp
{
    public class FruitNinjaBall : MoveBall
    {
        private const float MinVerticalSpeed = -10f;
        private const float MaxVerticalSpeed = -6f;
        private float g = 0.2f;
        public FruitNinjaBall(Form form, Brush brush) : base(form, brush)
        {
            vy = (float)random.NextDouble() * (MaxVerticalSpeed - MinVerticalSpeed) + MinVerticalSpeed;
            this.brush = brush;
            this.centreX = random.Next(LeftSide(), RightSide());
            this.centreY = DownSide() + radius;
        }
        public void SetSlowMoveBall()
        {
            _timer.Interval = 200;
        }
        public void SetNormalMoveBall()
        {
            _timer.Interval = 20;
        }

        protected override void Go()
        {
            base.Go();

            vy += g;

            if (centreY > DownSide() + 2 * radius)
            {
                ClearPrevious();
            }
        }
    }
}

