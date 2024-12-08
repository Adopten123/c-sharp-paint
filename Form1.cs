using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curse_works
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Width = 900;
            this.Height = 700;
            tool_ = new ToolBar(pictureBox);
            coords_ = new DrawingCoordinates();
            palette_ = new ColorPalette();
        }

        ToolBar tool_;
        DrawingCoordinates coords_;
        ColorPalette palette_;


        bool paint_ = false;
        Point px_, py_;

        public enum MODE
        {
            PEN,
            ERASE,
            DRAW_ELLIPSE,
            DRAW_RECTANGLE,
            DRAW_LINE,
            FILL,

        }
        static public Point SetPoint(PictureBox pictureBox, Point point)
        {
            float pX = 1f * pictureBox.Image.Width / pictureBox.Width;
            float pY = 1f * pictureBox.Image.Height / pictureBox.Height;
            return new Point((int)(point.X * pX), (int)(point.Y * pY));
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint_)
            {
                if (tool_.Index == MODE.PEN)
                {
                    px_ = e.Location;
                    tool_.Graphics.DrawLine(tool_.Pen, px_, py_);
                    py_ = px_;
                }
                if (tool_.Index == MODE.ERASE)
                {
                    px_ = e.Location;
                    tool_.Graphics.DrawLine(tool_.Erase, px_, py_);
                    py_ = px_;
                }
            }
            pictureBox.Refresh();

            coords_.x_ = e.X;
            coords_.y_ = e.Y;
            coords_.sX_ = e.X - coords_.cX_;
            coords_.sY_ = e.Y - coords_.cY_;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            paint_ = true;
            py_ = e.Location;

            coords_.cX_ = e.X;
            coords_.cY_ = e.Y;
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            paint_ = false;

            coords_.sX_ = coords_.x_ - coords_.cX_;
            coords_.sY_ = coords_.y_ - coords_.cY_;

            tool_.DrawFigures(coords_);
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (paint_)
            {
                tool_.DrawFigures(coords_, e);
            }
        }

        private void button_color_Click(object sender, EventArgs e)
        {
            palette_.UpdateColor();

            picture_color.BackColor = palette_.Color;
            tool_.Pen.Color = palette_.Color;
        }

        private void color_picker_MouseClick(object sender, MouseEventArgs e)
        {
            palette_.UpdateColor(color_picker,e);

            picture_color.BackColor = palette_.Color;
            tool_.Pen.Color = palette_.Color;
        }
        private void clear_button_Click(object sender, EventArgs e)
        {
            tool_.Clear(pictureBox);
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (tool_.Index == MODE.FILL)
            {
                tool_.Fill(pictureBox, e.Location, palette_.Color);
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = tool_.Bitmap.Clone(new Rectangle(0, 0, pictureBox.Width, pictureBox.Height), tool_.Bitmap.PixelFormat);
                bitmap.Save(sfd.FileName, ImageFormat.Jpeg);
                MessageBox.Show("Image Saved Sucessfully");
            }
        }

        private void button_pencil_Click(object sender, EventArgs e)
        {
            tool_.Index = MODE.PEN;
        }

        private void button_eraser_Click(object sender, EventArgs e)
        {
            tool_.Index = MODE.ERASE;
        }

        private void button_ellipse_Click(object sender, EventArgs e)
        {
            tool_.Index = MODE.DRAW_ELLIPSE;
        }

        private void button_rectangle_Click(object sender, EventArgs e)
        {
            tool_.Index = MODE.DRAW_RECTANGLE;
        }

        private void button_line_Click(object sender, EventArgs e)
        {
            tool_.Index = MODE.DRAW_LINE;
        }

        private void button_fill_Click(object sender, EventArgs e)
        {
            tool_.Index = MODE.FILL;
        }

    }
}
