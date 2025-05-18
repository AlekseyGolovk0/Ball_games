using Ball.Common;

namespace FireworksWinFormsApp
{
    public class FireworkBall : MoveBall
    {
        private float g = 0.2f;
        public FireworkBall(Form form, Brush brush, float centreX, float centreY) : base(form, brush)
        {
            radius = 15;
            this.centreX = centreX;
            this.centreY = centreY;
            vy = -Math.Abs(vy);
        }

        protected override void Go()
        {
            base.Go();
            vy += g;
        }
    }
}
