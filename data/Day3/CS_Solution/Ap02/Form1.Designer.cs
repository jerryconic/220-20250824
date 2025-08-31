namespace Ap02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRoll = new Button();
            pct4 = new PictureBox();
            pct3 = new PictureBox();
            pct2 = new PictureBox();
            pct1 = new PictureBox();
            lblPoints = new Label();
            ((System.ComponentModel.ISupportInitialize)pct4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pct3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pct2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pct1).BeginInit();
            SuspendLayout();
            // 
            // btnRoll
            // 
            btnRoll.Font = new Font("Microsoft JhengHei UI", 12F);
            btnRoll.Location = new Point(539, 221);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(137, 43);
            btnRoll.TabIndex = 9;
            btnRoll.Text = "Roll";
            btnRoll.UseVisualStyleBackColor = true;
            btnRoll.Click += btnRoll_Click;
            // 
            // pct4
            // 
            pct4.BorderStyle = BorderStyle.Fixed3D;
            pct4.Location = new Point(529, 57);
            pct4.Name = "pct4";
            pct4.Size = new Size(157, 136);
            pct4.SizeMode = PictureBoxSizeMode.StretchImage;
            pct4.TabIndex = 8;
            pct4.TabStop = false;
            // 
            // pct3
            // 
            pct3.BorderStyle = BorderStyle.Fixed3D;
            pct3.Location = new Point(366, 57);
            pct3.Name = "pct3";
            pct3.Size = new Size(157, 136);
            pct3.SizeMode = PictureBoxSizeMode.StretchImage;
            pct3.TabIndex = 7;
            pct3.TabStop = false;
            // 
            // pct2
            // 
            pct2.BorderStyle = BorderStyle.Fixed3D;
            pct2.Location = new Point(203, 57);
            pct2.Name = "pct2";
            pct2.Size = new Size(157, 136);
            pct2.SizeMode = PictureBoxSizeMode.StretchImage;
            pct2.TabIndex = 6;
            pct2.TabStop = false;
            // 
            // pct1
            // 
            pct1.BorderStyle = BorderStyle.Fixed3D;
            pct1.Location = new Point(40, 57);
            pct1.Name = "pct1";
            pct1.Size = new Size(157, 136);
            pct1.SizeMode = PictureBoxSizeMode.StretchImage;
            pct1.TabIndex = 5;
            pct1.TabStop = false;
            // 
            // lblPoints
            // 
            lblPoints.AutoSize = true;
            lblPoints.Font = new Font("Microsoft JhengHei UI", 12F);
            lblPoints.ForeColor = Color.FromArgb(255, 255, 192);
            lblPoints.Location = new Point(49, 235);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new Size(57, 20);
            lblPoints.TabIndex = 10;
            lblPoints.Text = "點數：";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(742, 395);
            Controls.Add(lblPoints);
            Controls.Add(btnRoll);
            Controls.Add(pct4);
            Controls.Add(pct3);
            Controls.Add(pct2);
            Controls.Add(pct1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pct4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pct3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pct2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pct1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRoll;
        private PictureBox pct4;
        private PictureBox pct3;
        private PictureBox pct2;
        private PictureBox pct1;
        private Label lblPoints;
    }
}
