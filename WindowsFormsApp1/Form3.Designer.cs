
namespace WindowsFormsApp1
{
    partial class Form3
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Laplas = new System.Windows.Forms.Button();
            this.ShearDifference = new System.Windows.Forms.Button();
            this.Roberts = new System.Windows.Forms.Button();
            this.Sobel = new System.Windows.Forms.Button();
            this.Previt = new System.Windows.Forms.Button();
            this.Kirsh = new System.Windows.Forms.Button();
            this.EmbossingInner = new System.Windows.Forms.Button();
            this.EmbossingOuter = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.Laplas);
            this.flowLayoutPanel1.Controls.Add(this.ShearDifference);
            this.flowLayoutPanel1.Controls.Add(this.Roberts);
            this.flowLayoutPanel1.Controls.Add(this.Sobel);
            this.flowLayoutPanel1.Controls.Add(this.Previt);
            this.flowLayoutPanel1.Controls.Add(this.Kirsh);
            this.flowLayoutPanel1.Controls.Add(this.EmbossingInner);
            this.flowLayoutPanel1.Controls.Add(this.EmbossingOuter);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(356, 450);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Laplas
            // 
            this.Laplas.Location = new System.Drawing.Point(3, 3);
            this.Laplas.Name = "Laplas";
            this.Laplas.Size = new System.Drawing.Size(75, 23);
            this.Laplas.TabIndex = 0;
            this.Laplas.Text = "Laplas";
            this.Laplas.UseVisualStyleBackColor = true;
            this.Laplas.Click += new System.EventHandler(this.Laplas_Click);
            // 
            // ShearDifference
            // 
            this.ShearDifference.Location = new System.Drawing.Point(84, 3);
            this.ShearDifference.Name = "ShearDifference";
            this.ShearDifference.Size = new System.Drawing.Size(96, 23);
            this.ShearDifference.TabIndex = 1;
            this.ShearDifference.Text = "ShearDifference";
            this.ShearDifference.UseVisualStyleBackColor = true;
            this.ShearDifference.Click += new System.EventHandler(this.ShearDifference_Click);
            // 
            // Roberts
            // 
            this.Roberts.Location = new System.Drawing.Point(186, 3);
            this.Roberts.Name = "Roberts";
            this.Roberts.Size = new System.Drawing.Size(75, 23);
            this.Roberts.TabIndex = 3;
            this.Roberts.Text = "Roberts";
            this.Roberts.UseVisualStyleBackColor = true;
            this.Roberts.Click += new System.EventHandler(this.Roberts_Click);
            // 
            // Sobel
            // 
            this.Sobel.Location = new System.Drawing.Point(267, 3);
            this.Sobel.Name = "Sobel";
            this.Sobel.Size = new System.Drawing.Size(75, 23);
            this.Sobel.TabIndex = 4;
            this.Sobel.Text = "Sobel";
            this.Sobel.UseVisualStyleBackColor = true;
            this.Sobel.Click += new System.EventHandler(this.Sobel_Click);
            // 
            // Previt
            // 
            this.Previt.Location = new System.Drawing.Point(3, 32);
            this.Previt.Name = "Previt";
            this.Previt.Size = new System.Drawing.Size(75, 23);
            this.Previt.TabIndex = 5;
            this.Previt.Text = "Previt";
            this.Previt.UseVisualStyleBackColor = true;
            this.Previt.Click += new System.EventHandler(this.Previt_Click);
            // 
            // Kirsh
            // 
            this.Kirsh.Location = new System.Drawing.Point(84, 32);
            this.Kirsh.Name = "Kirsh";
            this.Kirsh.Size = new System.Drawing.Size(75, 23);
            this.Kirsh.TabIndex = 6;
            this.Kirsh.Text = "Kirsh";
            this.Kirsh.UseVisualStyleBackColor = true;
            this.Kirsh.Click += new System.EventHandler(this.Kirsh_Click);
            // 
            // EmbossingInner
            // 
            this.EmbossingInner.Location = new System.Drawing.Point(165, 32);
            this.EmbossingInner.Name = "EmbossingInner";
            this.EmbossingInner.Size = new System.Drawing.Size(117, 23);
            this.EmbossingInner.TabIndex = 7;
            this.EmbossingInner.Text = "Embossing Inner";
            this.EmbossingInner.UseVisualStyleBackColor = true;
            this.EmbossingInner.Click += new System.EventHandler(this.EmbossingInner_Click);
            // 
            // EmbossingOuter
            // 
            this.EmbossingOuter.Location = new System.Drawing.Point(3, 61);
            this.EmbossingOuter.Name = "EmbossingOuter";
            this.EmbossingOuter.Size = new System.Drawing.Size(126, 23);
            this.EmbossingOuter.TabIndex = 8;
            this.EmbossingOuter.Text = "EmbossingOuter";
            this.EmbossingOuter.UseVisualStyleBackColor = true;
            this.EmbossingOuter.Click += new System.EventHandler(this.EmbossingOuter_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Laplas;
        private System.Windows.Forms.Button ShearDifference;
        private System.Windows.Forms.Button Roberts;
        private System.Windows.Forms.Button Sobel;
        private System.Windows.Forms.Button Previt;
        private System.Windows.Forms.Button Kirsh;
        private System.Windows.Forms.Button EmbossingInner;
        private System.Windows.Forms.Button EmbossingOuter;
    }
}