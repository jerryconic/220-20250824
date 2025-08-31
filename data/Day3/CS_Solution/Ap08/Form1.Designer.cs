namespace Ap08
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
            btnA = new Button();
            btnB = new Button();
            SuspendLayout();
            // 
            // btnA
            // 
            btnA.Location = new Point(107, 44);
            btnA.Name = "btnA";
            btnA.Size = new Size(146, 39);
            btnA.TabIndex = 0;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click += btn_Click;
            // 
            // btnB
            // 
            btnB.Location = new Point(107, 89);
            btnB.Name = "btnB";
            btnB.Size = new Size(146, 39);
            btnB.TabIndex = 1;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click += btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 192);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnA;
        private Button btnB;
    }
}
