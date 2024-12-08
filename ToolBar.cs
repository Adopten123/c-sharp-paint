using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static curse_works.Form1;

namespace curse_works
{
    internal class ToolBar
    {

        private Bitmap bitmap_;
        private Graphics graphics_;
        private Pen pen_ = new Pen(Color.Black, 1);
        private Pen erase_ = new Pen(Color.White, 10);
        MODE index_;

        public Bitmap Bitmap { get { return bitmap_; } set { bitmap_ = value; } }
        public Graphics Graphics { get { return graphics_; } set { graphics_ = value;  } }
        public Pen Pen { get { return pen_; } set { pen_ = value; } }
        public Pen Erase { get { return erase_; } set { erase_ = value; } }
        public MODE Index { get { return index_; } set { index_ = value; } }

        public ToolBar(PictureBox pictureBox)
        {
            bitmap_ = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics_ = Graphics.FromImage(bitmap_);
            graphics_.Clear(Color.White);
            pictureBox.Image = bitmap_;
        }

        public void DrawFigures(DrawingCoordinates coords, PaintEventArgs e = null)
        {
            Graphics graphics = e != null ? e.Graphics : graphics_;
            if (index_ == MODE.DRAW_ELLIPSE)
            {
                graphics.DrawEllipse(Pen, coords.GetRectangle());
            }
            if (index_ == MODE.DRAW_RECTANGLE)
            {
                graphics.DrawRectangle(Pen, coords.GetRectangle());
            }
            if (index_ == MODE.DRAW_LINE)
            {
                graphics.DrawLines(Pen, coords.GetLineCoordinates());
            }
        }

        private void Validate(Stack<Point> point_stack, int x, int y, Color old_color, Color new_color)
        {
            Color cX = bitmap_.GetPixel(x, y);
            if (cX == old_color)
            {
                point_stack.Push(new Point(x, y));
                bitmap_.SetPixel(x, y, new_color);
            }
        }

        public void Fill(PictureBox pictureBox, Point temp_point, Color new_color)
        {
            Point point = SetPoint(pictureBox, temp_point);
            Color old_color = bitmap_.GetPixel(point.X, point.Y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(point.X, point.Y));
            bitmap_.SetPixel(point.X, point.Y, new_color);

            if (old_color == new_color) return;

            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0
                    && pt.Y > 0
                    && pt.X < bitmap_.Width - 1
                    && pt.Y < bitmap_.Height - 1)
                {
                    Validate(pixel, pt.X - 1, pt.Y, old_color, new_color);
                    Validate(pixel, pt.X, pt.Y - 1, old_color, new_color);
                    Validate(pixel, pt.X + 1, pt.Y, old_color, new_color);
                    Validate(pixel, pt.X, pt.Y + 1, old_color, new_color);
                }
            }
        }

        public void Clear(PictureBox pictureBox)
        {
            graphics_.Clear(Color.White);
            pictureBox.Image = bitmap_;
        }
    }
}
