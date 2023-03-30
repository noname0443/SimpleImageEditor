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
