namespace Ap11
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
            chkSame = new CheckBox();
            SuspendLayout();
            // 
            // txtA
            // 
            txtA.Location = new Point(110, 56);
            txtA.Margin = new Padding(4);
            txtA.Name = "txtA";
            txtA.Size = new Size(603, 28);
            txtA.TabIndex = 0;
            txtA.TextChanged += chkSame_CheckedChanged;
            // 
            // txtB
            // 
            txtB.Location = new Point(110, 147);
            txtB.Margin = new Padding(4);
            txtB.Name = "txtB";
            txtB.Size = new Size(603, 28);
            txtB.TabIndex = 1;
            // 
            // chkSame
            // 
            chkSame.AutoSize = true;
            chkSame.Location = new Point(110, 116);
            chkSame.Name = "chkSame";
            chkSame.Size = new Size(60, 24);
            chkSame.TabIndex = 2;
            chkSame.Text = "同上";
            chkSame.UseVisualStyleBackColor = true;
            chkSame.CheckedChanged += chkSame_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 314);
            Controls.Add(chkSame);
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
        private CheckBox chkSame;
    }
}
