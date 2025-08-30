namespace Ap01
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
            lblData = new Label();
            txtData = new TextBox();
            btnOk = new Button();
            SuspendLayout();
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(56, 43);
            lblData.Margin = new Padding(4, 0, 4, 0);
            lblData.Name = "lblData";
            lblData.Size = new Size(49, 20);
            lblData.TabIndex = 0;
            lblData.Text = "Data:";
            // 
            // txtData
            // 
            txtData.Location = new Point(124, 39);
            txtData.Margin = new Padding(4);
            txtData.Name = "txtData";
            txtData.Size = new Size(141, 28);
            txtData.TabIndex = 1;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(289, 39);
            btnOk.Margin = new Padding(4);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(107, 31);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 109);
            Controls.Add(btnOk);
            Controls.Add(txtData);
            Controls.Add(lblData);
            Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblData;
        private TextBox txtData;
        private Button btnOk;
    }
}
