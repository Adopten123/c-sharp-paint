using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curse_works
{
    public class ColorPalette
    {
        private ColorDialog color_dialog_ = new ColorDialog();
        private Color current_color_;

        public Color Color { get { return current_color_; } set { current_color_ = value; } }
        public ColorDialog Dialog { get { return color_dialog_; } set { color_dialog_ = value; } }

        public void UpdateColor()
        {
            color_dialog_.ShowDialog();
            current_color_ = color_dialog_.Color;
        }
        public void UpdateColor(PictureBox color_picker, MouseEventArgs e)
        {
            Point point = Form1.SetPoint(color_picker, e.Location);
            current_color_ = ((Bitmap)color_picker.Image).GetPixel(point.X, point.Y);

        }
    }
}
