﻿
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
            this.makeGrayScale = new System.Windows.Forms.Button();
            this.makeBrightnessHistogram = new System.Windows.Forms.Button();
            this.changeBrightness = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.layoutForChangeBrightness = new System.Windows.Forms.TableLayoutPanel();
            this.changeBrightnessNumeric = new System.Windows.Forms.NumericUpDown();
            this.layoutForThresholdNegative = new System.Windows.Forms.TableLayoutPanel();
            this.makeThresholdNegative = new System.Windows.Forms.Button();
            this.changeThresholdNegative = new System.Windows.Forms.NumericUpDown();
            this.layoutForThresholding = new System.Windows.Forms.TableLayoutPanel();
            this.makeThresholding = new System.Windows.Forms.Button();
            this.changeThresholding = new System.Windows.Forms.NumericUpDown();
            this.layoutForUpContrast = new System.Windows.Forms.TableLayoutPanel();
            this.upChangeContrastQ1 = new System.Windows.Forms.NumericUpDown();
            this.upChangeContrastQ2 = new System.Windows.Forms.NumericUpDown();
            this.makeUpContrast = new System.Windows.Forms.Button();
            this.layoutForDownContrast = new System.Windows.Forms.TableLayoutPanel();
            this.downChangeContrastQ1 = new System.Windows.Forms.NumericUpDown();
            this.downChangeContrastQ2 = new System.Windows.Forms.NumericUpDown();
            this.makeDownContrast = new System.Windows.Forms.Button();
            this.layoutForGammaConversion = new System.Windows.Forms.TableLayoutPanel();
            this.makeGammaConversion = new System.Windows.Forms.Button();
            this.changeGammaConversion = new System.Windows.Forms.TextBox();
            this.layoutForQuantization = new System.Windows.Forms.TableLayoutPanel();
            this.makeQuantization = new System.Windows.Forms.Button();
            this.changeQuantization = new System.Windows.Forms.NumericUpDown();
            this.makePseudoColor = new System.Windows.Forms.Button();
            this.makeSolarization = new System.Windows.Forms.Button();
            this.makeSmooth = new System.Windows.Forms.Button();
            this.makeSharp = new System.Windows.Forms.Button();
            this.useMedianFilter = new System.Windows.Forms.Button();
            this.useStochasticAlignment = new System.Windows.Forms.Button();
            this.makeStrengtheningBoundaries = new System.Windows.Forms.Button();
            this.layoutRotation = new System.Windows.Forms.TableLayoutPanel();
            this.makeRotateButton = new System.Windows.Forms.Button();
            this.changeRotateAngle = new System.Windows.Forms.NumericUpDown();
            this.applyButton = new System.Windows.Forms.Button();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.layoutForChangeBrightness.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeBrightnessNumeric)).BeginInit();
            this.layoutForThresholdNegative.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeThresholdNegative)).BeginInit();
            this.layoutForThresholding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeThresholding)).BeginInit();
            this.layoutForUpContrast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upChangeContrastQ1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upChangeContrastQ2)).BeginInit();
            this.layoutForDownContrast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.downChangeContrastQ1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downChangeContrastQ2)).BeginInit();
            this.layoutForGammaConversion.SuspendLayout();
            this.layoutForQuantization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeQuantization)).BeginInit();
            this.layoutRotation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeRotateAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // makeGrayScale
            // 
            this.makeGrayScale.AutoSize = true;
            this.makeGrayScale.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.makeGrayScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makeGrayScale.Location = new System.Drawing.Point(3, 516);
            this.makeGrayScale.Name = "makeGrayScale";
            this.makeGrayScale.Size = new System.Drawing.Size(1120, 29);
            this.makeGrayScale.TabIndex = 3;
            this.makeGrayScale.Text = "Make Gray-Scale";
            this.makeGrayScale.UseVisualStyleBackColor = true;
            // 
            // makeBrightnessHistogram
            // 
            this.makeBrightnessHistogram.AutoSize = true;
            this.makeBrightnessHistogram.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.makeBrightnessHistogram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makeBrightnessHistogram.Location = new System.Drawing.Point(3, 201);
            this.makeBrightnessHistogram.Name = "makeBrightnessHistogram";
            this.makeBrightnessHistogram.Size = new System.Drawing.Size(1120, 29);
            this.makeBrightnessHistogram.TabIndex = 5;
            this.makeBrightnessHistogram.Text = "Make Brightness-Histogram";
            this.makeBrightnessHistogram.UseVisualStyleBackColor = true;
            this.makeBrightnessHistogram.Click += new System.EventHandler(this.makeBrightnessHistogram_Click);
            // 
            // changeBrightness
            // 
            this.changeBrightness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeBrightness.Location = new System.Drawing.Point(3, 3);
            this.changeBrightness.Name = "changeBrightness";
            this.changeBrightness.Size = new System.Drawing.Size(554, 23);
            this.changeBrightness.TabIndex = 5;
            this.changeBrightness.Text = "Change Brightness";
            this.changeBrightness.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(3, 796);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1120, 29);
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
            this.deleteButton.Location = new System.Drawing.Point(3, 131);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(1120, 29);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.Text = "Delete image";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.mainPictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.deleteButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.layoutForChangeBrightness, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.makeBrightnessHistogram, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.layoutForThresholdNegative, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.layoutForThresholding, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.layoutForUpContrast, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.layoutForDownContrast, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.layoutForGammaConversion, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.layoutForQuantization, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.makePseudoColor, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.makeSolarization, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.makeGrayScale, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.makeSmooth, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.makeSharp, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.useMedianFilter, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.useStochasticAlignment, 0, 16);
            this.tableLayoutPanel1.Controls.Add(this.makeStrengtheningBoundaries, 0, 17);
            this.tableLayoutPanel1.Controls.Add(this.layoutRotation, 0, 18);
            this.tableLayoutPanel1.Controls.Add(this.applyButton, 0, 19);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 20);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1125, 883);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.layoutForChangeBrightness.Location = new System.Drawing.Point(3, 166);
            this.layoutForChangeBrightness.Name = "layoutForChangeBrightness";
            this.layoutForChangeBrightness.RowCount = 1;
            this.layoutForChangeBrightness.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.layoutForChangeBrightness.Size = new System.Drawing.Size(1120, 29);
            this.layoutForChangeBrightness.TabIndex = 2;
            // 
            // changeBrightnessNumeric
            // 
            this.changeBrightnessNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeBrightnessNumeric.Location = new System.Drawing.Point(563, 3);
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
            this.changeBrightnessNumeric.Size = new System.Drawing.Size(554, 20);
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
            this.layoutForThresholdNegative.Location = new System.Drawing.Point(3, 236);
            this.layoutForThresholdNegative.Name = "layoutForThresholdNegative";
            this.layoutForThresholdNegative.RowCount = 1;
            this.layoutForThresholdNegative.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.layoutForThresholdNegative.Size = new System.Drawing.Size(1120, 29);
            this.layoutForThresholdNegative.TabIndex = 2;
            // 
            // makeThresholdNegative
            // 
            this.makeThresholdNegative.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makeThresholdNegative.Location = new System.Drawing.Point(3, 3);
            this.makeThresholdNegative.Name = "makeThresholdNegative";
            this.makeThresholdNegative.Size = new System.Drawing.Size(554, 23);
            this.makeThresholdNegative.TabIndex = 5;
            this.makeThresholdNegative.Text = "Change Threshold Negative";
            this.makeThresholdNegative.UseVisualStyleBackColor = true;
            // 
            // changeThresholdNegative
            // 
            this.changeThresholdNegative.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeThresholdNegative.Location = new System.Drawing.Point(563, 3);
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
            this.changeThresholdNegative.Size = new System.Drawing.Size(554, 20);
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
            this.layoutForThresholding.Location = new System.Drawing.Point(3, 271);
            this.layoutForThresholding.Name = "layoutForThresholding";
            this.layoutForThresholding.RowCount = 1;
            this.layoutForThresholding.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.layoutForThresholding.Size = new System.Drawing.Size(1120, 29);
            this.layoutForThresholding.TabIndex = 2;
            // 
            // makeThresholding
            // 
            this.makeThresholding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makeThresholding.Location = new System.Drawing.Point(3, 3);
            this.makeThresholding.Name = "makeThresholding";
            this.makeThresholding.Size = new System.Drawing.Size(554, 23);
            this.makeThresholding.TabIndex = 5;
            this.makeThresholding.Text = "Change Thresholding";
            this.makeThresholding.UseVisualStyleBackColor = true;
            // 
            // changeThresholding
            // 
            this.changeThresholding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeThresholding.Location = new System.Drawing.Point(563, 3);
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
            this.changeThresholding.Size = new System.Drawing.Size(554, 20);
            this.changeThresholding.TabIndex = 6;
            // 
            // layoutForUpContrast
            // 
            this.layoutForUpContrast.AutoSize = true;
            this.layoutForUpContrast.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layoutForUpContrast.ColumnCount = 3;
            this.layoutForUpContrast.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.layoutForUpContrast.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutForUpContrast.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutForUpContrast.Controls.Add(this.upChangeContrastQ1, 1, 0);
            this.layoutForUpContrast.Controls.Add(this.upChangeContrastQ2, 2, 0);
            this.layoutForUpContrast.Controls.Add(this.makeUpContrast, 0, 0);
            this.layoutForUpContrast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutForUpContrast.Location = new System.Drawing.Point(3, 306);
            this.layoutForUpContrast.Name = "layoutForUpContrast";
            this.layoutForUpContrast.RowCount = 1;
            this.layoutForUpContrast.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.layoutForUpContrast.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.layoutForUpContrast.Size = new System.Drawing.Size(1120, 29);
            this.layoutForUpContrast.TabIndex = 2;
            // 
            // upChangeContrastQ1
            // 
            this.upChangeContrastQ1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upChangeContrastQ1.Location = new System.Drawing.Point(153, 3);
            this.upChangeContrastQ1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.upChangeContrastQ1.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.upChangeContrastQ1.Name = "upChangeContrastQ1";
            this.upChangeContrastQ1.Size = new System.Drawing.Size(479, 20);
            this.upChangeContrastQ1.TabIndex = 7;
            // 
            // upChangeContrastQ2
            // 
            this.upChangeContrastQ2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upChangeContrastQ2.Location = new System.Drawing.Point(638, 3);
            this.upChangeContrastQ2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.upChangeContrastQ2.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.upChangeContrastQ2.Name = "upChangeContrastQ2";
            this.upChangeContrastQ2.Size = new System.Drawing.Size(479, 20);
            this.upChangeContrastQ2.TabIndex = 8;
            // 
            // makeUpContrast
            // 
            this.makeUpContrast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makeUpContrast.Location = new System.Drawing.Point(3, 3);
            this.makeUpContrast.Name = "makeUpContrast";
            this.makeUpContrast.Size = new System.Drawing.Size(144, 23);
            this.makeUpContrast.TabIndex = 5;
            this.makeUpContrast.Text = "Increase the Contrast";
            this.makeUpContrast.UseVisualStyleBackColor = true;
            // 
            // layoutForDownContrast
            // 
            this.layoutForDownContrast.AutoSize = true;
            this.layoutForDownContrast.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layoutForDownContrast.ColumnCount = 3;
            this.layoutForDownContrast.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.layoutForDownContrast.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutForDownContrast.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutForDownContrast.Controls.Add(this.downChangeContrastQ1, 1, 0);
            this.layoutForDownContrast.Controls.Add(this.downChangeContrastQ2, 2, 0);
            this.layoutForDownContrast.Controls.Add(this.makeDownContrast, 0, 0);
            this.layoutForDownContrast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutForDownContrast.Location = new System.Drawing.Point(3, 341);
            this.layoutForDownContrast.Name = "layoutForDownContrast";
            this.layoutForDownContrast.RowCount = 1;
            this.layoutForDownContrast.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.layoutForDownContrast.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.layoutForDownContrast.Size = new System.Drawing.Size(1120, 29);
            this.layoutForDownContrast.TabIndex = 2;
            // 
            // downChangeContrastQ1
            // 
            this.downChangeContrastQ1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downChangeContrastQ1.Location = new System.Drawing.Point(153, 3);
            this.downChangeContrastQ1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.downChangeContrastQ1.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.downChangeContrastQ1.Name = "downChangeContrastQ1";
            this.downChangeContrastQ1.Size = new System.Drawing.Size(479, 20);
            this.downChangeContrastQ1.TabIndex = 7;
            // 
            // downChangeContrastQ2
            // 
            this.downChangeContrastQ2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downChangeContrastQ2.Location = new System.Drawing.Point(638, 3);
            this.downChangeContrastQ2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.downChangeContrastQ2.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.downChangeContrastQ2.Name = "downChangeContrastQ2";
            this.downChangeContrastQ2.Size = new System.Drawing.Size(479, 20);
            this.downChangeContrastQ2.TabIndex = 8;
            // 
            // makeDownContrast
            // 
            this.makeDownContrast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makeDownContrast.Location = new System.Drawing.Point(3, 3);
            this.makeDownContrast.Name = "makeDownContrast";
            this.makeDownContrast.Size = new System.Drawing.Size(144, 23);
            this.makeDownContrast.TabIndex = 5;
            this.makeDownContrast.Text = "Decrease the Contrast";
            this.makeDownContrast.UseVisualStyleBackColor = true;
            // 
            // layoutForGammaConversion
            // 
            this.layoutForGammaConversion.AutoSize = true;
            this.layoutForGammaConversion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layoutForGammaConversion.ColumnCount = 2;
            this.layoutForGammaConversion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutForGammaConversion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutForGammaConversion.Controls.Add(this.makeGammaConversion, 0, 0);
            this.layoutForGammaConversion.Controls.Add(this.changeGammaConversion, 1, 0);
            this.layoutForGammaConversion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutForGammaConversion.Location = new System.Drawing.Point(3, 376);
            this.layoutForGammaConversion.Name = "layoutForGammaConversion";
            this.layoutForGammaConversion.RowCount = 1;
            this.layoutForGammaConversion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.layoutForGammaConversion.Size = new System.Drawing.Size(1120, 29);
            this.layoutForGammaConversion.TabIndex = 2;
            // 
            // makeGammaConversion
            // 
            this.makeGammaConversion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makeGammaConversion.Location = new System.Drawing.Point(3, 3);
            this.makeGammaConversion.Name = "makeGammaConversion";
            this.makeGammaConversion.Size = new System.Drawing.Size(554, 23);
            this.makeGammaConversion.TabIndex = 0;
            this.makeGammaConversion.Text = "Increase gamma conversion";
            this.makeGammaConversion.UseVisualStyleBackColor = true;
            // 
            // changeGammaConversion
            // 
            this.changeGammaConversion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeGammaConversion.Location = new System.Drawing.Point(563, 3);
            this.changeGammaConversion.Name = "changeGammaConversion";
            this.changeGammaConversion.Size = new System.Drawing.Size(554, 20);
            this.changeGammaConversion.TabIndex = 0;
            // 
            // layoutForQuantization
            // 
            this.layoutForQuantization.AutoSize = true;
            this.layoutForQuantization.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layoutForQuantization.ColumnCount = 2;
            this.layoutForQuantization.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutForQuantization.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutForQuantization.Controls.Add(this.makeQuantization, 0, 0);
            this.layoutForQuantization.Controls.Add(this.changeQuantization, 1, 0);
            this.layoutForQuantization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutForQuantization.Location = new System.Drawing.Point(3, 411);
            this.layoutForQuantization.Name = "layoutForQuantization";
            this.layoutForQuantization.RowCount = 1;
            this.layoutForQuantization.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.layoutForQuantization.Size = new System.Drawing.Size(1120, 29);
            this.layoutForQuantization.TabIndex = 2;
            // 
            // makeQuantization
            // 
            this.makeQuantization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makeQuantization.Location = new System.Drawing.Point(3, 3);
            this.makeQuantization.Name = "makeQuantization";
            this.makeQuantization.Size = new System.Drawing.Size(554, 23);
            this.makeQuantization.TabIndex = 5;
            this.makeQuantization.Text = "Make Quantization";
            this.makeQuantization.UseVisualStyleBackColor = true;
            this.makeQuantization.Click += new System.EventHandler(this.makeQuantization_Click);
            // 
            // changeQuantization
            // 
            this.changeQuantization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeQuantization.Location = new System.Drawing.Point(563, 3);
            this.changeQuantization.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.changeQuantization.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.changeQuantization.Name = "changeQuantization";
            this.changeQuantization.Size = new System.Drawing.Size(554, 20);
            this.changeQuantization.TabIndex = 6;
            this.changeQuantization.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // makePseudoColor
            // 
            this.makePseudoColor.AutoSize = true;
            this.makePseudoColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.makePseudoColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makePseudoColor.Location = new System.Drawing.Point(3, 446);
            this.makePseudoColor.Name = "makePseudoColor";
            this.makePseudoColor.Size = new System.Drawing.Size(1120, 29);
            this.makePseudoColor.TabIndex = 3;
            this.makePseudoColor.Text = "Make Pseudo Color";
            this.makePseudoColor.UseVisualStyleBackColor = true;
            this.makePseudoColor.Click += new System.EventHandler(this.makePseudoColor_Click);
            // 
            // makeSolarization
            // 
            this.makeSolarization.AutoSize = true;
            this.makeSolarization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makeSolarization.Location = new System.Drawing.Point(3, 481);
            this.makeSolarization.Name = "makeSolarization";
            this.makeSolarization.Size = new System.Drawing.Size(1120, 29);
            this.makeSolarization.TabIndex = 5;
            this.makeSolarization.Text = "Make Solarization";
            this.makeSolarization.UseVisualStyleBackColor = true;
            this.makeSolarization.Click += new System.EventHandler(this.makeSolarization_Click);
            // 
            // makeSmooth
            // 
            this.makeSmooth.AutoSize = true;
            this.makeSmooth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makeSmooth.Location = new System.Drawing.Point(3, 551);
            this.makeSmooth.Name = "makeSmooth";
            this.makeSmooth.Size = new System.Drawing.Size(1120, 29);
            this.makeSmooth.TabIndex = 5;
            this.makeSmooth.Text = "Make smooth";
            this.makeSmooth.UseVisualStyleBackColor = true;
            this.makeSmooth.Click += new System.EventHandler(this.makeSmooth_Click);
            // 
            // makeSharp
            // 
            this.makeSharp.AutoSize = true;
            this.makeSharp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makeSharp.Location = new System.Drawing.Point(3, 586);
            this.makeSharp.Name = "makeSharp";
            this.makeSharp.Size = new System.Drawing.Size(1120, 29);
            this.makeSharp.TabIndex = 5;
            this.makeSharp.Text = "Make sharp";
            this.makeSharp.UseVisualStyleBackColor = true;
            this.makeSharp.Click += new System.EventHandler(this.makeSharp_Click);
            // 
            // useMedianFilter
            // 
            this.useMedianFilter.AutoSize = true;
            this.useMedianFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.useMedianFilter.Location = new System.Drawing.Point(3, 621);
            this.useMedianFilter.Name = "useMedianFilter";
            this.useMedianFilter.Size = new System.Drawing.Size(1120, 29);
            this.useMedianFilter.TabIndex = 5;
            this.useMedianFilter.Text = "Use median filter";
            this.useMedianFilter.UseVisualStyleBackColor = true;
            this.useMedianFilter.Click += new System.EventHandler(this.useMedianFilter_Click);
            // 
            // useStochasticAlignment
            // 
            this.useStochasticAlignment.AutoSize = true;
            this.useStochasticAlignment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.useStochasticAlignment.Location = new System.Drawing.Point(3, 656);
            this.useStochasticAlignment.Name = "useStochasticAlignment";
            this.useStochasticAlignment.Size = new System.Drawing.Size(1120, 29);
            this.useStochasticAlignment.TabIndex = 5;
            this.useStochasticAlignment.Text = "Use stochastic alignment";
            this.useStochasticAlignment.UseVisualStyleBackColor = true;
            this.useStochasticAlignment.Click += new System.EventHandler(this.useStochasticAlignment_Click);
            // 
            // makeStrengtheningBoundaries
            // 
            this.makeStrengtheningBoundaries.AutoSize = true;
            this.makeStrengtheningBoundaries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makeStrengtheningBoundaries.Location = new System.Drawing.Point(3, 691);
            this.makeStrengtheningBoundaries.Name = "makeStrengtheningBoundaries";
            this.makeStrengtheningBoundaries.Size = new System.Drawing.Size(1120, 29);
            this.makeStrengtheningBoundaries.TabIndex = 5;
            this.makeStrengtheningBoundaries.Text = "Make Strengthening Boundaries";
            this.makeStrengtheningBoundaries.UseVisualStyleBackColor = true;
            this.makeStrengtheningBoundaries.Click += new System.EventHandler(this.makeStrengtheningBoundaries_Click);
            // 
            // layoutRotation
            // 
            this.layoutRotation.AutoSize = true;
            this.layoutRotation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layoutRotation.ColumnCount = 2;
            this.layoutRotation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutRotation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutRotation.Controls.Add(this.makeRotateButton, 0, 0);
            this.layoutRotation.Controls.Add(this.changeRotateAngle, 1, 0);
            this.layoutRotation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutRotation.Location = new System.Drawing.Point(3, 726);
            this.layoutRotation.Name = "layoutRotation";
            this.layoutRotation.RowCount = 1;
            this.layoutRotation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.layoutRotation.Size = new System.Drawing.Size(1120, 29);
            this.layoutRotation.TabIndex = 2;
            // 
            // makeRotateButton
            // 
            this.makeRotateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makeRotateButton.Location = new System.Drawing.Point(3, 3);
            this.makeRotateButton.Name = "makeRotateButton";
            this.makeRotateButton.Size = new System.Drawing.Size(554, 23);
            this.makeRotateButton.TabIndex = 5;
            this.makeRotateButton.Text = "Do rotate";
            this.makeRotateButton.UseVisualStyleBackColor = true;
            this.makeRotateButton.Click += new System.EventHandler(this.makeRotateButton_Click);
            // 
            // changeRotateAngle
            // 
            this.changeRotateAngle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeRotateAngle.Location = new System.Drawing.Point(563, 3);
            this.changeRotateAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.changeRotateAngle.Name = "changeRotateAngle";
            this.changeRotateAngle.Size = new System.Drawing.Size(554, 20);
            this.changeRotateAngle.TabIndex = 6;
            // 
            // applyButton
            // 
            this.applyButton.AutoSize = true;
            this.applyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.applyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applyButton.Location = new System.Drawing.Point(3, 761);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(1120, 29);
            this.applyButton.TabIndex = 5;
            this.applyButton.Text = "Apply Changes";
            this.applyButton.UseVisualStyleBackColor = true;
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainPictureBox.Location = new System.Drawing.Point(252, 3);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(621, 87);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mainPictureBox.TabIndex = 4;
            this.mainPictureBox.TabStop = false;
            this.mainPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPictureBox_Paint);
            this.mainPictureBox.LostFocus += new System.EventHandler(this.mainPictureBox_LostFocus);
            this.mainPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPictureBox_MouseDown);
            this.mainPictureBox.MouseLeave += new System.EventHandler(this.mainPictureBox_MouseLeave);
            this.mainPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPictureBox_MouseMove);
            this.mainPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPictureBox_MouseUp);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1125, 883);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Form2";
            this.Text = "Image Editor";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.layoutForChangeBrightness.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.changeBrightnessNumeric)).EndInit();
            this.layoutForThresholdNegative.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.changeThresholdNegative)).EndInit();
            this.layoutForThresholding.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.changeThresholding)).EndInit();
            this.layoutForUpContrast.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.upChangeContrastQ1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upChangeContrastQ2)).EndInit();
            this.layoutForDownContrast.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.downChangeContrastQ1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downChangeContrastQ2)).EndInit();
            this.layoutForGammaConversion.ResumeLayout(false);
            this.layoutForGammaConversion.PerformLayout();
            this.layoutForQuantization.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.changeQuantization)).EndInit();
            this.layoutRotation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.changeRotateAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button makeGrayScale;
        public System.Windows.Forms.Button changeBrightness;
        public System.Windows.Forms.Button makeBrightnessHistogram;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TableLayoutPanel layoutForChangeBrightness;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Button applyButton;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart;
        public System.Windows.Forms.NumericUpDown changeBrightnessNumeric;

        private System.Windows.Forms.TableLayoutPanel layoutForThresholdNegative;
        public System.Windows.Forms.Button makeThresholdNegative;
        public System.Windows.Forms.NumericUpDown changeThresholdNegative;

        private System.Windows.Forms.TableLayoutPanel layoutForThresholding;
        public System.Windows.Forms.Button makeThresholding;
        public System.Windows.Forms.NumericUpDown changeThresholding;

        private System.Windows.Forms.TableLayoutPanel layoutForUpContrast;
        public System.Windows.Forms.Button makeUpContrast;
        public System.Windows.Forms.NumericUpDown upChangeContrastQ1;
        public System.Windows.Forms.NumericUpDown upChangeContrastQ2;

        private System.Windows.Forms.TableLayoutPanel layoutForDownContrast;
        public System.Windows.Forms.Button makeDownContrast;
        public System.Windows.Forms.NumericUpDown downChangeContrastQ1;
        public System.Windows.Forms.NumericUpDown downChangeContrastQ2;

        private System.Windows.Forms.TableLayoutPanel layoutForGammaConversion;
        public System.Windows.Forms.Button makeGammaConversion;
        public System.Windows.Forms.TextBox changeGammaConversion;

        public System.Windows.Forms.Button makePseudoColor;

        private System.Windows.Forms.TableLayoutPanel layoutForQuantization;
        public System.Windows.Forms.Button makeQuantization;
        public System.Windows.Forms.NumericUpDown changeQuantization;

        public System.Windows.Forms.Button makeSmooth;

        public System.Windows.Forms.Button makeSharp;

        public System.Windows.Forms.Button useMedianFilter;

        public System.Windows.Forms.Button useStochasticAlignment;

        public System.Windows.Forms.Button makeStrengtheningBoundaries;

        public System.Windows.Forms.Button makeSolarization;

        public System.Windows.Forms.Button makeRotateButton;
        public System.Windows.Forms.NumericUpDown changeRotateAngle;
        private System.Windows.Forms.TableLayoutPanel layoutRotation;
        public System.Windows.Forms.PictureBox mainPictureBox;
    }
}