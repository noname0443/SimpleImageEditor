using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Size pictureBoxDefaultSize;

        private void changePictureSize(PictureBox pictureBox, int zoomBarValue)
        {
            pictureBox.Height = (int)((float)(pictureBoxDefaultSize.Height) * ((float)zoomBarValue / 100.0f));
            pictureBox.Width = (int)((float)(pictureBoxDefaultSize.Width) * ((float)zoomBarValue / 100.0f));
        }

        private Bitmap makeGrayScale(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color color = bmp.GetPixel(i, j);
                    byte grayColor = (byte)(0.3 * color.R + 0.59 * color.G + 0.11 * color.B);
                    bmp.SetPixel(i, j, Color.FromArgb(grayColor, grayColor, grayColor));
                }
            }
            return bmp;
        }

        private Bitmap ThresholdNegative(Bitmap bmp, int p)
        {
            Func<int, int, int> S = (int Color, int Brightness) =>
            {
                if (Brightness >= p) return 255 - Color;
                else return Color;
            };

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color color = bmp.GetPixel(i, j);
                    int brightness = (int)(0.3 * color.R + 0.59 * color.G + 0.11 * color.B);
                    bmp.SetPixel(i, j,
                        Color.FromArgb(
                            S(color.R, brightness),
                            S(color.G, brightness),
                            S(color.B, brightness))
                        );
                }
            }
            return bmp;
        }

        private Bitmap Thresholding(Bitmap bmp, int p)
        {
            Func<int, int> S = (int Brightness) =>
            {
                if (Brightness >= p) return 255;
                else return 0;
            };

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color color = bmp.GetPixel(i, j);
                    int brightness = (int)(0.3 * color.R + 0.59 * color.G + 0.11 * color.B);
                    bmp.SetPixel(i, j,
                        Color.FromArgb(
                            S(brightness),
                            S(brightness),
                            S(brightness))
                        );
                }
            }
            return bmp;
        }

        private Bitmap UpChangeContrast(Bitmap bmp, int Q1, int Q2)
        {
            if (Q1 == Q2) return bmp;
            Func<int, int> S = (int Color) =>
            {
                if (Color < Q1) return 0;
                else if (Color > Q2) return 255;
                else return 255 * (Color - Q1) / (Q2 - Q1);
            };

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color color = bmp.GetPixel(i, j);
                    bmp.SetPixel(i, j,
                        Color.FromArgb(
                            S(color.R),
                            S(color.G),
                            S(color.B))
                        );
                }
            }
            return bmp;
        }

        private Bitmap DownChangeContrast(Bitmap bmp, int Q1, int Q2)
        {
            if (Q1 == Q2) return bmp;
            Func<int, int> S = (int Color) =>
            {
                return Q1 + Color * (Q2 - Q1) / 255;
            };

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color color = bmp.GetPixel(i, j);
                    bmp.SetPixel(i, j,
                        Color.FromArgb(
                            S(color.R),
                            S(color.G),
                            S(color.B))
                        );
                }
            }
            return bmp;
        }

        private Bitmap changeBrightness(Bitmap bmp, int value)
        {
            Func<int, int, int> S = (int Color, int Brightness) =>
            {
                if (Color + Brightness > 255) return 255;
                else if (Color + Brightness < 0) return 0;
                else return Color + Brightness;
            };

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color color = bmp.GetPixel(i, j);
                    bmp.SetPixel(i, j,
                        Color.FromArgb(
                            S(color.R, value),
                            S(color.G, value),
                            S(color.B, value))
                        );
                }
            }
            return bmp;
        }

        private Bitmap GammaConversion(Bitmap bmp, double gamma)
        {
            Func<int, int> S = (int Color) =>
            {
                return (int)(255 * Math.Pow(Color / 255.0, gamma));
            };

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color color = bmp.GetPixel(i, j);
                    bmp.SetPixel(i, j,
                        Color.FromArgb(
                            S(color.R),
                            S(color.G),
                            S(color.B))
                        );
                }
            }
            return bmp;
        }

        private void makePanel(PictureBox pictureBox)
        {
            Form2 form = new Form2();
            form.BringToFront();
            form.Show();
            form.TopMost = true;
            form.TopLevel = true;
            form.mainPictureBox.Image = pictureBox.Image;

            form.deleteButton.Click += (a, b) => {
                pictureBox.Dispose();
                form.Close();
            };

            form.zoomBar.Scroll += (a, b) =>
            {
                Console.WriteLine(form.zoomBar.Value);
                changePictureSize(form.mainPictureBox, form.zoomBar.Value);
            };

            form.changeBrightness.Click += (a, b) => {
                Bitmap bmp = new Bitmap(form.mainPictureBox.Image);
                form.mainPictureBox.Image = changeBrightness(bmp, (int)form.changeBrightnessNumeric.Value);
            };

            form.makeThresholdNegative.Click += (a, b) =>
            {
                Bitmap bmp = new Bitmap(form.mainPictureBox.Image);
                form.mainPictureBox.Image = ThresholdNegative(bmp, (int)form.changeThresholdNegative.Value);
            };

            form.makeThresholding.Click += (a, b) =>
            {
                Bitmap bmp = new Bitmap(form.mainPictureBox.Image);
                form.mainPictureBox.Image = Thresholding(bmp, (int)form.changeThresholding.Value);
            };

            form.makeGammaConversion.Click += (a, b) =>
            {
                try
                {
                    Bitmap bmp = new Bitmap(form.mainPictureBox.Image);
                    form.mainPictureBox.Image = GammaConversion(bmp, double.Parse(form.changeGammaConversion.Text.Replace('.', ','), System.Globalization.NumberStyles.Float));
                }
                catch {}
            };

            form.makeUpContrast.Click += (a, b) =>
            {
                Bitmap bmp = new Bitmap(form.mainPictureBox.Image);
                form.mainPictureBox.Image = UpChangeContrast(bmp, (int)form.upChangeContrastQ1.Value, (int)form.upChangeContrastQ2.Value);
            };

            form.makeDownContrast.Click += (a, b) =>
            {
                Bitmap bmp = new Bitmap(form.mainPictureBox.Image);
                form.mainPictureBox.Image = DownChangeContrast(bmp, (int)form.downChangeContrastQ1.Value, (int)form.downChangeContrastQ2.Value);
            };

            form.makeGrayScale.Click += (a, b) => {
                Bitmap bmp = new Bitmap(form.mainPictureBox.Image);
                form.mainPictureBox.Image = makeGrayScale(bmp);
            };

            form.FormClosed += (a,b) => {
                this.Enabled = true;
            };

            form.applyButton.Click += (a, b) => {
                pictureBox.Image = form.mainPictureBox.Image;
                form.Close();
            };

            this.Enabled = false;
        }

        public void onPictureClick(object sender, EventArgs e, PictureBox pictureBox)
        {
            makePanel(pictureBox);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap bitmap = new Bitmap(textBox1.Text);
                PictureBox pictureBox1 = new PictureBox();
                pictureBoxDefaultSize = pictureBox1.Size;
                changePictureSize(pictureBox1, this.zoomBar.Value);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = bitmap;
                pictureBox1.Click += new EventHandler(
                    (a, b) =>
                    {
                        onPictureClick(a, b, pictureBox1);
                    }
                );
                flowLayoutPanel1.Controls.Add(pictureBox1);
            }
            catch (Exception)
            {
                
            }
        }

        private void zoomBar_Scroll(object sender, EventArgs e)
        {
            foreach (PictureBox pictureBox in flowLayoutPanel1.Controls.OfType<PictureBox>())
            {
                changePictureSize(pictureBox, this.zoomBar.Value);
            }
        }
    }
}
