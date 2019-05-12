using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Imaging;

namespace MainPaint
{
    public partial class FormA2 : Form
    {

        public FormA2()
        {
            InitializeComponent();
        }
        Image imgOriginal;

        string fileName;
        Bitmap cropBitmap;
        int cropX;
        int cropY;
        int cropHeight;
        int cropWidth;
        public Pen cropPen;
        public int cropPenSize = 2;
        public DashStyle cropDashStyle = DashStyle.Solid;
        public Color cropPenColor = Color.Aquamarine;
        public Cursors cc;

        Graphics g;
        Pen pp = new Pen(Color.Black);
        Point start = new Point(0, 0);
        Point end = new Point(0, 0);
        bool drawing = false;

        int tebal = 1, initialX, initialY;
        Pen p;
        Color wrn, wrn1;
        private Graphics objGraphic;
        private bool shouldPaint = false, warna = false;
        Boolean line, rectang, circle, triangle;


        double px, py, vector, angle;


        private Point preCoor, newCoor;

        int width, height;
        int cirW, cirL;


        private List<Point> points = new List<Point>();



        Point a, b, c;
        Point[] list = new Point[3];


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            objGraphic = pictureBox1.CreateGraphics();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pp.Width = (int)numericUpDown1.Value;
            tebal = (int)numericUpDown1.Value;
        }

        void reset()
        {
            line = false; rectang = false;
            circle = false; triangle = false;
        }


        void colour()
        {
            warna = true;
            p = new Pen(wrn);
            if (tebal == 0)
            {
                DialogResult box;
                box = MessageBox.Show("Width input cannot 0 pixel", "Error", MessageBoxButtons.RetryCancel);
                if (box == DialogResult.Cancel)
                { this.Dispose(); }
            }
        }


        void rumusline()
        {
            px = newCoor.X; py = newCoor.Y;
            vector = Math.Sqrt((Math.Pow(px, 2)) + (Math.Pow(py, 2)));
            angle = Math.Atan(py / px) * 180 / Math.PI;
        }


        void rumusrectang()
        {
            px = width; py = height;
            vector = px * py;
            if (rectang == true)
            { angle = 0; }
        }

        void rumuscircle()
        {
            px = cirW; py = cirL;
            vector = Math.PI * 0.5 * (cirW + cirL);
            if (circle == true)
            { angle = 360; }
        }

        void rumustriangle()
        {
            px = b.X - a.X; py = c.Y;
            vector = 0.5 * px * py;
            if (triangle == true)
            { angle = 180; }
        }

        void buttoncolor()
        {
            linne.BackColor = Color.Snow; rectangle.BackColor = Color.Snow;
            circl.BackColor = Color.Snow; trian.BackColor = Color.Snow;
        }

