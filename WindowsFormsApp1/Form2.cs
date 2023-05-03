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
    }
}
