﻿using System;
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
                    brightness[(byte)(0.3 * color.R + 0.59 * color.G + 0.11 * color.B)]++;
                }
            }

            form.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            form.chart1.ChartAreas[0].AxisX.Interval = 5;
            form.chart1.ChartAreas[0].AxisX.Minimum = 0;
            form.chart1.ChartAreas[0].AxisX.Maximum = 255;
            int x = 0;
            for (int i = 0; i < 255; i++)
            {
                form.chart1.Series[0].Points.AddXY(x, brightness[i]);
                x++;
            }
        }
    }
}
