namespace Ap06
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
            grpGuess = new GroupBox();
            txtGuess = new TextBox();
            label1 = new Label();
            btnStart = new Button();
            btnGuess = new Button();
            btnQuit = new Button();
            grpGuess.SuspendLayout();
            SuspendLayout();
            // 
            // grpGuess
            // 
            grpGuess.Controls.Add(txtGuess);
            grpGuess.Controls.Add(label1);
            grpGuess.Location = new Point(50, 33);
            grpGuess.Name = "grpGuess";
            grpGuess.Size = new Size(236, 95);
            grpGuess.TabIndex = 0;
            grpGuess.TabStop = false;
            grpGuess.Text = "猜數字";
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(77, 35);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(138, 28);
            txtGuess.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 43);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 0;
            label1.Text = "1-99";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(67, 148);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(69, 34);
            btnStart.TabIndex = 1;
            btnStart.Text = "開始";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnGuess
            // 
            btnGuess.Location = new Point(142, 148);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(69, 34);
            btnGuess.TabIndex = 2;
            btnGuess.Text = "猜數字";
            btnGuess.UseVisualStyleBackColor = true;
            btnGuess.Click += btnGuess_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(217, 148);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(69, 34);
            btnQuit.TabIndex = 3;
            btnQuit.Text = "離開";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 207);
            Controls.Add(btnQuit);
            Controls.Add(btnGuess);
            Controls.Add(btnStart);
            Controls.Add(grpGuess);
            Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            grpGuess.ResumeLayout(false);
            grpGuess.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpGuess;
        private TextBox txtGuess;
        private Label label1;
        private Button btnStart;
        private Button btnGuess;
        private Button btnQuit;
    }
}
