namespace MinimartMIS
{
    partial class frmEditProducts
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
            cboCategory = new ComboBox();
            txtUnitsInStock = new TextBox();
            txtUnitPrice = new TextBox();
            txtProductName = new TextBox();
            txtProductID = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            radDiscontinued = new RadioButton();
            radContinued = new RadioButton();
            btnClear = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboCategory);
            groupBox1.Controls.Add(txtUnitsInStock);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(txtProductID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(48, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(481, 251);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "จัดการข้อมูลสินค้า";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(132, 181);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(252, 28);
            cboCategory.TabIndex = 2;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(132, 144);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(125, 27);
            txtUnitsInStock.TabIndex = 1;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(132, 103);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(125, 27);
            txtUnitPrice.TabIndex = 1;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(132, 70);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(252, 27);
            txtProductName.TabIndex = 1;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(132, 32);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(167, 27);
            txtProductID.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 73);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 0;
            label3.Text = "ชื่อสินค้า";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 184);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 0;
            label5.Text = "ประเภทสินค้า";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 144);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 0;
            label4.Text = "จำนวน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 108);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 0;
            label2.Text = "ราคา";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 35);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "รหัสสินค้า";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radDiscontinued);
            groupBox2.Controls.Add(radContinued);
            groupBox2.Location = new Point(211, 305);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(318, 132);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "สถานะสินค้า";
            // 
            // radDiscontinued
            // 
            radDiscontinued.AutoSize = true;
            radDiscontinued.Location = new Point(38, 75);
            radDiscontinued.Name = "radDiscontinued";
            radDiscontinued.Size = new Size(99, 24);
            radDiscontinued.TabIndex = 0;
            radDiscontinued.TabStop = true;
            radDiscontinued.Text = "เลิกจำหน่าย";
            radDiscontinued.UseVisualStyleBackColor = true;
            // 
            // radContinued
            // 
            radContinued.AutoSize = true;
            radContinued.Location = new Point(38, 45);
            radContinued.Name = "radContinued";
            radContinued.Size = new Size(105, 24);
            radContinued.TabIndex = 0;
            radContinued.TabStop = true;
            radContinued.Text = "จำหน่ายปกติ";
            radContinued.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(294, 466);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(106, 464);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmEditProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(621, 581);
            Controls.Add(button1);
            Controls.Add(btnClear);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ControlText;
            Name = "frmEditProducts";
            Text = "frmEditProducts";
            Load += frmEditProducts_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtUnitsInStock;
        private TextBox txtUnitPrice;
        private TextBox txtProductName;
        private TextBox txtProductID;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label2;
        private ComboBox cboCategory;
        private GroupBox groupBox2;
        private RadioButton radContinued;
        private RadioButton radDiscontinued;
        private Button btnClear;
        private Button button1;
    }
}
