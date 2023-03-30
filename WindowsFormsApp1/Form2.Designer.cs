
namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.makeGrayScale = new System.Windows.Forms.Button();
            this.makeBrightnessHistogram = new System.Windows.Forms.Button();
            this.changeBrightness = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.layoutForChangeBrightness = new System.Windows.Forms.TableLayoutPanel();
            this.applyButton = new System.Windows.Forms.Button();
            this.zoomBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.layoutForChangeBrightness.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPictureBox.Location = new System.Drawing.Point(3, 3);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(621, 87);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainPictureBox.TabIndex = 4;
            this.mainPictureBox.TabStop = false;
            // 
            // makeGrayScale
            // 
            this.makeGrayScale.AutoSize = true;
            this.makeGrayScale.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.makeGrayScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makeGrayScale.Location = new System.Drawing.Point(3, 176);
            this.makeGrayScale.Name = "makeGrayScale";
            this.makeGrayScale.Size = new System.Drawing.Size(621, 23);
            this.makeGrayScale.TabIndex = 3;
            this.makeGrayScale.Text = "Make Gray-Scale";
            this.makeGrayScale.UseVisualStyleBackColor = true;
            // 
            // makeBrightnessHistogram
            // 
            this.makeBrightnessHistogram.AutoSize = true;
            this.makeBrightnessHistogram.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.makeBrightnessHistogram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makeBrightnessHistogram.Location = new System.Drawing.Point(3, 176);
            this.makeBrightnessHistogram.Name = "makeBrightnessHistogram";
            this.makeBrightnessHistogram.Size = new System.Drawing.Size(394, 23);
            this.makeBrightnessHistogram.TabIndex = 5;
            this.makeBrightnessHistogram.Text = "Make Brightness-Histogram";
            this.makeBrightnessHistogram.UseVisualStyleBackColor = true;
            this.makeBrightnessHistogram.Click += new System.EventHandler(this.makeBrightnessHistogram_Click);
            // 
            // changeBrightness
            // 
            this.changeBrightness.AutoSize = true;
            this.changeBrightness.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.changeBrightness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeBrightness.Location = new System.Drawing.Point(3, 3);
            this.changeBrightness.Name = "changeBrightness";
            this.changeBrightness.Size = new System.Drawing.Size(595, 14);
            this.changeBrightness.TabIndex = 5;
            this.changeBrightness.Text = "Change Brightness";
            this.changeBrightness.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(3, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(621, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close Window";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = true;
            this.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.Location = new System.Drawing.Point(3, 147);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(621, 23);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.Text = "Delete image";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.deleteButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.layoutForChangeBrightness, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.makeGrayScale, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.mainPictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.applyButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.zoomBar, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(627, 364);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // layoutForChangeBrightness
            // 
            this.layoutForChangeBrightness.AutoSize = true;
            this.layoutForChangeBrightness.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layoutForChangeBrightness.ColumnCount = 2;
            this.layoutForChangeBrightness.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutForChangeBrightness.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutForChangeBrightness.Controls.Add(this.changeBrightness, 0, 0);
            this.layoutForChangeBrightness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutForChangeBrightness.Location = new System.Drawing.Point(3, 205);
            this.layoutForChangeBrightness.Name = "layoutForChangeBrightness";
            this.layoutForChangeBrightness.RowCount = 1;
            this.layoutForChangeBrightness.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutForChangeBrightness.Size = new System.Drawing.Size(621, 525);
            this.layoutForChangeBrightness.TabIndex = 2;
            // 
            // applyButton
            // 
            this.applyButton.AutoSize = true;
            this.applyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.applyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applyButton.Location = new System.Drawing.Point(3, 231);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(621, 23);
            this.applyButton.TabIndex = 5;
            this.applyButton.Text = "Apply Changes";
            this.applyButton.UseVisualStyleBackColor = true;
            // 
            // zoomBar
            // 
            this.zoomBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zoomBar.Location = new System.Drawing.Point(3, 96);
            this.zoomBar.Maximum = 1200;
            this.zoomBar.Minimum = 1;
            this.zoomBar.Name = "zoomBar";
            this.zoomBar.Size = new System.Drawing.Size(621, 45);
            this.zoomBar.TabIndex = 6;
            this.zoomBar.Value = 1;
            this.zoomBar.Scroll += new System.EventHandler(this.zoomBar_Scroll);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(627, 364);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.Text = "Image Editor";
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.layoutForChangeBrightness.ResumeLayout(false);
            this.layoutForChangeBrightness.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox mainPictureBox;
        public System.Windows.Forms.Button makeGrayScale;
        public System.Windows.Forms.Button changeBrightness;
        public System.Windows.Forms.Button makeBrightnessHistogram;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TableLayoutPanel layoutForChangeBrightness;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Button applyButton;
        public System.Windows.Forms.TrackBar zoomBar;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}