        private void cut_Click(object sender, EventArgs e)
        {
            try
            {
                if (cropWidth < 1)
                {
                    MessageBox.Show("You need to first slect what portion of the image to crop.", "No cropping Cordinates!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    pictureBox2.Visible = true;
                    Rectangle rect = new Rectangle(cropX, cropY, cropWidth, cropHeight);
                    Bitmap bit = new Bitmap(pictureBox3.Image, pictureBox3.Width, pictureBox3.Height);
                    cropBitmap = new Bitmap(cropWidth, cropHeight);
                    Graphics g = Graphics.FromImage(cropBitmap);
                    g.DrawImage(bit, 0, 0, rect, GraphicsUnit.Pixel);
                    pictureBox3.Visible = false;
                    pictureBox2.Image = cropBitmap;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void crop_Click(object sender, EventArgs e)
        {
            try
            {
                if (cropWidth < 1)
                {
                    MessageBox.Show("You need to first slect what portion of the image to crop.", "No cropping Cordinates!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    pictureBox2.Visible = true;
                    Rectangle rect = new Rectangle(cropX, cropY, cropWidth, cropHeight);
                    Bitmap bit = new Bitmap(pictureBox3.Image, pictureBox3.Width, pictureBox3.Height);
                    cropBitmap = new Bitmap(cropWidth, cropHeight);
                    Graphics g = Graphics.FromImage(cropBitmap);
                    g.DrawImage(bit, 0, 0, rect, GraphicsUnit.Pixel);
                    pictureBox2.Image = cropBitmap;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {

                if (e.Button == MouseButtons.Left)
                {
                    pictureBox3.Refresh();
                    cropWidth = e.X - cropX;
                    cropHeight = e.Y - cropY;
                    pictureBox3.CreateGraphics().DrawRectangle(cropPen, cropX, cropY, cropWidth, cropHeight);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormA3 fm3 = new FormA3();
            fm3.ShowDialog();
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    cropX = e.X;
                    cropY = e.Y;
                    cropPen = new Pen(cropPenColor, cropPenSize);
                    cropPen.DashStyle = cropDashStyle;
                    Cursor = Cursors.Cross;
                }
                pictureBox3.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            start = e.Location;

            if (e.Button == MouseButtons.Left)
            {
                drawing = true;
            }

            if (e.Button == MouseButtons.Left && warna == true)
            {
                if (line == true)
                {
                    shouldPaint = true;
                    preCoor = e.Location; newCoor = preCoor;
                    pictureBox1.Invalidate();
                }

                else if (rectang == true)
                {
                    shouldPaint = true;
                    initialX = e.X; initialY = e.Y;
                    pictureBox1.Invalidate();
                }

                else if (circle == true)
                {
                    shouldPaint = true;
                    initialX = e.X; initialY = e.Y;
                    pictureBox1.Invalidate();
                }

                else if (triangle == true)
                {
                    shouldPaint = true;
                    Point a = e.Location; points.Add(a);
                    pictureBox1.Invalidate();
                }
            }
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (checkBox2.Checked && (int)numericUpDown1.Value != 0)
            {
                triangle = false;
                line = false;
                circle = false;
                rectang = false;

                pp.Color = colorDialog1.Color;
                if (warna == true)
                {
                    pp.Color = colorDialog1.Color;

                    if (drawing)
                    {

                        end = e.Location;
                        g = pictureBox1.CreateGraphics();
                        g.DrawRectangle(pp, e.X, e.Y, 32, 32);
                    }
                }
            }

            if (checkBox1.Checked && (int)numericUpDown1.Value != 0)
            {
                triangle = false;
                line = false;
                circle = false;
                rectang = false;

                if (warna == true)
                {
                    pp.Color = colorDialog1.Color;

                    if (drawing)
                    {
                        end = e.Location;
                        g = pictureBox1.CreateGraphics();
                        g.DrawLine(pp, start, end);
                    }
                }
            }

            if (shouldPaint == true && warna == true)
            {
                if (line == true)
                {
                    ControlPaint.DrawReversibleLine(pictureBox1.PointToScreen(preCoor), pictureBox1.PointToScreen(newCoor), wrn1);
                    newCoor = new Point(e.X, e.Y);
                    ControlPaint.DrawReversibleLine(pictureBox1.PointToScreen(preCoor), pictureBox1.PointToScreen(newCoor), wrn1);
                }

                else if (rectang == true)
                {
                    this.Refresh();
                    p.Width = tebal;
                    width = e.X - initialX;
                    height = e.Y - initialY;
                    Rectangle rect = new Rectangle(Math.Min(e.X, initialX),
                    Math.Min(e.Y, initialY),
                    Math.Abs(e.X - initialX),
                    Math.Abs(e.Y - initialY));
                    objGraphic.DrawRectangle(p, rect);
                }

                else if (circle == true)
                {
                    this.Refresh();
                    p.Width = tebal;
                    cirW = Math.Abs(e.X - initialX);
                    cirL = Math.Abs(e.Y - initialY);
                    Rectangle rec = new Rectangle(Math.Min(e.X, initialX),
                    Math.Min(e.Y, initialY),
                    Math.Abs(e.X - initialX),
                    Math.Abs(e.Y - initialY));
                    objGraphic.DrawEllipse(p, rec);
                }

                else if (triangle == true)
                {
                    Point a = e.Location;
                    points.Add(a);
                    p.Width = tebal;
                    System.Diagnostics.Debug.WriteLine(e.Y);
                    a = points[0];
                    a.X = (points[0].X + points[points.Count - 1].X) / 2;
                    b = points[points.Count - 1];
                    b.X = points[0].X;
                    c = points[points.Count - 1];
                    list[0] = a;
                    list[1] = b;
                    list[2] = c;
                }
            }
            start = end;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;

            if (shouldPaint == true && warna == true)
            {
                if (line == true)
                {
                    p.Width = tebal;
                    ControlPaint.DrawReversibleLine(pictureBox1.PointToScreen(preCoor), pictureBox1.PointToScreen(newCoor), wrn1);
                    objGraphic.DrawLine(p, preCoor, newCoor);
                    rumusline(); shouldPaint = false;
                }

                else if (rectang == true)
                { rumusrectang(); shouldPaint = false; }

                else if (circle == true)
                { rumuscircle(); shouldPaint = false; }

                else if (triangle == true)
                {
                    this.Refresh();
                    objGraphic.DrawPolygon(p, list);
                    foreach (Point el in points)
                        System.Diagnostics.Debug.WriteLine(el);
                    rumustriangle(); shouldPaint = false;
                }
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (line == false && rectang == false && circle == false && triangle == false && checkBox1.Checked == false && checkBox2.Checked == false)
            {
                DialogResult box2;
                box2 = MessageBox.Show("Please, Select Shape or Tool", "Warning!", MessageBoxButtons.RetryCancel);
                if (box2 == DialogResult.Cancel)
                { this.Dispose(); }
            }

            if (warna == false)
            {
                DialogResult box1;

                box1 = MessageBox.Show("Please, Select Color", "Warning!", MessageBoxButtons.OKCancel);
                if (box1 == DialogResult.Cancel)
                { this.Dispose(); }
            }

            if ((int)numericUpDown1.Value == 0)
            //tebal == 0 && pp.Width == 0 &&
            {
                DialogResult box;
                box = MessageBox.Show("Width input cannot be 0 pixel", "Warning!", MessageBoxButtons.OKCancel);
                if (box == DialogResult.Cancel)
                { this.Dispose(); }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
                wrn = colorDialog1.Color;
                wrn1 = colorDialog1.Color;
                pp.Color = colorDialog1.Color;
            }
            colour();
        }

        private void FormA2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit ?", "Warning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                { Environment.Exit(0); }
                else
                { e.Cancel = true; }
            }
            else
            { e.Cancel = true; }
        }

        private void linne_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && checkBox1.Checked == false)
            {
                reset(); 
                line = true;
                buttoncolor(); linne.BackColor = Color.LightCyan;
            }
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && checkBox1.Checked == false)
            {
                reset(); rectang = true;
                buttoncolor(); rectangle.BackColor = Color.LightCyan;
            }
        }

        private void circl_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && checkBox1.Checked == false)
            {
                reset(); circle = true;
                buttoncolor(); circl.BackColor = Color.LightCyan;
            }
        }

        private void trian_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && checkBox1.Checked == false)
            {
                reset();
                triangle = true;
                buttoncolor();
                trian.BackColor = Color.LightCyan;
            }
        }

