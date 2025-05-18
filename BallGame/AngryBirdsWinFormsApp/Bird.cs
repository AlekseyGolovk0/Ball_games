using Ball.Common;

namespace AngryBirdsWinFormsApp
{
    public class Bird : MoveBall
    {
        protected float g = 0.35f;
        protected float friction = 0.7f;
        protected float airFriction = 0.99f;
        protected float maxSpeed = 20.0f;
        public Bird(Form form, Brush brush) : base(form, brush)
        {
            radius = 15;
            centreX = LeftSide();
            centreY = DownSide();
        }

        public void LaunchBird(int pointX, int pointY)
        {
            float dx = pointX - LeftSide();
            float dy = pointY - DownSide();
            float distance = (float)Math.Sqrt(dx * dx + dy * dy);

            if (distance != 0)
            {
                vx = dx / distance;
                vy = dy / distance;
            }
            else
            {
                vx = 0;
                vy = 0;
            }
            float speed = Math.Min(distance * g, maxSpeed);
            vx *= speed;
            vy *= speed;
        }

        public void ResetPosition()
        {
            Clear();
            vy = 0;
            vx = 0;
            centreX = LeftSide();
            centreY = DownSide();
        }

        public bool IsColliding(MoveBall pig)
        {
            return base.IsColliding(pig);
        }
        public bool IsOutOfRight()
        {
            return centreX > RightSide();
        }
        public bool IsOutOfLeft()
        {
            return centreX < LeftSide();
        }

        protected override void Go()
        {
            base.Go();

            if (centreY >= DownSide())
            {
                centreY = DownSide();
                vy = friction * -vy;

                if (Math.Abs(vy) < 0.1f)
                {
                    vy = 0;
                    vx = 0;
                    Stop();
                    return;
                }
            }

            vy += g;
            vx *= airFriction;
        }
    }
}
