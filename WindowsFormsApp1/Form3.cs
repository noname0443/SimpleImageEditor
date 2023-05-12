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
    public partial class Form3 : Form
    {
        private static int Normalize(int value)
        {
            return value >= 0 ? value <= 255 ? value : 255 : 0;
        }

        private static (int, int, int) fromColor(Color color)
        {
            return (color.R, color.G, color.B);
        }

        private static Color toColor((int, int, int) value)
        {
            return Color.FromArgb(
                Normalize(value.Item1),
                Normalize(value.Item2),
                Normalize(value.Item3)
            );
        }

        private static (int, int, int) Mult((int, int, int) value, double c)
        {
            return ((int)((double)value.Item1 * c),
                (int)((double)value.Item2 * c),
                (int)((double)value.Item3 * c)
            );
        }

        private static (int, int, int) Sum((int, int, int) a, (int, int, int) b)
        {
            return (a.Item1 + b.Item1,
                a.Item2 + b.Item2,
                a.Item3 + b.Item3
                );
        }

        private static Bitmap LaplasBounds(Bitmap bmp)
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

                    result = (Math.Abs(result.Item1), Math.Abs(result.Item2), Math.Abs(result.Item3));
                    bmp2.SetPixel(i, j, toColor(result));
                }
            }
            return bmp2;
        }

        private static Bitmap ShearDifferenceBounds(Bitmap bmp)
        {
            Bitmap bmp2 = (Bitmap)bmp.Clone();
            for (int i = 1; i < bmp.Width - 1; i++)
            {
                for (int j = 1; j < bmp.Height - 1; j++)
                {
                    Color sourceColor = bmp.GetPixel(i - 1, j - 1);
                    (int, int, int) result = (sourceColor.R, sourceColor.G, sourceColor.B);
                    result = Mult(result, -1.0);
                    result = Sum(result, fromColor(bmp.GetPixel(i, j)));
                    result = (Math.Abs(result.Item1), Math.Abs(result.Item2), Math.Abs(result.Item3));

                    result = Sum(result, Mult(fromColor(bmp.GetPixel(i, j - 1)), -1.0));
                    result = Sum(result, fromColor(bmp.GetPixel(i, j)));
                    result = (Math.Abs(result.Item1), Math.Abs(result.Item2), Math.Abs(result.Item3));

                    result = Sum(result, Mult(fromColor(bmp.GetPixel(i - 1, j)), -1.0));
                    result = Sum(result, fromColor(bmp.GetPixel(i, j)));

                    result = (Math.Abs(result.Item1), Math.Abs(result.Item2), Math.Abs(result.Item3));
                    bmp2.SetPixel(i, j, toColor(result));
                }
            }
            return bmp2;
        }

        private static Bitmap RobertsBounds(Bitmap bmp)
        {
            Bitmap bmp2 = (Bitmap)bmp.Clone();
            for (int i = 0; i < bmp.Width - 1; i++)
            {
                for (int j = 0; j < bmp.Height - 1; j++)
                {
                    Color sourceColor = bmp.GetPixel(i, j);
                    (int, int, int) A = (sourceColor.R, sourceColor.G, sourceColor.B);
                    A = Sum(A, Mult(fromColor(bmp.GetPixel(i + 1, j + 1)), -1.0));
                    A = (A.Item1 * A.Item1, A.Item2 * A.Item2, A.Item3 * A.Item3);

                    sourceColor = bmp.GetPixel(i, j + 1);
                    (int, int, int) B = (sourceColor.R, sourceColor.G, sourceColor.B);
                    B = Sum(B, Mult(fromColor(bmp.GetPixel(i + 1, j)), -1.0));
                    B = (B.Item1 * B.Item1, B.Item2 * B.Item2, B.Item3 * B.Item3);

                    A = Sum(A, B);
                    A = ((int)Math.Sqrt(A.Item1), (int)Math.Sqrt(A.Item2), (int)Math.Sqrt(A.Item3));

                    bmp2.SetPixel(i, j, toColor(A));
                }
            }
            return bmp2;
        }

        private static Bitmap SobelBounds(Bitmap bmp)
        {
            Bitmap bmp2 = (Bitmap)bmp.Clone();
            for (int i = 1; i < bmp.Width - 1; i++)
            {
                for (int j = 1; j < bmp.Height - 1; j++)
                {
                    (int, int, int) P = (0, 0, 0);

                    // H1
                    P = Sum(P, Mult(fromColor(bmp.GetPixel(i - 1, j - 1)), -1.0));
                    P = Sum(P, Mult(fromColor(bmp.GetPixel(i - 1, j)), -2.0));
                    P = Sum(P, Mult(fromColor(bmp.GetPixel(i - 1, j + 1)), -1.0));

                    P = Sum(P, Mult(fromColor(bmp.GetPixel(i + 1, j - 1)), 1.0));
                    P = Sum(P, Mult(fromColor(bmp.GetPixel(i + 1, j)), 2.0));
                    P = Sum(P, Mult(fromColor(bmp.GetPixel(i + 1, j + 1)), 1.0));
                    // H1


                    // H2
                    (int, int, int) Q = (0, 0, 0);

                    Q = Sum(Q, Mult(fromColor(bmp.GetPixel(i - 1, j - 1)), 1.0));
                    Q = Sum(Q, Mult(fromColor(bmp.GetPixel(i, j - 1)), 2.0));
                    Q = Sum(Q, Mult(fromColor(bmp.GetPixel(i + 1, j - 1)), 1.0));

                    Q = Sum(Q, Mult(fromColor(bmp.GetPixel(i - 1, j + 1)), -1.0));
                    Q = Sum(Q, Mult(fromColor(bmp.GetPixel(i, j + 1)), -2.0));
                    Q = Sum(Q, Mult(fromColor(bmp.GetPixel(i + 1, j + 1)), -1.0));
                    // H2

                    (int, int, int) result = (
                        (int)Math.Sqrt(P.Item1 * P.Item1 + Q.Item1 * Q.Item1),
                        (int)Math.Sqrt(P.Item2 * P.Item2 + Q.Item2 * Q.Item2),
                        (int)Math.Sqrt(P.Item3 * P.Item3 + Q.Item3 * Q.Item3)
                        );
                    bmp2.SetPixel(i, j, toColor(result));
                }
            }
            return bmp2;
        }

        private static Bitmap PrevitBounds(Bitmap bmp)
        {
            Bitmap bmp2 = (Bitmap)bmp.Clone();
            for (int i = 1; i < bmp.Width - 1; i++)
            {
                for (int j = 1; j < bmp.Height - 1; j++)
                {
                    (int, int, int) P = (0, 0, 0);

                    // H1
                    P = Sum(P, Mult(fromColor(bmp.GetPixel(i - 1, j - 1)), 1.0));
                    P = Sum(P, Mult(fromColor(bmp.GetPixel(i - 1, j)), 1.0));
                    P = Sum(P, Mult(fromColor(bmp.GetPixel(i - 1, j + 1)), 1.0));

                    P = Sum(P, Mult(fromColor(bmp.GetPixel(i + 1, j - 1)), -1.0));
                    P = Sum(P, Mult(fromColor(bmp.GetPixel(i + 1, j)), -1.0));
                    P = Sum(P, Mult(fromColor(bmp.GetPixel(i + 1, j + 1)), -1.0));
                    // H1
                    P = (Math.Abs(P.Item1), Math.Abs(P.Item2), Math.Abs(P.Item3));

                    // H2
                    (int, int, int) Q = (0, 0, 0);

                    Q = Sum(Q, Mult(fromColor(bmp.GetPixel(i - 1, j - 1)), -1.0));
                    Q = Sum(Q, Mult(fromColor(bmp.GetPixel(i, j - 1)), -1.0));
                    Q = Sum(Q, Mult(fromColor(bmp.GetPixel(i + 1, j - 1)), -1.0));

                    Q = Sum(Q, Mult(fromColor(bmp.GetPixel(i - 1, j + 1)), 1.0));
                    Q = Sum(Q, Mult(fromColor(bmp.GetPixel(i, j + 1)), 1.0));
                    Q = Sum(Q, Mult(fromColor(bmp.GetPixel(i + 1, j + 1)), 1.0));
                    // H2
                    Q = (Math.Abs(Q.Item1), Math.Abs(Q.Item2), Math.Abs(Q.Item3));

                    (int, int, int) result = (Math.Max(P.Item1, Q.Item1), Math.Max(P.Item2, Q.Item2), Math.Max(P.Item3, Q.Item3));
                    bmp2.SetPixel(i, j, toColor(result));
                }
            }
            return bmp2;
        }

        private static Bitmap KirshBounds(Bitmap bmp)
        {
            Func<int, int, int, (int, int)> toPoint = (int p, int i, int j) =>
            {
                p = p % 8;
                switch(p)
                {
                    case 0:
                        return (i-1, j-1);
                    case 1:
                        return (i, j-1);
                    case 2:
                        return (i+1, j-1);
                    case 3:
                        return (i-1, j);
                    case 4:
                        return (i+1, j);
                    case 5:
                        return (i-1, j + 1);
                    case 6:
                        return (i, j + 1);
                    case 7:
                        return (i + 1, j + 1);
                    default:
                        return (i, j);
                }
            };
            Bitmap bmp2 = (Bitmap)bmp.Clone();
            for (int i = 1; i < bmp.Width - 1; i++)
            {
                for (int j = 1; j < bmp.Height - 1; j++)
                {
                    (int, int, int) Max = (0, 0, 0);

                    for(int k = 0; k < 8; k++)
                    {
                        (int, int, int) P = (0, 0, 0);

                        P = Sum(P, Mult(fromColor(bmp.GetPixel(toPoint(k, i, j).Item1, toPoint(k, i, j).Item2)), 5.0));
                        P = Sum(P, Mult(fromColor(bmp.GetPixel(toPoint(k + 1, i, j).Item1, toPoint(k + 1, i, j).Item2)), 5.0));
                        P = Sum(P, Mult(fromColor(bmp.GetPixel(toPoint(k + 2, i, j).Item1, toPoint(k + 2, i, j).Item2)), 5.0));

                        P = Sum(P, Mult(fromColor(bmp.GetPixel(toPoint(k + 3, i, j).Item1, toPoint(k + 3, i, j).Item2)), -3.0));
                        P = Sum(P, Mult(fromColor(bmp.GetPixel(toPoint(k + 4, i, j).Item1, toPoint(k + 4, i, j).Item2)), -3.0));
                        P = Sum(P, Mult(fromColor(bmp.GetPixel(toPoint(k + 5, i, j).Item1, toPoint(k + 5, i, j).Item2)), -3.0));
                        P = Sum(P, Mult(fromColor(bmp.GetPixel(toPoint(k + 6, i, j).Item1, toPoint(k + 6, i, j).Item2)), -3.0));
                        P = Sum(P, Mult(fromColor(bmp.GetPixel(toPoint(k + 7, i, j).Item1, toPoint(k + 7, i, j).Item2)), -3.0));

                        Max = (Math.Max(Max.Item1, P.Item1), Math.Max(Max.Item2, P.Item2), Math.Max(Max.Item3, P.Item3));
                    }
                    bmp2.SetPixel(i, j, toColor((Max.Item1, Max.Item2, Max.Item3)));
                }
            }
            return bmp2;
        }

        private static Bitmap EmbossingInnerBounds(Bitmap bmp)
        {
            Bitmap bmp2 = (Bitmap)bmp.Clone();
            for (int i = 1; i < bmp.Width - 1; i++)
            {
                for (int j = 1; j < bmp.Height - 1; j++)
                {
                    (int, int, int) result = (0, 0, 0);

                    result = Sum(result, Mult(fromColor(bmp.GetPixel(i, j - 1)), -1.0));
                    result = Sum(result, Mult(fromColor(bmp.GetPixel(i + 1, j)), 1.0));
                    result = Sum(result, Mult(fromColor(bmp.GetPixel(i - 1, j)), -1.0));
                    result = Sum(result, Mult(fromColor(bmp.GetPixel(i, j + 1)), 1.0));

                    int C = 128;

                    result = (result.Item1 + C, result.Item2 + C, result.Item3 + C);
                    bmp2.SetPixel(i, j, toColor(result));
                }
            }
            return bmp2;
        }

        private static Bitmap EmbossingOuterBounds(Bitmap bmp)
        {
            Bitmap bmp2 = (Bitmap)bmp.Clone();
            for (int i = 1; i < bmp.Width - 1; i++)
            {
                for (int j = 1; j < bmp.Height - 1; j++)
                {
                    (int, int, int) result = (0, 0, 0);

                    result = Sum(result, Mult(fromColor(bmp.GetPixel(i, j - 1)), 1.0));
                    result = Sum(result, Mult(fromColor(bmp.GetPixel(i + 1, j)), -1.0));
                    result = Sum(result, Mult(fromColor(bmp.GetPixel(i - 1, j)), 1.0));
                    result = Sum(result, Mult(fromColor(bmp.GetPixel(i, j + 1)), -1.0));

                    int C = 128;

                    result = (result.Item1 + C, result.Item2 + C, result.Item3 + C);
                    bmp2.SetPixel(i, j, toColor(result));
                }
            }
            return bmp2;
        }

        public Bitmap image;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Laplas_Click(object sender, EventArgs e)
        {
            image = LaplasBounds(image);
            this.Close();
        }

        private void ShearDifference_Click(object sender, EventArgs e)
        {
            image = ShearDifferenceBounds(image);
            this.Close();
        }

        private void Roberts_Click(object sender, EventArgs e)
        {
            image = RobertsBounds(image);
            this.Close();
        }

        private void Sobel_Click(object sender, EventArgs e)
        {
            image = SobelBounds(image);
            this.Close();
        }

        private void Previt_Click(object sender, EventArgs e)
        {
            image = PrevitBounds(image);
            this.Close();
        }

        private void Kirsh_Click(object sender, EventArgs e)
        {
            image = KirshBounds(image);
            this.Close();
        }

        private void EmbossingInner_Click(object sender, EventArgs e)
        {
            image = EmbossingInnerBounds(image);
            this.Close();
        }

        private void EmbossingOuter_Click(object sender, EventArgs e)
        {
            image = EmbossingOuterBounds(image);
            this.Close();
        }
    }
}
