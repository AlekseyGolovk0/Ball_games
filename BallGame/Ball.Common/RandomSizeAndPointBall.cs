using Microsoft.VisualBasic.Devices;
using System.Drawing;
using System.Windows.Forms;



namespace Ball.Common
{
    public partial class RandomSizeAndPointBall : Ball
    {
        protected static Random random = new Random();
        public RandomSizeAndPointBall(Form form, Brush brush) : base(form, brush)
        {
            centreX = random.Next(LeftSide(), RightSide());
            centreY = random.Next(TopSide(), DownSide());
            do
            {
                vx = random.Next(-5, 5);
            } while (vx == 0);
            do
            {
                vy = random.Next(-5, 5);
            } while (vy == 0);
            radius = random.Next(10, 40);
        }

        protected bool IsOnForm()
        {
            return centreX >= LeftSide() && centreX <= RightSide() &&
                   centreY >= TopSide() && centreY <= DownSide();
        }
        public bool IsMouseInCircle(int mouseDownX, int mouseDownY)
        {
            int dx = mouseDownX - (int)centreX;
            int dy = mouseDownY - (int)centreY;
            return (dx * dx + dy * dy) <= (radius * radius);
        }
    }
}


