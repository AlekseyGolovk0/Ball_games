using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ball.Common
{
    public class TopReachedEventArgs
    {
        public float X;
        public float Y;

        public TopReachedEventArgs(float pointX, float pointY)
        {
            X = pointX;
            Y = pointY;
        }
    }
}
