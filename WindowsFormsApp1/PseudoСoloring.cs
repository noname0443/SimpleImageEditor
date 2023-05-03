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
    public partial class PseudoСoloring : Form
    {
            
        public PseudoСoloring()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            int colorCount = (int)this.numericUpDown1.Value;

            for (int i = 0; i < colorCount; i++) {
                Button button = new Button();
                TableLayoutPanel tableLayout = new TableLayoutPanel();

                tableLayout.AutoSize = true;
                tableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                tableLayout.ColumnCount = 2;
                tableLayout.RowCount = 1;
                tableLayout.Controls.Add(button, 0, 0);

                if (i + 1 != colorCount)
                {
                    NumericUpDown numericUpDown = new NumericUpDown();
                    numericUpDown.Maximum = 255;
                    numericUpDown.Minimum = 0;
                    tableLayout.Controls.Add(numericUpDown, 1, 0);
                }
                tableLayout.Size = new Size(150, 40);

                ColorDialog colorDialog = new ColorDialog();

                button.Click += (a, b) => {
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        button.BackColor = colorDialog.Color;
                    }
                };
                colorDialog.FullOpen = true;
                this.flowLayoutPanel1.Controls.Add(tableLayout);
            }
        }
    }
}
