namespace MinimartMIS
{
    partial class frmEditCategory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDescription = new TextBox();
            txtCategoryName = new TextBox();
            txtCategoryID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSave = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(178, 119);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(252, 182);
            txtDescription.TabIndex = 5;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(178, 86);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(252, 27);
            txtCategoryName.TabIndex = 6;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(178, 48);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(167, 27);
            txtCategoryID.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 89);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 2;
            label3.Text = "ชื่อหม่วดหมู่สินค้า";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 126);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 3;
            label2.Text = "รายละเอียด";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 51);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 4;
            label1.Text = "รหัสหม่วดหมู่สินค้า";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(148, 374);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(336, 376);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // frmEditCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(572, 497);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(txtDescription);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEditCategory";
            Text = "frmEditCategory";
            Load += frmEditCategory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescription;
        private TextBox txtCategoryName;
        private TextBox txtCategoryID;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSave;
        private Button btnClear;
    }
}