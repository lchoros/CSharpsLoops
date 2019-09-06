namespace TurtleGraphics
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
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonHideTurtle = new System.Windows.Forms.Button();
            this.buttonHexagon = new System.Windows.Forms.Button();
            this.drawStar = new System.Windows.Forms.Button();
            this.buttonDrawSpiral = new System.Windows.Forms.Button();
            this.buttonDrawSun = new System.Windows.Forms.Button();
            this.buttonDrawTriangle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(12, 12);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(97, 34);
            this.buttonDraw.TabIndex = 0;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(13, 61);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(96, 36);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonHideTurtle
            // 
            this.buttonHideTurtle.Location = new System.Drawing.Point(13, 116);
            this.buttonHideTurtle.Name = "buttonHideTurtle";
            this.buttonHideTurtle.Size = new System.Drawing.Size(97, 39);
            this.buttonHideTurtle.TabIndex = 2;
            this.buttonHideTurtle.Text = "Hide Turtle";
            this.buttonHideTurtle.UseVisualStyleBackColor = true;
            this.buttonHideTurtle.Click += new System.EventHandler(this.buttonHideTurtle_Click);
            // 
            // buttonHexagon
            // 
            this.buttonHexagon.Location = new System.Drawing.Point(13, 171);
            this.buttonHexagon.Name = "buttonHexagon";
            this.buttonHexagon.Size = new System.Drawing.Size(97, 40);
            this.buttonHexagon.TabIndex = 3;
            this.buttonHexagon.Text = "Hexagon";
            this.buttonHexagon.UseVisualStyleBackColor = true;
            this.buttonHexagon.Click += new System.EventHandler(this.buttonHexagon_Click);
            // 
            // drawStar
            // 
            this.drawStar.Location = new System.Drawing.Point(13, 228);
            this.drawStar.Name = "drawStar";
            this.drawStar.Size = new System.Drawing.Size(97, 36);
            this.drawStar.TabIndex = 4;
            this.drawStar.Text = "Star";
            this.drawStar.UseVisualStyleBackColor = true;
            this.drawStar.Click += new System.EventHandler(this.drawStar_Click);
            // 
            // buttonDrawSpiral
            // 
            this.buttonDrawSpiral.Location = new System.Drawing.Point(13, 279);
            this.buttonDrawSpiral.Name = "buttonDrawSpiral";
            this.buttonDrawSpiral.Size = new System.Drawing.Size(96, 33);
            this.buttonDrawSpiral.TabIndex = 5;
            this.buttonDrawSpiral.Text = "Spiral";
            this.buttonDrawSpiral.UseVisualStyleBackColor = true;
            this.buttonDrawSpiral.Click += new System.EventHandler(this.buttonDrawSpiral_Click);
            // 
            // buttonDrawSun
            // 
            this.buttonDrawSun.Location = new System.Drawing.Point(13, 328);
            this.buttonDrawSun.Name = "buttonDrawSun";
            this.buttonDrawSun.Size = new System.Drawing.Size(96, 35);
            this.buttonDrawSun.TabIndex = 6;
            this.buttonDrawSun.Text = "Sun";
            this.buttonDrawSun.UseVisualStyleBackColor = true;
            this.buttonDrawSun.Click += new System.EventHandler(this.buttonDrawSun_Click);
            // 
            // buttonDrawTriangle
            // 
            this.buttonDrawTriangle.Location = new System.Drawing.Point(12, 381);
            this.buttonDrawTriangle.Name = "buttonDrawTriangle";
            this.buttonDrawTriangle.Size = new System.Drawing.Size(97, 35);
            this.buttonDrawTriangle.TabIndex = 7;
            this.buttonDrawTriangle.Text = "SpiralTriangle";
            this.buttonDrawTriangle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDrawTriangle);
            this.Controls.Add(this.buttonDrawSun);
            this.Controls.Add(this.buttonDrawSpiral);
            this.Controls.Add(this.drawStar);
            this.Controls.Add(this.buttonHexagon);
            this.Controls.Add(this.buttonHideTurtle);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonHideTurtle;
        private System.Windows.Forms.Button buttonHexagon;
        private System.Windows.Forms.Button drawStar;
        private System.Windows.Forms.Button buttonDrawSpiral;
        private System.Windows.Forms.Button buttonDrawSun;
        private System.Windows.Forms.Button buttonDrawTriangle;
    }
}

