﻿namespace Ap13
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(151, 36);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(451, 28);
            textBox1.TabIndex = 0;
            textBox1.Enter += txt_Enter;
            textBox1.KeyDown += txt_KeyDown;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(151, 252);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(451, 28);
            textBox2.TabIndex = 6;
            textBox2.Enter += txt_Enter;
            textBox2.KeyDown += txt_KeyDown;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(151, 216);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(451, 28);
            textBox3.TabIndex = 5;
            textBox3.Enter += txt_Enter;
            textBox3.KeyDown += txt_KeyDown;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(151, 288);
            textBox4.Margin = new Padding(4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(451, 28);
            textBox4.TabIndex = 7;
            textBox4.Enter += txt_Enter;
            textBox4.KeyDown += txt_KeyDown;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(151, 180);
            textBox5.Margin = new Padding(4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(451, 28);
            textBox5.TabIndex = 4;
            textBox5.Enter += txt_Enter;
            textBox5.KeyDown += txt_KeyDown;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(151, 144);
            textBox6.Margin = new Padding(4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(451, 28);
            textBox6.TabIndex = 3;
            textBox6.Enter += txt_Enter;
            textBox6.KeyDown += txt_KeyDown;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(151, 108);
            textBox7.Margin = new Padding(4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(451, 28);
            textBox7.TabIndex = 2;
            textBox7.Enter += txt_Enter;
            textBox7.KeyDown += txt_KeyDown;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(151, 72);
            textBox8.Margin = new Padding(4);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(451, 28);
            textBox8.TabIndex = 1;
            textBox8.Enter += txt_Enter;
            textBox8.KeyDown += txt_KeyDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 373);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox7);
            Controls.Add(textBox8);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
    }
}
