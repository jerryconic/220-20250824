namespace Ap09
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn0 = new Button();
            btn1 = new Button();
            btnDot = new Button();
            txtDisplay = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(17, 48);
            button1.Name = "button1";
            button1.Size = new Size(62, 56);
            button1.TabIndex = 1;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(85, 48);
            button2.Name = "button2";
            button2.Size = new Size(62, 56);
            button2.TabIndex = 2;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btn_Click;
            // 
            // button3
            // 
            button3.Location = new Point(153, 48);
            button3.Name = "button3";
            button3.Size = new Size(62, 56);
            button3.TabIndex = 3;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btn_Click;
            // 
            // button4
            // 
            button4.Location = new Point(153, 110);
            button4.Name = "button4";
            button4.Size = new Size(62, 56);
            button4.TabIndex = 6;
            button4.Text = "6";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btn_Click;
            // 
            // button5
            // 
            button5.Location = new Point(85, 110);
            button5.Name = "button5";
            button5.Size = new Size(62, 56);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btn_Click;
            // 
            // button6
            // 
            button6.Location = new Point(17, 110);
            button6.Name = "button6";
            button6.Size = new Size(62, 56);
            button6.TabIndex = 4;
            button6.Text = "4";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btn_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(153, 172);
            btn3.Name = "btn3";
            btn3.Size = new Size(62, 56);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(85, 172);
            btn2.Name = "btn2";
            btn2.Size = new Size(62, 56);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(17, 234);
            btn0.Name = "btn0";
            btn0.Size = new Size(130, 56);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(17, 172);
            btn1.Name = "btn1";
            btn1.Size = new Size(62, 56);
            btn1.TabIndex = 11;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn_Click;
            // 
            // btnDot
            // 
            btnDot.Location = new Point(153, 234);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(62, 56);
            btnDot.TabIndex = 12;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btn_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(17, 14);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(198, 28);
            txtDisplay.TabIndex = 13;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 299);
            Controls.Add(txtDisplay);
            Controls.Add(btnDot);
            Controls.Add(btn1);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button btn3;
        private Button btn2;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button btn0;
        private Button btn1;
        private Button btnDot;
        private TextBox txtDisplay;
    }
}
