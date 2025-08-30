namespace Ap05
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
            btnDog = new Button();
            btnCat = new Button();
            btnLion = new Button();
            ((System.ComponentModel.ISupportInitialize)pct1).BeginInit();
            SuspendLayout();
            // 
            // pct1
            // 
            pct1.BorderStyle = BorderStyle.Fixed3D;
            pct1.Image = Properties.Resources.dog;
            pct1.Location = new Point(43, 43);
            pct1.Margin = new Padding(4);
            pct1.Name = "pct1";
            pct1.Size = new Size(368, 237);
            pct1.SizeMode = PictureBoxSizeMode.Zoom;
            pct1.TabIndex = 0;
            pct1.TabStop = false;
            // 
            // btnDog
            // 
            btnDog.Location = new Point(433, 51);
            btnDog.Margin = new Padding(4);
            btnDog.Name = "btnDog";
            btnDog.Size = new Size(173, 51);
            btnDog.TabIndex = 1;
            btnDog.Text = "Dog";
            btnDog.UseVisualStyleBackColor = true;
            btnDog.Click += btnDog_Click;
            // 
            // btnCat
            // 
            btnCat.Location = new Point(433, 110);
            btnCat.Margin = new Padding(4);
            btnCat.Name = "btnCat";
            btnCat.Size = new Size(173, 51);
            btnCat.TabIndex = 2;
            btnCat.Text = "Cat";
            btnCat.UseVisualStyleBackColor = true;
            btnCat.Click += btnCat_Click;
            // 
            // btnLion
            // 
            btnLion.Location = new Point(433, 169);
            btnLion.Margin = new Padding(4);
            btnLion.Name = "btnLion";
            btnLion.Size = new Size(173, 51);
            btnLion.TabIndex = 3;
            btnLion.Text = "Lion";
            btnLion.UseVisualStyleBackColor = true;
            btnLion.Click += btnLion_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 455);
            Controls.Add(btnLion);
            Controls.Add(btnCat);
            Controls.Add(btnDog);
            Controls.Add(pct1);
            Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pct1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pct1;
        private Button btnDog;
        private Button btnCat;
        private Button btnLion;
    }
}
