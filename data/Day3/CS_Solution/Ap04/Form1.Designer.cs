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
            btnOk = new Button();
            btnAsk = new Button();
            btnQuit = new Button();
            txtAns = new TextBox();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Location = new Point(22, 20);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(92, 37);
            btnOk.TabIndex = 0;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnAsk
            // 
            btnAsk.Location = new Point(22, 90);
            btnAsk.Name = "btnAsk";
            btnAsk.Size = new Size(92, 37);
            btnAsk.TabIndex = 1;
            btnAsk.Text = "Ask";
            btnAsk.UseVisualStyleBackColor = true;
            btnAsk.Click += btnAsk_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(410, 186);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(92, 37);
            btnQuit.TabIndex = 2;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // txtAns
            // 
            txtAns.Location = new Point(118, 96);
            txtAns.Name = "txtAns";
            txtAns.Size = new Size(280, 28);
            txtAns.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 235);
            Controls.Add(txtAns);
            Controls.Add(btnQuit);
            Controls.Add(btnAsk);
            Controls.Add(btnOk);
            Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private Button btnAsk;
        private Button btnQuit;
        private TextBox txtAns;
    }
}
