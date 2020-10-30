namespace Image_Color_Conversions
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorTransformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bGRGreyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bGRYCrCbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bGRHSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bGRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bGRLubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bGRHSLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.colorTransformationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(71, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 261);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(421, 138);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(326, 261);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // colorTransformationToolStripMenuItem
            // 
            this.colorTransformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bGRGreyToolStripMenuItem,
            this.bGRYCrCbToolStripMenuItem,
            this.bGRHSVToolStripMenuItem,
            this.bGRToolStripMenuItem,
            this.bGRLubToolStripMenuItem,
            this.bGRHSLToolStripMenuItem});
            this.colorTransformationToolStripMenuItem.Name = "colorTransformationToolStripMenuItem";
            this.colorTransformationToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.colorTransformationToolStripMenuItem.Text = "ColorTransformation";
            // 
            // bGRGreyToolStripMenuItem
            // 
            this.bGRGreyToolStripMenuItem.Name = "bGRGreyToolStripMenuItem";
            this.bGRGreyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bGRGreyToolStripMenuItem.Text = "BGR - Grey";
            this.bGRGreyToolStripMenuItem.Click += new System.EventHandler(this.bGRGreyToolStripMenuItem_Click);
            // 
            // bGRYCrCbToolStripMenuItem
            // 
            this.bGRYCrCbToolStripMenuItem.Name = "bGRYCrCbToolStripMenuItem";
            this.bGRYCrCbToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bGRYCrCbToolStripMenuItem.Text = "BGR - YCrCb";
            this.bGRYCrCbToolStripMenuItem.Click += new System.EventHandler(this.bGRYCrCbToolStripMenuItem_Click);
            // 
            // bGRHSVToolStripMenuItem
            // 
            this.bGRHSVToolStripMenuItem.Name = "bGRHSVToolStripMenuItem";
            this.bGRHSVToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bGRHSVToolStripMenuItem.Text = "BGR - HSV";
            this.bGRHSVToolStripMenuItem.Click += new System.EventHandler(this.bGRHSVToolStripMenuItem_Click);
            // 
            // bGRToolStripMenuItem
            // 
            this.bGRToolStripMenuItem.Name = "bGRToolStripMenuItem";
            this.bGRToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bGRToolStripMenuItem.Text = "BGR - LUV";
            this.bGRToolStripMenuItem.Click += new System.EventHandler(this.bGRToolStripMenuItem_Click);
            // 
            // bGRLubToolStripMenuItem
            // 
            this.bGRLubToolStripMenuItem.Name = "bGRLubToolStripMenuItem";
            this.bGRLubToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bGRLubToolStripMenuItem.Text = "BGR - Lab";
            this.bGRLubToolStripMenuItem.Click += new System.EventHandler(this.bGRLubToolStripMenuItem_Click);
            // 
            // bGRHSLToolStripMenuItem
            // 
            this.bGRHSLToolStripMenuItem.Name = "bGRHSLToolStripMenuItem";
            this.bGRHSLToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bGRHSLToolStripMenuItem.Text = "BGR - HLS";
            this.bGRHSLToolStripMenuItem.Click += new System.EventHandler(this.bGRHSLToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorTransformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bGRGreyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bGRYCrCbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bGRHSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bGRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bGRLubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bGRHSLToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

