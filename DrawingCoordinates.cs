using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curse_works
{
    public class DrawingCoordinates
    {
        public int x_, y_, sX_, sY_, cX_, cY_ = 0;

        public Point[] GetLineCoordinates()
        {
            return new Point[]{ new Point(cX_,cY_), new Point(x_,y_) };
        }

        public Rectangle GetRectangle()
        {
            return new Rectangle(cX_, cY_, sX_, sY_);
        }
    }
}
