
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
            this.zoomBar = new System.Windows.Forms.TrackBar();
            this.layoutForChangeBrightness = new System.Windows.Forms.TableLayoutPanel();
            this.changeBrightnessNumeric = new System.Windows.Forms.NumericUpDown();
            this.layoutForThresholdNegative = new System.Windows.Forms.TableLayoutPanel();
            this.makeThresholdNegative = new System.Windows.Forms.Button();
            this.changeThresholdNegative = new System.Windows.Forms.NumericUpDown();
            this.layoutForThresholding = new System.Windows.Forms.TableLayoutPanel();
            this.makeThresholding = new System.Windows.Forms.Button();
            this.changeThresholding = new System.Windows.Forms.NumericUpDown();
            this.applyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).BeginInit();
            this.layoutForChangeBrightness.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeBrightnessNumeric)).BeginInit();
            this.layoutForThresholdNegative.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeThresholdNegative)).BeginInit();
            this.layoutForThresholding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeThresholding)).BeginInit();
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
            this.makeGrayScale.Location = new System.Drawing.Point(3, 291);
            this.makeGrayScale.Name = "makeGrayScale";
            this.makeGrayScale.Size = new System.Drawing.Size(621, 24);
            this.makeGrayScale.TabIndex = 3;
            this.makeGrayScale.Text = "Make Gray-Scale";
            this.makeGrayScale.UseVisualStyleBackColor = true;
            // 
            // makeBrightnessHistogram
            // 
            this.makeBrightnessHistogram.AutoSize = true;
            this.makeBrightnessHistogram.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.makeBrightnessHistogram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makeBrightnessHistogram.Location = new System.Drawing.Point(3, 191);
            this.makeBrightnessHistogram.Name = "makeBrightnessHistogram";
            this.makeBrightnessHistogram.Size = new System.Drawing.Size(621, 24);
            this.makeBrightnessHistogram.TabIndex = 5;
            this.makeBrightnessHistogram.Text = "Make Brightness-Histogram";
            this.makeBrightnessHistogram.UseVisualStyleBackColor = true;
            this.makeBrightnessHistogram.Click += new System.EventHandler(this.makeBrightnessHistogram_Click);
            // 
            // changeBrightness
            // 
            this.changeBrightness.Location = new System.Drawing.Point(3, 3);
            this.changeBrightness.Name = "changeBrightness";
            this.changeBrightness.Size = new System.Drawing.Size(304, 23);
            this.changeBrightness.TabIndex = 5;
            this.changeBrightness.Text = "Change Brightness";
            this.changeBrightness.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(3, 351);
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
            this.deleteButton.Location = new System.Drawing.Point(3, 126);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(621, 24);
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
            this.tableLayoutPanel1.Controls.Add(this.mainPictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.zoomBar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.deleteButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.layoutForChangeBrightness, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.makeBrightnessHistogram, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.layoutForThresholdNegative, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.layoutForThresholding, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.makeGrayScale, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.applyButton, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(627, 411);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // zoomBar
            // 
            this.zoomBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zoomBar.Location = new System.Drawing.Point(3, 96);
            this.zoomBar.Maximum = 1200;
            this.zoomBar.Minimum = 1;
            this.zoomBar.Name = "zoomBar";
            this.zoomBar.Size = new System.Drawing.Size(621, 24);
            this.zoomBar.TabIndex = 6;
            this.zoomBar.Value = 1;
            this.zoomBar.Scroll += new System.EventHandler(this.zoomBar_Scroll);
            // 
            // layoutForChangeBrightness
            // 
            this.layoutForChangeBrightness.AutoSize = true;
            this.layoutForChangeBrightness.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layoutForChangeBrightness.ColumnCount = 2;
            this.layoutForChangeBrightness.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutForChangeBrightness.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutForChangeBrightness.Controls.Add(this.changeBrightness, 0, 0);
            this.layoutForChangeBrightness.Controls.Add(this.changeBrightnessNumeric, 1, 0);
            this.layoutForChangeBrightness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutForChangeBrightness.Location = new System.Drawing.Point(3, 156);
            this.layoutForChangeBrightness.Name = "layoutForChangeBrightness";
            this.layoutForChangeBrightness.RowCount = 1;
            this.layoutForChangeBrightness.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.layoutForChangeBrightness.Size = new System.Drawing.Size(621, 29);
            this.layoutForChangeBrightness.TabIndex = 2;
            // 
            // changeBrightnessNumeric
            // 
            this.changeBrightnessNumeric.Location = new System.Drawing.Point(313, 3);
            this.changeBrightnessNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.changeBrightnessNumeric.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.changeBrightnessNumeric.Name = "changeBrightnessNumeric";
            this.changeBrightnessNumeric.Size = new System.Drawing.Size(305, 20);
            this.changeBrightnessNumeric.TabIndex = 6;
            // 
            // layoutForThresholdNegative
            // 
            this.layoutForThresholdNegative.AutoSize = true;
            this.layoutForThresholdNegative.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layoutForThresholdNegative.ColumnCount = 2;
            this.layoutForThresholdNegative.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutForThresholdNegative.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutForThresholdNegative.Controls.Add(this.makeThresholdNegative, 0, 0);
            this.layoutForThresholdNegative.Controls.Add(this.changeThresholdNegative, 1, 0);
            this.layoutForThresholdNegative.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutForThresholdNegative.Location = new System.Drawing.Point(3, 221);
            this.layoutForThresholdNegative.Name = "layoutForThresholdNegative";
            this.layoutForThresholdNegative.RowCount = 1;
            this.layoutForThresholdNegative.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.layoutForThresholdNegative.Size = new System.Drawing.Size(621, 29);
            this.layoutForThresholdNegative.TabIndex = 2;
            // 
            // makeThresholdNegative
            // 
            this.makeThresholdNegative.Location = new System.Drawing.Point(3, 3);
            this.makeThresholdNegative.Name = "makeThresholdNegative";
            this.makeThresholdNegative.Size = new System.Drawing.Size(304, 23);
            this.makeThresholdNegative.TabIndex = 5;
            this.makeThresholdNegative.Text = "Change Threshold Negative";
            this.makeThresholdNegative.UseVisualStyleBackColor = true;
            // 
            // changeThresholdNegative
            // 
            this.changeThresholdNegative.Location = new System.Drawing.Point(313, 3);
            this.changeThresholdNegative.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.changeThresholdNegative.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.changeThresholdNegative.Name = "changeThresholdNegative";
            this.changeThresholdNegative.Size = new System.Drawing.Size(305, 20);
            this.changeThresholdNegative.TabIndex = 6;
            // 
            // layoutForThresholding
            // 
            this.layoutForThresholding.AutoSize = true;
            this.layoutForThresholding.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layoutForThresholding.ColumnCount = 2;
            this.layoutForThresholding.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutForThresholding.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutForThresholding.Controls.Add(this.makeThresholding, 0, 0);
            this.layoutForThresholding.Controls.Add(this.changeThresholding, 1, 0);
            this.layoutForThresholding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutForThresholding.Location = new System.Drawing.Point(3, 256);
            this.layoutForThresholding.Name = "layoutForThresholding";
            this.layoutForThresholding.RowCount = 1;
            this.layoutForThresholding.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.layoutForThresholding.Size = new System.Drawing.Size(621, 29);
            this.layoutForThresholding.TabIndex = 2;
            // 
            // makeThresholding
            // 
            this.makeThresholding.Location = new System.Drawing.Point(3, 3);
            this.makeThresholding.Name = "makeThresholding";
            this.makeThresholding.Size = new System.Drawing.Size(304, 23);
            this.makeThresholding.TabIndex = 5;
            this.makeThresholding.Text = "Change Thresholding";
            this.makeThresholding.UseVisualStyleBackColor = true;
            // 
            // changeThresholding
            // 
            this.changeThresholding.Location = new System.Drawing.Point(313, 3);
            this.changeThresholding.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.changeThresholding.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.changeThresholding.Name = "changeThresholding";
            this.changeThresholding.Size = new System.Drawing.Size(305, 20);
            this.changeThresholding.TabIndex = 6;
            // 
            // applyButton
            // 
            this.applyButton.AutoSize = true;
            this.applyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.applyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applyButton.Location = new System.Drawing.Point(3, 321);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(621, 24);
            this.applyButton.TabIndex = 5;
            this.applyButton.Text = "Apply Changes";
            this.applyButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(627, 411);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.Text = "Image Editor";
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).EndInit();
            this.layoutForChangeBrightness.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.changeBrightnessNumeric)).EndInit();
            this.layoutForThresholdNegative.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.changeThresholdNegative)).EndInit();
            this.layoutForThresholding.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.changeThresholding)).EndInit();
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
        public System.Windows.Forms.NumericUpDown changeBrightnessNumeric;

        private System.Windows.Forms.TableLayoutPanel layoutForThresholdNegative;
        public System.Windows.Forms.Button makeThresholdNegative;
        public System.Windows.Forms.NumericUpDown changeThresholdNegative;

        private System.Windows.Forms.TableLayoutPanel layoutForThresholding;
        public System.Windows.Forms.Button makeThresholding;
        public System.Windows.Forms.NumericUpDown changeThresholding;
    }
}