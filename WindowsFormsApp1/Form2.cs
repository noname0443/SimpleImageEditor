using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zoomBar_Scroll(object sender, EventArgs e)
        {

        }

        private Point startPoint;
        private Point endPoint;
        private Rectangle selection;

        private void mainPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
        }

        private void mainPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left
                && e.X <= mainPictureBox.Image.Width
                && e.Y <= mainPictureBox.Image.Height)
            {
                int x = Math.Min(startPoint.X, e.X);
                int y = Math.Min(startPoint.Y, e.Y);
                int width = Math.Abs(startPoint.X - e.X);
                int height = Math.Abs(startPoint.Y - e.Y);
                selection = new Rectangle(x, y, width, height);

                endPoint.X = e.X;
                endPoint.Y = e.Y;
                mainPictureBox.Invalidate();
            }
        }

        private void mainPictureBox_LostFocus(object sender, EventArgs e)
        {
            selection.Width = 0;
            selection.Height = 0;
        }

        private void mainPictureBox_MouseLeave(object sender, EventArgs e)
        {
            selection.Width = 0;
            selection.Height = 0;
        }

        private static Color Interpolate((Color, Color, Color, Color) neightbors, double x, double y)
        {
            double p = x - (double)((int)x);
            double q = y - (double)((int)y);

            (int, int, int) first = Form1.Mult(Form1.fromColor(neightbors.Item1), (1-q) * (1 - p));
            (int, int, int) second = Form1.Mult(Form1.fromColor(neightbors.Item2), (1-q) * p);
            (int, int, int) third = Form1.Mult(Form1.fromColor(neightbors.Item3), q * (1 - p));
            (int, int, int) fourth = Form1.Mult(Form1.fromColor(neightbors.Item4), q * p);
            (int, int, int) sum = Form1.Sum(Form1.Sum(first, second), Form1.Sum(third, fourth));
            return Form1.toColor(sum);
        }

        private void mainPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            Bitmap source = new Bitmap(mainPictureBox.Image);

            int x0 = Math.Min(startPoint.X, endPoint.X);
            int y0 = Math.Min(startPoint.Y, endPoint.Y);

            int w = Math.Abs(startPoint.X - endPoint.X);
            int h = Math.Abs(startPoint.Y - endPoint.Y);
            if (w <= 0 || h <= 0)
                return;

            InputDialog dlg = new InputDialog();
            dlg.Text = "Enter a value";
            dlg.TopMost = true;
            dlg.TopLevel = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                double zoom = dlg.InputValue;
                if (zoom <= 0)
                    return;

                Bitmap b2 = new Bitmap((int)(w * zoom), (int)(h * zoom));
                for(int X = 0; X < b2.Width; X++)
                {
                    for(int Y = 0; Y < b2.Height; Y++)
                    {
                        double x = (x0 + (double)X / zoom);
                        double y = (y0 + (double)Y / zoom);
                        b2.SetPixel(X, Y,
                            Interpolate(
                            (
                                source.GetPixel((int)x, (int)y),
                                source.GetPixel((int)x + 1, (int)y),
                                source.GetPixel((int)x, (int)y + 1),
                                source.GetPixel((int)x + 1, (int)y + 1)
                            ),
                            x, y
                            )
                        );
                    }
                }
                this.mainPictureBox.Image = b2;
            }
            selection.Width = 0;
            selection.Height = 0;
        }

        private void mainPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (selection != null && selection.Width > 0 && selection.Height > 0)
            {
                using (Pen pen = new Pen(Color.Red, 2))
                {
                    e.Graphics.DrawRectangle(pen, selection);
                }
            }
        }

        private void makeBrightnessHistogram_Click(object sender, EventArgs e)
        {
            BrightnessChart form = new BrightnessChart();
            form.Show();
            form.CloseButton.Click += (a, b) => {
                this.TopLevel = true;
                this.TopMost = true;
                form.Close();
            };
            form.ControlBox = false;
            this.TopLevel = false;
            form.TopLevel = true;
            form.TopMost = true;

            int[] brightness = new int[256];
            Bitmap bmp = new Bitmap(this.mainPictureBox.Image);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color color = bmp.GetPixel(i, j);
                    int value = (int)(0.3 * color.R + 0.59 * color.G + 0.11 * color.B);
                    if (value >= 255) brightness[255]++;
                    else brightness[value]++;
                }
            }

            form.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            form.chart1.ChartAreas[0].AxisX.Interval = 5;
            form.chart1.ChartAreas[0].AxisX.Minimum = 0;
            form.chart1.ChartAreas[0].AxisX.Maximum = 255;
            int x = 0;
            for (int i = 0; i <= 255; i++)
            {
                form.chart1.Series[0].Points.AddXY(x, brightness[i]);
                x++;
            }
        }

        private void makePseudoColor_Click(object sender, EventArgs e)
        {
            PseudoСoloring form = new PseudoСoloring();
            form.Show();
            form.CloseButton.Click += (a, b) => {
                this.TopLevel = true;
                this.TopMost = true;
                form.Close();
            };
            form.AcceptButton.Click += (a, b) => {
                this.TopLevel = true;
                this.TopMost = true;

                int colorCount = form.flowLayoutPanel1.Controls.Count;

                int[] intervals = new int[colorCount - 1];
                Color[] colors = new Color[colorCount];

                for(int i = 0; i < colorCount - 1; i++)
                {
                    intervals[i] = (int)((NumericUpDown)((TableLayoutPanel)form.flowLayoutPanel1.Controls[i]).Controls[1]).Value;
                    colors[i] = ((Button)((TableLayoutPanel)form.flowLayoutPanel1.Controls[i]).Controls[0]).BackColor;
                }
                colors[colorCount - 1] = ((Button)((TableLayoutPanel)form.flowLayoutPanel1.Controls[colorCount - 1]).Controls[0]).BackColor;

                this.mainPictureBox.Image = Form1.MakePseudoColor(new Bitmap(this.mainPictureBox.Image), intervals, colors);
                form.Close();
            };
            form.ControlBox = false;
            this.TopLevel = false;
            form.TopLevel = true;
            form.TopMost = true;
        }

        private void makeQuantization_Click(object sender, EventArgs e)
        {
            this.mainPictureBox.Image = Form1.MakeQuantization(new Bitmap(this.mainPictureBox.Image), (int)this.changeQuantization.Value);
        }

        private void makeSolarization_Click(object sender, EventArgs e)
        {
            this.mainPictureBox.Image = Form1.MakeSolarization(new Bitmap(this.mainPictureBox.Image));
        }

        private void makeSmooth_Click(object sender, EventArgs e)
        {
            this.mainPictureBox.Image = Form1.makeSmooth(new Bitmap(this.mainPictureBox.Image));
        }

        private void makeSharp_Click(object sender, EventArgs e)
        {
            this.mainPictureBox.Image = Form1.makeSharp(new Bitmap(this.mainPictureBox.Image));
        }

        private void useMedianFilter_Click(object sender, EventArgs e)
        {
            this.mainPictureBox.Image = Form1.useMedianFilter(new Bitmap(this.mainPictureBox.Image));
        }

        private void useStochasticAlignment_Click(object sender, EventArgs e)
        {
            this.mainPictureBox.Image = Form1.StochasticAlignment(new Bitmap(this.mainPictureBox.Image));
        }

        private void makeStrengtheningBoundaries_Click(object sender, EventArgs e)
        {
            this.mainPictureBox.Image = Form1.makeStrengtheningBoundaries(new Bitmap(this.mainPictureBox.Image));
        }

        private void makeRotateButton_Click(object sender, EventArgs e)
        {
            this.mainPictureBox.Image = Form1.RotateImage(new Bitmap(this.mainPictureBox.Image), (double)this.changeRotateAngle.Value);
        }
    }
}
