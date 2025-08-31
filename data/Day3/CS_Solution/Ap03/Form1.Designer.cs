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
            groupBox1 = new GroupBox();
            rdoNo3 = new RadioButton();
            rdoNo2 = new RadioButton();
            rdoNo1 = new RadioButton();
            chkCream = new CheckBox();
            chkPie = new CheckBox();
            label1 = new Label();
            txtTotal = new TextBox();
            btnCalc = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoNo3);
            groupBox1.Controls.Add(rdoNo2);
            groupBox1.Controls.Add(rdoNo1);
            groupBox1.Location = new Point(53, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(176, 131);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "餐點";
            // 
            // rdoNo3
            // 
            rdoNo3.AutoSize = true;
            rdoNo3.Location = new Point(28, 90);
            rdoNo3.Name = "rdoNo3";
            rdoNo3.Size = new Size(96, 24);
            rdoNo3.TabIndex = 2;
            rdoNo3.TabStop = true;
            rdoNo3.Text = "No3(120)";
            rdoNo3.UseVisualStyleBackColor = true;
            // 
            // rdoNo2
            // 
            rdoNo2.AutoSize = true;
            rdoNo2.Location = new Point(28, 60);
            rdoNo2.Name = "rdoNo2";
            rdoNo2.Size = new Size(96, 24);
            rdoNo2.TabIndex = 1;
            rdoNo2.TabStop = true;
            rdoNo2.Text = "No2(105)";
            rdoNo2.UseVisualStyleBackColor = true;
            // 
            // rdoNo1
            // 
            rdoNo1.AutoSize = true;
            rdoNo1.Location = new Point(28, 30);
            rdoNo1.Name = "rdoNo1";
            rdoNo1.Size = new Size(87, 24);
            rdoNo1.TabIndex = 0;
            rdoNo1.TabStop = true;
            rdoNo1.Text = "No1(95)";
            rdoNo1.UseVisualStyleBackColor = true;
            // 
            // chkCream
            // 
            chkCream.AutoSize = true;
            chkCream.Location = new Point(81, 176);
            chkCream.Name = "chkCream";
            chkCream.Size = new Size(132, 24);
            chkCream.TabIndex = 1;
            chkCream.Text = "Ice Cream(15)";
            chkCream.UseVisualStyleBackColor = true;
            // 
            // chkPie
            // 
            chkPie.AutoSize = true;
            chkPie.Location = new Point(81, 206);
            chkPie.Name = "chkPie";
            chkPie.Size = new Size(127, 24);
            chkPie.TabIndex = 2;
            chkPie.Text = "Apple Pie(25)";
            chkPie.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 256);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 3;
            label1.Text = "小計：";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(121, 249);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(107, 28);
            txtTotal.TabIndex = 4;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(92, 296);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(116, 36);
            btnCalc.TabIndex = 0;
            btnCalc.Text = "計算";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 397);
            Controls.Add(btnCalc);
            Controls.Add(txtTotal);
            Controls.Add(label1);
            Controls.Add(chkPie);
            Controls.Add(chkCream);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdoNo3;
        private RadioButton rdoNo2;
        private RadioButton rdoNo1;
        private CheckBox chkCream;
        private CheckBox chkPie;
        private Label label1;
        private TextBox txtTotal;
        private Button btnCalc;
    }
}