        private static Bitmap DrawControlToBitmap(Control control)
        {
            Bitmap bitmap = new Bitmap(control.Width, control.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            Rectangle recct = control.RectangleToScreen(control.ClientRectangle);
            graphics.CopyFromScreen(recct.Location, Point.Empty, control.Size);
            return bitmap;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = DrawControlToBitmap(pictureBox1);

            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "png|*.png;";

            if (save.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(save.FileName, ImageFormat.Jpeg);
                System.Diagnostics.Process.Start(save.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //using (OpenFileDialog opf = new OpenFileDialog() { Filter = "Png files| *.png|GPEG files|*jpg|bitmaps|*.bmp", ValidateNames = true, Multiselect = false })
            //{
            //    if (opf.ShowDialog() == DialogResult.OK)
            //    {
            //        PictureBox picture;
            //        picture = new PictureBox
            //        {
            //            Name = "pictureBox",
            //            Size = new Size(150, 150),
            //            Location = new Point(15, 18),
            //            Image = Image.FromFile(opf.FileName),
            //            SizeMode = PictureBoxSizeMode.StretchImage
            //        };
            //        pictureBox1.Controls.Add(picture);
            //    }
            //}

            using (OpenFileDialog opf = new OpenFileDialog() { Filter = "Png files| *.png|gpeg files|*jpg|bitmaps|*.bmp", ValidateNames = true, Multiselect = false })
            {
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pictureBox3.Visible = true;
                    fileName = opf.FileName;

                    pictureBox3.Image = Image.FromFile(fileName);
                }
            }
            imgOriginal = pictureBox3.Image;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }

        Image Zoom (Image img, Size size)
        {
            Bitmap bmp = new Bitmap(img, img.Width + (img.Width * size.Width / 100), img.Height + (img.Height * size.Height / 100));
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bmp;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value > 0)
            {
                pictureBox3.Image = Zoom(imgOriginal, new Size(trackBar1.Value, trackBar1.Value));
            }
            if (pictureBox3 != null)
            {
                pictureBox3.Dispose();
            }
        }

        private void FormA2_Load(object sender, EventArgs e)
        {
        }
    }
}
