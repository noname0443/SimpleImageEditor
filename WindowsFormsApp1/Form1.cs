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
        public static int Normalize(int value)
        {
            return value >= 0 ? value <= 255 ? value : 255 : 0;
        }

        public static (int, int, int) fromColor(Color color)
        {
            return (color.R, color.G, color.B);
        }

        public static Color toColor((int, int, int) value)
        {
            return Color.FromArgb(
                Normalize(value.Item1),
                Normalize(value.Item2),
                Normalize(value.Item3)
            );
        }

        public static (int, int, int) Mult((int, int, int) value, double c)
        {
            return ((int)((double)value.Item1 * c),
                (int)((double)value.Item2 * c),
                (int)((double)value.Item3 * c)
            );
        }

        public static (int, int, int) Sum((int, int, int) a, (int, int, int) b)
        {
            return (a.Item1 + b.Item1,
                a.Item2 + b.Item2,
                a.Item3 + b.Item3
                );
        }
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

        public static Bitmap makeSmooth(Bitmap bmp)
        {
            Bitmap bmp2 = (Bitmap)bmp.Clone();
            for (int i = 1; i < bmp.Width - 1; i++)
            {
                for (int j = 1; j < bmp.Height - 1; j++)
                {
                    Color sourceColor = bmp.GetPixel(i - 1, j - 1);
                    (int, int, int) result = (sourceColor.R, sourceColor.G, sourceColor.B);
                    result = Mult(result, 1.0 / 9.0);
                    result = Sum(result, Mult(fromColor(bmp.GetPixel(i - 1, j)), 1.0 / 9.0));
                    result = Sum(result, Mult(fromColor(bmp.GetPixel(i + 1, j + 1)), 1.0 / 9.0));
                    result = Sum(result, Mult(fromColor(bmp.GetPixel(i, j - 1)), 1.0 / 9.0));
                    result = Sum(result, Mult(fromColor(bmp.GetPixel(i, j)), 1.0 / 9.0));
                    result = Sum(result, Mult(fromColor(bmp.GetPixel(i, j + 1)), 1.0 / 9.0));
                    result = Sum(result, Mult(fromColor(bmp.GetPixel(i + 1, j - 1)), 1.0 / 9.0));
                    result = Sum(result, Mult(fromColor(bmp.GetPixel(i + 1, j)), 1.0 / 9.0));
                    result = Sum(result, Mult(fromColor(bmp.GetPixel(i + 1, j + 1)), 1.0 / 9.0));

                    bmp2.SetPixel(i, j, toColor(result));
                }
            }
            return bmp2;
        }

        public static Bitmap makeSharp(Bitmap bmp)
        {
            Bitmap bmp2 = (Bitmap)bmp.Clone();
            for (int i = 1; i < bmp.Width - 1; i++)
            {
                for (int j = 1; j < bmp.Height - 1; j++)
                {
                    Color sourceColor = bmp.GetPixel(i - 1, j - 1);
                    (int, int, int) result = (sourceColor.R, sourceColor.G, sourceColor.B);
                    result = Mult(result, -1.0);
                    result = Sum(result, Mult(fromColor(bmp.GetPixel(i - 1, j)), -1.0));
                    result = Sum(result, Mult(fromColor(bmp.GetPixel(i + 1, j + 1)), -1.0));
                    result = Sum(result, Mult(fromColor(bmp.GetPixel(i, j - 1)), -1.0));
                    result = Sum(result, Mult(fromColor(bmp.GetPixel(i, j)), 9.0));
                    result = Sum(result, Mult(fromColor(bmp.GetPixel(i, j + 1)), -1.0));
                    result = Sum(result, Mult(fromColor(bmp.GetPixel(i + 1, j - 1)), -1.0));
                    result = Sum(result, Mult(fromColor(bmp.GetPixel(i + 1, j)), -1.0));
                    result = Sum(result, Mult(fromColor(bmp.GetPixel(i + 1, j + 1)), -1.0));

                    bmp2.SetPixel(i, j, toColor(result));
                }
            }
            return bmp2;
        }

        public static Bitmap useMedianFilter(Bitmap bmp)
        {
            Func<Color, Color, int> Comparer = (Color a, Color b) =>
            {
                byte aC = (byte)(0.3 * a.R + 0.59 * a.G + 0.11 * a.B);
                byte bC = (byte)(0.3 * b.R + 0.59 * b.G + 0.11 * b.B);

                if (aC < bC)
                    return 1;
                if (aC == bC)
                    return 0;
                return -1;
            };
            Bitmap bmp2 = (Bitmap)bmp.Clone();
            for (int i = 1; i < bmp.Width - 1; i++)
            {
                for (int j = 1; j < bmp.Height - 1; j++)
                {
                    List<Color> list = new List<Color>();
                    list.Add(bmp.GetPixel(i - 1, j - 1));
                    list.Add(bmp.GetPixel(i - 1, j));
                    list.Add(bmp.GetPixel(i - 1, j + 1));

                    list.Add(bmp.GetPixel(i, j - 1));
                    list.Add(bmp.GetPixel(i, j));
                    list.Add(bmp.GetPixel(i, j + 1));

                    list.Add(bmp.GetPixel(i + 1, j - 1));
                    list.Add(bmp.GetPixel(i + 1, j));
                    list.Add(bmp.GetPixel(i + 1, j + 1));

                    list.Sort((x, y) => Comparer(x, y));

                    bmp2.SetPixel(i, j, list[4]);
                }
            }
            return bmp2;
        }

        public static Bitmap StochasticAlignment(Bitmap bmp)
        {
            Func<int, int> ToNear = (int value) =>
            {
                return value < 128 ? 0 : 255;
            };
            Func<Color, Color, double, Color> GetAlignment = (Color src, Color to, double c) =>
            {
                (int, int, int) colorInt = (src.R, src.G, src.B);
                (int, int, int) colorBin = (ToNear(src.R), ToNear(src.G), ToNear(src.B));

                (int, int, int) colorToInt = (to.R, to.G, to.B);
                return Color.FromArgb(
                    Normalize(colorToInt.Item1 + (int)((colorInt.Item1 - colorBin.Item1) * c)),
                    Normalize(colorToInt.Item2 + (int)((colorInt.Item2 - colorBin.Item2) * c)),
                    Normalize(colorToInt.Item3 + (int)((colorInt.Item3 - colorBin.Item3) * c))
                    );
            };
            Bitmap bmp2 = (Bitmap)bmp.Clone();
            for (int i = 1; i < bmp.Width - 1; i++)
            {
                for (int j = 0; j < bmp.Height - 1; j++)
                {
                    Color curColor = bmp.GetPixel(i, j);
                    bmp2.SetPixel(i-1, j + 1, GetAlignment(curColor, bmp.GetPixel(i-1,j+1), 3.0 / 16.0));
                    bmp2.SetPixel(i, j + 1, GetAlignment(curColor, bmp.GetPixel(i, j + 1), 5.0 / 16.0));
                    bmp2.SetPixel(i + 1, j + 1, GetAlignment(curColor, bmp.GetPixel(i + 1, j + 1), 1.0 / 16.0));
                    bmp2.SetPixel(i + 1, j, GetAlignment(curColor, bmp.GetPixel(i + 1, j), 7.0 / 16.0));
                }
            }
            return bmp2;
        }

        public static Bitmap makeStrengtheningBoundaries(Bitmap bmp)
        {
            Bitmap bmp2 = (Bitmap)bmp.Clone();
            for (int i = 1; i < bmp.Width - 1; i++)
            {
                for (int j = 1; j < bmp.Height - 1; j++)
                {
                    Color sourceColor = bmp.GetPixel(i - 1, j);
                    (int, int, int) result = (sourceColor.R, sourceColor.G, sourceColor.B);
                    result = Mult(result, -1.0);
                    result = Sum(result, Mult(fromColor(bmp.GetPixel(i, j - 1)), -1.0));
                    result = Sum(result, Mult(fromColor(bmp.GetPixel(i, j)), 4.0));
                    result = Sum(result, Mult(fromColor(bmp.GetPixel(i, j + 1)), -1.0));
                    result = Sum(result, Mult(fromColor(bmp.GetPixel(i + 1, j)), -1.0));

                    bmp2.SetPixel(i, j, toColor(result));
                }
            }
            return bmp2;
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
        public static Bitmap MakeSolarization(Bitmap bmp)
        {
            Func<int, int> parabola = (int x) =>
            {
                return (int)(-4.0 / 255.0 * x * x) + 4 * x;
            };

            Func<Color, Color> S = (Color color) =>
            {
                return Color.FromArgb(parabola(color.R), parabola(color.G), parabola(color.B));
            };

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color color = bmp.GetPixel(i, j);
                    bmp.SetPixel(i, j, S(color));
                }
            }
            return bmp;
        }

        public static Bitmap MakeQuantization(Bitmap bmp, int N)
        {
            if (255.0 / N <= 1.0) return bmp;

            Func<Color, Color> S = (Color color) =>
            {
                int quant = 255 / N;
                int k_r = (int)color.R / quant;
                int k_g = (int)color.G / quant;
                int k_b = (int)color.B / quant;

                int av_r = (k_r * quant + (k_r + 1) * quant) / 2;
                int av_g = (k_g * quant + (k_g + 1) * quant) / 2;
                int av_b = (k_b * quant + (k_b + 1) * quant) / 2;

                if (av_r > 255)
                    av_r = 255;
                if (av_g > 255)
                    av_g = 255;
                if (av_b > 255)
                    av_b = 255;

                if (av_r < 0)
                    av_r = 0;
                if (av_g < 0)
                    av_g = 0;
                if (av_b < 0)
                    av_b = 0;

                return Color.FromArgb(av_r, av_g, av_b);
            };

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color color = bmp.GetPixel(i, j);
                    bmp.SetPixel(i, j, S(color));
                }
            }
            return bmp;
        }

        public static Bitmap MakePseudoColor(Bitmap bmp, int[] intervals, Color[] colors)
        {
            Func<int, Color> S = (int gray) =>
            {
                for (int i = 0; i < intervals.Length; i++)
                {
                    if (gray < intervals[i])
                    {
                        return colors[i];
                    }
                }
                return colors[colors.Length - 1];
            };

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color color = bmp.GetPixel(i, j);
                    int brightness = (int)(0.3 * color.R + 0.59 * color.G + 0.11 * color.B);
                    bmp.SetPixel(i, j, S(brightness));
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

        public static Bitmap RotateImage(Bitmap bmp, double angle)
        {
            int x0 = bmp.Width / 2;
            int y0 = bmp.Height / 2; // REMAKE
            double rad = Math.PI * angle / 180.0;

            Bitmap b2 = new Bitmap(bmp.Width, bmp.Height);
            for (int X = 0; X < b2.Width; X++)
            {
                for (int Y = 0; Y < b2.Height; Y++)
                {
                    int x = (int)((double)(X - x0) * Math.Cos(rad) + (double)(Y - y0) * Math.Sin(rad)) + x0;
                    int y = (int)(-(double)(X - x0) * Math.Sin(rad) + (double)(Y - y0) * Math.Cos(rad)) + y0;
                    if (x >= 0 && y >= 0 && x < bmp.Width && y < bmp.Height)
                        b2.SetPixel(X, Y, bmp.GetPixel(x, y));
                }
            }
            return b2;
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
