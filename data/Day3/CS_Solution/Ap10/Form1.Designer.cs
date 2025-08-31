namespace Ap10
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
            pct1 = new PictureBox();
            txtData = new TextBox();
            btnLine = new Button();
            btnRectangle = new Button();
            btnEllipse = new Button();
            ((System.ComponentModel.ISupportInitialize)pct1).BeginInit();
            SuspendLayout();
            // 
            // pct1
            // 
            pct1.BackColor = Color.White;
            pct1.BorderStyle = BorderStyle.Fixed3D;
            pct1.Location = new Point(15, 15);
            pct1.Name = "pct1";
            pct1.Size = new Size(386, 302);
            pct1.TabIndex = 0;
            pct1.TabStop = false;
            pct1.MouseDown += pct1_MouseDown;
            pct1.MouseMove += pct1_MouseMove;
            // 
            // txtData
            // 
            txtData.Location = new Point(15, 328);
            txtData.Name = "txtData";
            txtData.Size = new Size(386, 23);
            txtData.TabIndex = 1;
            // 
            // btnLine
            // 
            btnLine.Location = new Point(413, 21);
            btnLine.Name = "btnLine";
            btnLine.Size = new Size(86, 35);
            btnLine.TabIndex = 2;
            btnLine.Text = "Line";
            btnLine.UseVisualStyleBackColor = true;
            btnLine.Click += btnLine_Click;
            // 
            // btnRectangle
            // 
            btnRectangle.Location = new Point(413, 62);
            btnRectangle.Name = "btnRectangle";
            btnRectangle.Size = new Size(86, 35);
            btnRectangle.TabIndex = 3;
            btnRectangle.Text = "Rectangle";
            btnRectangle.UseVisualStyleBackColor = true;
            btnRectangle.Click += btnRectangle_Click;
            // 
            // btnEllipse
            // 
            btnEllipse.Location = new Point(413, 103);
            btnEllipse.Name = "btnEllipse";
            btnEllipse.Size = new Size(86, 35);
            btnEllipse.TabIndex = 4;
            btnEllipse.Text = "Ellipse";
            btnEllipse.UseVisualStyleBackColor = true;
            btnEllipse.Click += btnEllipse_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 363);
            Controls.Add(btnEllipse);
            Controls.Add(btnRectangle);
            Controls.Add(btnLine);
            Controls.Add(txtData);
            Controls.Add(pct1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pct1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pct1;
        private TextBox txtData;
        private Button btnLine;
        private Button btnRectangle;
        private Button btnEllipse;
    }
}
