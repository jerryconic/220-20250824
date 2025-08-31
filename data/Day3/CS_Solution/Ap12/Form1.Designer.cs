namespace Ap12
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
            txtA = new TextBox();
            txtB = new TextBox();
            txtASCII = new TextBox();
            txtCode = new TextBox();
            label1 = new Label();
            txtMaxLength = new TextBox();
            txtDigit = new TextBox();
            label2 = new Label();
            txtLetter = new TextBox();
            label3 = new Label();
            txtUpper = new TextBox();
            label4 = new Label();
            txtLower = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtA
            // 
            txtA.Location = new Point(41, 31);
            txtA.Margin = new Padding(4);
            txtA.Name = "txtA";
            txtA.Size = new Size(594, 28);
            txtA.TabIndex = 0;
            txtA.KeyPress += txtA_KeyPress;
            // 
            // txtB
            // 
            txtB.Location = new Point(41, 136);
            txtB.Margin = new Padding(4);
            txtB.Name = "txtB";
            txtB.Size = new Size(594, 28);
            txtB.TabIndex = 1;
            txtB.KeyDown += txtB_KeyDown;
            // 
            // txtASCII
            // 
            txtASCII.Location = new Point(41, 69);
            txtASCII.Margin = new Padding(4);
            txtASCII.Name = "txtASCII";
            txtASCII.Size = new Size(115, 28);
            txtASCII.TabIndex = 2;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(41, 175);
            txtCode.Margin = new Padding(4);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(115, 28);
            txtCode.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 225);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 4;
            label1.Text = "Length:10";
            // 
            // txtMaxLength
            // 
            txtMaxLength.Location = new Point(131, 222);
            txtMaxLength.MaxLength = 10;
            txtMaxLength.Name = "txtMaxLength";
            txtMaxLength.PasswordChar = '*';
            txtMaxLength.Size = new Size(226, 28);
            txtMaxLength.TabIndex = 5;
            txtMaxLength.UseSystemPasswordChar = true;
            // 
            // txtDigit
            // 
            txtDigit.Location = new Point(131, 256);
            txtDigit.Name = "txtDigit";
            txtDigit.Size = new Size(226, 28);
            txtDigit.TabIndex = 7;
            txtDigit.KeyPress += txtDigit_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 259);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 6;
            label2.Text = "Digit";
            // 
            // txtLetter
            // 
            txtLetter.Location = new Point(131, 290);
            txtLetter.Name = "txtLetter";
            txtLetter.Size = new Size(226, 28);
            txtLetter.TabIndex = 9;
            txtLetter.KeyPress += txtLetter_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 293);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 8;
            label3.Text = "Letter";
            // 
            // txtUpper
            // 
            txtUpper.Location = new Point(131, 324);
            txtUpper.Name = "txtUpper";
            txtUpper.Size = new Size(226, 28);
            txtUpper.TabIndex = 11;
            txtUpper.KeyPress += txtUpper_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 327);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 10;
            label4.Text = "Upper";
            // 
            // txtLower
            // 
            txtLower.Location = new Point(131, 358);
            txtLower.Name = "txtLower";
            txtLower.Size = new Size(226, 28);
            txtLower.TabIndex = 13;
            txtLower.KeyPress += txtLower_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 361);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 12;
            label5.Text = "Lower";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 392);
            Controls.Add(txtLower);
            Controls.Add(label5);
            Controls.Add(txtUpper);
            Controls.Add(label4);
            Controls.Add(txtLetter);
            Controls.Add(label3);
            Controls.Add(txtDigit);
            Controls.Add(label2);
            Controls.Add(txtMaxLength);
            Controls.Add(label1);
            Controls.Add(txtCode);
            Controls.Add(txtASCII);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtASCII;
        private TextBox txtCode;
        private Label label1;
        private TextBox txtMaxLength;
        private TextBox txtDigit;
        private Label label2;
        private TextBox txtLetter;
        private Label label3;
        private TextBox txtUpper;
        private Label label4;
        private TextBox txtLower;
        private Label label5;
    }
}
