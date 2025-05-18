namespace Ball.Common
{
    public class Ball
    {
        protected Form form;
        protected int radius = 40;
        protected float centreX = 70;
        protected float centreY = 70;
        protected float vx = 10;
        protected float vy = 10;
        protected Color color;
        protected Brush brush;
        protected Brush originalBrush;

        public Ball(Form form, Brush brush)
        {
            this.form = form;
            originalBrush = brush;
        }

        protected int LeftSide()
        {
            return radius;
        }
        protected int RightSide()
        {
            return form.ClientSize.Width - radius;
        }
        protected int TopSide()
        {
            return radius;
        }
        protected int DownSide()
        {
            return form.ClientSize.Height - radius;
        }

        protected void Move()
        {
            Clear();
            Go();
            Show();
        }
        protected void Show()
        {
            brush = originalBrush;
            Draw();
        }

        protected void Clear()
        {
            brush = new SolidBrush(form.BackColor);
            Draw();
        }

        protected void Draw()
        {
            var graphics = form.CreateGraphics();
            var rectangle = new RectangleF(centreX - radius, centreY - radius, radius * 2, radius * 2);
            graphics.FillEllipse(brush, rectangle);
        }
        protected bool IsColliding(Ball other)
        {
            float dx = centreX - other.centreX;
            float dy = centreY - other.centreY;
            float distance = (float)Math.Sqrt(dx * dx + dy * dy);
            return distance < radius + other.radius;
        }
        protected virtual void Go()
        {
            centreX += vx;
            centreY += vy;
        }
    }
}
