namespace ProductCRUD
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
            txtId = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            btnSelect = new Button();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnTest = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 37);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "產品編號";
            // 
            // txtId
            // 
            txtId.Location = new Point(107, 34);
            txtId.Name = "txtId";
            txtId.Size = new Size(153, 28);
            txtId.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(107, 83);
            txtName.Name = "txtName";
            txtName.Size = new Size(153, 28);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 86);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "產品名稱";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(107, 133);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(153, 28);
            txtPrice.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 136);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 4;
            label3.Text = "產品單價";
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(277, 34);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(108, 28);
            btnSelect.TabIndex = 6;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(28, 192);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(108, 28);
            btnInsert.TabIndex = 7;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(142, 192);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(108, 28);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(256, 192);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 28);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(437, 192);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(108, 28);
            btnTest.TabIndex = 10;
            btnTest.Text = "Test";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 288);
            Controls.Add(btnTest);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(btnSelect);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtId);
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
        private TextBox txtId;
        private TextBox txtName;
        private Label label2;
        private TextBox txtPrice;
        private Label label3;
        private Button btnSelect;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnTest;
    }
}
