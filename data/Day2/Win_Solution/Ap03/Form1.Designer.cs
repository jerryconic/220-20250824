namespace Ap03
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
            label1 = new Label();
            label2 = new Label();
            txtScore = new TextBox();
            txtResult = new TextBox();
            btnCalc = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 43);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "成績:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 84);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 1;
            label2.Text = "結果:";
            // 
            // txtScore
            // 
            txtScore.BackColor = Color.FromArgb(192, 255, 255);
            txtScore.ForeColor = Color.FromArgb(0, 0, 192);
            txtScore.Location = new Point(98, 40);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(145, 28);
            txtScore.TabIndex = 2;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(98, 81);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(145, 28);
            txtResult.TabIndex = 3;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(92, 125);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(109, 32);
            btnCalc.TabIndex = 4;
            btnCalc.Text = "計算";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 184);
            Controls.Add(btnCalc);
            Controls.Add(txtResult);
            Controls.Add(txtScore);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtScore;
        private TextBox txtResult;
        private Button btnCalc;
    }
}
