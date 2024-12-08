namespace curse_works
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.color_picker = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_color = new System.Windows.Forms.Button();
            this.button_fill = new System.Windows.Forms.Button();
            this.button_pencil = new System.Windows.Forms.Button();
            this.button_eraser = new System.Windows.Forms.Button();
            this.button_ellipse = new System.Windows.Forms.Button();
            this.button_rectangle = new System.Windows.Forms.Button();
            this.button_line = new System.Windows.Forms.Button();
            this.picture_color = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.save_button = new System.Windows.Forms.Button();
            this.open_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 105);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowLayoutPanel1.Controls.Add(this.color_picker);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(595, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(266, 100);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // color_picker
            // 
            this.color_picker.BackColor = System.Drawing.Color.Silver;
            this.color_picker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_picker.Image = global::curse_works.Properties.Resources.color_palette;
            this.color_picker.Location = new System.Drawing.Point(3, 3);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(260, 95);
            this.color_picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.color_picker.TabIndex = 3;
            this.color_picker.TabStop = false;
            this.color_picker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color_picker_MouseClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.button_color);
            this.panel3.Controls.Add(this.button_fill);
            this.panel3.Controls.Add(this.button_pencil);
            this.panel3.Controls.Add(this.button_eraser);
            this.panel3.Controls.Add(this.button_ellipse);
            this.panel3.Controls.Add(this.button_rectangle);
            this.panel3.Controls.Add(this.button_line);
            this.panel3.Location = new System.Drawing.Point(3, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(528, 80);
            this.panel3.TabIndex = 3;
            // 
            // button_color
            // 
            this.button_color.BackColor = System.Drawing.Color.Black;
            this.button_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color.ForeColor = System.Drawing.Color.White;
            this.button_color.Image = global::curse_works.Properties.Resources.color;
            this.button_color.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_color.Location = new System.Drawing.Point(448, 13);
            this.button_color.Name = "button_color";
            this.button_color.Size = new System.Drawing.Size(67, 58);
            this.button_color.TabIndex = 1;
            this.button_color.Text = "Color";
            this.button_color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_color.UseVisualStyleBackColor = false;
            this.button_color.Click += new System.EventHandler(this.button_color_Click);
            // 
            // button_fill
            // 
            this.button_fill.BackColor = System.Drawing.Color.Black;
            this.button_fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button_fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_fill.ForeColor = System.Drawing.Color.White;
            this.button_fill.Image = global::curse_works.Properties.Resources.bucket;
            this.button_fill.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_fill.Location = new System.Drawing.Point(10, 13);
            this.button_fill.Name = "button_fill";
            this.button_fill.Size = new System.Drawing.Size(67, 58);
            this.button_fill.TabIndex = 2;
            this.button_fill.Text = "Fill";
            this.button_fill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_fill.UseVisualStyleBackColor = false;
            this.button_fill.Click += new System.EventHandler(this.button_fill_Click);
            // 
            // button_pencil
            // 
            this.button_pencil.BackColor = System.Drawing.Color.Black;
            this.button_pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pencil.ForeColor = System.Drawing.Color.White;
            this.button_pencil.Image = global::curse_works.Properties.Resources.pencil;
            this.button_pencil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_pencil.Location = new System.Drawing.Point(83, 13);
            this.button_pencil.Name = "button_pencil";
            this.button_pencil.Size = new System.Drawing.Size(67, 58);
            this.button_pencil.TabIndex = 3;
            this.button_pencil.Text = "Pencil";
            this.button_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_pencil.UseVisualStyleBackColor = false;
            this.button_pencil.Click += new System.EventHandler(this.button_pencil_Click);
            // 
            // button_eraser
            // 
            this.button_eraser.BackColor = System.Drawing.Color.Black;
            this.button_eraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eraser.ForeColor = System.Drawing.Color.White;
            this.button_eraser.Image = global::curse_works.Properties.Resources.eraser;
            this.button_eraser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_eraser.Location = new System.Drawing.Point(156, 13);
            this.button_eraser.Name = "button_eraser";
            this.button_eraser.Size = new System.Drawing.Size(67, 58);
            this.button_eraser.TabIndex = 4;
            this.button_eraser.Text = "Eraser";
            this.button_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_eraser.UseVisualStyleBackColor = false;
            this.button_eraser.Click += new System.EventHandler(this.button_eraser_Click);
            // 
            // button_ellipse
            // 
            this.button_ellipse.BackColor = System.Drawing.Color.Black;
            this.button_ellipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ellipse.ForeColor = System.Drawing.Color.White;
            this.button_ellipse.Image = global::curse_works.Properties.Resources.circle;
            this.button_ellipse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_ellipse.Location = new System.Drawing.Point(229, 13);
            this.button_ellipse.Name = "button_ellipse";
            this.button_ellipse.Size = new System.Drawing.Size(67, 58);
            this.button_ellipse.TabIndex = 5;
            this.button_ellipse.Text = "Ellipse";
            this.button_ellipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_ellipse.UseVisualStyleBackColor = false;
            this.button_ellipse.Click += new System.EventHandler(this.button_ellipse_Click);
            // 
            // button_rectangle
            // 
            this.button_rectangle.BackColor = System.Drawing.Color.Black;
            this.button_rectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_rectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button_rectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button_rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rectangle.ForeColor = System.Drawing.Color.White;
            this.button_rectangle.Image = global::curse_works.Properties.Resources.rectangle;
            this.button_rectangle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_rectangle.Location = new System.Drawing.Point(302, 13);
            this.button_rectangle.Name = "button_rectangle";
            this.button_rectangle.Size = new System.Drawing.Size(67, 58);
            this.button_rectangle.TabIndex = 6;
            this.button_rectangle.Text = "Rectangle";
            this.button_rectangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_rectangle.UseVisualStyleBackColor = false;
            this.button_rectangle.Click += new System.EventHandler(this.button_rectangle_Click);
            // 
            // button_line
            // 
            this.button_line.BackColor = System.Drawing.Color.Black;
            this.button_line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_line.ForeColor = System.Drawing.Color.White;
            this.button_line.Image = global::curse_works.Properties.Resources.line;
            this.button_line.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_line.Location = new System.Drawing.Point(375, 13);
            this.button_line.Name = "button_line";
            this.button_line.Size = new System.Drawing.Size(67, 58);
            this.button_line.TabIndex = 7;
            this.button_line.Text = "Line";
            this.button_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_line.UseVisualStyleBackColor = false;
            this.button_line.Click += new System.EventHandler(this.button_line_Click);
            // 
            // picture_color
            // 
            this.picture_color.BackColor = System.Drawing.Color.Black;
            this.picture_color.ForeColor = System.Drawing.Color.White;
            this.picture_color.Location = new System.Drawing.Point(819, 1);
            this.picture_color.Name = "picture_color";
            this.picture_color.Size = new System.Drawing.Size(42, 25);
            this.picture_color.TabIndex = 0;
            this.picture_color.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.picture_color);
            this.panel2.Controls.Add(this.save_button);
            this.panel2.Controls.Add(this.open_button);
            this.panel2.Controls.Add(this.clear_button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 483);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(864, 28);
            this.panel2.TabIndex = 1;
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.Black;
            this.save_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.save_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_button.ForeColor = System.Drawing.Color.White;
            this.save_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_button.Location = new System.Drawing.Point(85, 3);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(67, 22);
            this.save_button.TabIndex = 10;
            this.save_button.Text = "Save";
            this.save_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // open_button
            // 
            this.open_button.BackColor = System.Drawing.Color.Black;
            this.open_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.open_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.open_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_button.ForeColor = System.Drawing.Color.White;
            this.open_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.open_button.Location = new System.Drawing.Point(12, 3);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(67, 22);
            this.open_button.TabIndex = 9;
            this.open_button.Text = "Open";
            this.open_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.open_button.UseVisualStyleBackColor = false;
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.Black;
            this.clear_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.clear_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_button.ForeColor = System.Drawing.Color.White;
            this.clear_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clear_button.Location = new System.Drawing.Point(158, 3);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(67, 22);
            this.clear_button.TabIndex = 8;
            this.clear_button.Text = "Clear";
            this.clear_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(864, 511);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button picture_color;
        private System.Windows.Forms.Button button_color;
        private System.Windows.Forms.Button button_fill;
        private System.Windows.Forms.Button button_line;
        private System.Windows.Forms.Button button_rectangle;
        private System.Windows.Forms.Button button_ellipse;
        private System.Windows.Forms.Button button_eraser;
        private System.Windows.Forms.Button button_pencil;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox color_picker;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

