namespace Ap04
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
            cmbCurr = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtNT = new TextBox();
            btnExchange = new Button();
            txtAmount = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // cmbCurr
            // 
            cmbCurr.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCurr.FormattingEnabled = true;
            cmbCurr.Items.AddRange(new object[] { "美金", "日圓", "歐元" });
            cmbCurr.Location = new Point(119, 43);
            cmbCurr.Name = "cmbCurr";
            cmbCurr.Size = new Size(180, 28);
            cmbCurr.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 46);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 1;
            label1.Text = "幣別:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 80);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 2;
            label2.Text = "台幣:";
            // 
            // txtNT
            // 
            txtNT.Location = new Point(119, 77);
            txtNT.Name = "txtNT";
            txtNT.Size = new Size(180, 28);
            txtNT.TabIndex = 3;
            // 
            // btnExchange
            // 
            btnExchange.Location = new Point(119, 111);
            btnExchange.Name = "btnExchange";
            btnExchange.Size = new Size(121, 33);
            btnExchange.TabIndex = 4;
            btnExchange.Text = "兌換";
            btnExchange.UseVisualStyleBackColor = true;
            btnExchange.Click += btnExchange_Click;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(119, 150);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(180, 28);
            txtAmount.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 153);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 5;
            label3.Text = "可兌換金額:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 236);
            Controls.Add(txtAmount);
            Controls.Add(label3);
            Controls.Add(btnExchange);
            Controls.Add(txtNT);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbCurr);
            Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCurr;
        private Label label1;
        private Label label2;
        private TextBox txtNT;
        private Button btnExchange;
        private TextBox txtAmount;
        private Label label3;
    }
}
