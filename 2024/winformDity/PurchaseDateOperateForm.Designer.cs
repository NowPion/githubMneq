
namespace winformDity
{
    partial class PurchaseDateOperateForm
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
            this.采购单 = new System.Windows.Forms.GroupBox();
            this.SubTotal = new System.Windows.Forms.Label();
            this.PurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.button6 = new System.Windows.Forms.Button();
            this.SupplierSimpleName = new System.Windows.Forms.TextBox();
            this.SupplierID = new System.Windows.Forms.TextBox();
            this.PurchaseID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.PurchaseQuantity = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.PurchaseUnitPrice = new System.Windows.Forms.TextBox();
            this.ProductID = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.InpAddSum = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PurchaseDetailGridView = new System.Windows.Forms.DataGridView();
            this.ProductID_Lie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName_Lie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseUnitPrice_Lie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseQuantity_Lie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseAmount_Lie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.采购单.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseDetailGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // 采购单
            // 
            this.采购单.Controls.Add(this.SubTotal);
            this.采购单.Controls.Add(this.PurchaseDate);
            this.采购单.Controls.Add(this.button6);
            this.采购单.Controls.Add(this.SupplierSimpleName);
            this.采购单.Controls.Add(this.SupplierID);
            this.采购单.Controls.Add(this.PurchaseID);
            this.采购单.Controls.Add(this.label5);
            this.采购单.Controls.Add(this.label4);
            this.采购单.Controls.Add(this.label3);
            this.采购单.Controls.Add(this.label2);
            this.采购单.Controls.Add(this.label1);
            this.采购单.ForeColor = System.Drawing.Color.Blue;
            this.采购单.Location = new System.Drawing.Point(30, 23);
            this.采购单.Name = "采购单";
            this.采购单.Size = new System.Drawing.Size(996, 146);
            this.采购单.TabIndex = 0;
            this.采购单.TabStop = false;
            this.采购单.Text = "采购单";
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSize = true;
            this.SubTotal.ForeColor = System.Drawing.Color.Crimson;
            this.SubTotal.Location = new System.Drawing.Point(730, 93);
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Size = new System.Drawing.Size(0, 15);
            this.SubTotal.TabIndex = 11;
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.Location = new System.Drawing.Point(154, 94);
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.Size = new System.Drawing.Size(167, 25);
            this.PurchaseDate.TabIndex = 10;
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(660, 42);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(81, 26);
            this.button6.TabIndex = 9;
            this.button6.Text = "选择";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // SupplierSimpleName
            // 
            this.SupplierSimpleName.Location = new System.Drawing.Point(488, 87);
            this.SupplierSimpleName.Name = "SupplierSimpleName";
            this.SupplierSimpleName.Size = new System.Drawing.Size(166, 25);
            this.SupplierSimpleName.TabIndex = 8;
            // 
            // SupplierID
            // 
            this.SupplierID.Location = new System.Drawing.Point(488, 43);
            this.SupplierID.Name = "SupplierID";
            this.SupplierID.Size = new System.Drawing.Size(166, 25);
            this.SupplierID.TabIndex = 7;
            // 
            // PurchaseID
            // 
            this.PurchaseID.Location = new System.Drawing.Point(155, 43);
            this.PurchaseID.Name = "PurchaseID";
            this.PurchaseID.Size = new System.Drawing.Size(166, 25);
            this.PurchaseID.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(665, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "总金额：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(397, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "供应商简称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(397, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "供应商编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(36, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "采购日期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "采购编号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.PurchaseQuantity);
            this.groupBox2.Controls.Add(this.ProductName);
            this.groupBox2.Controls.Add(this.PurchaseUnitPrice);
            this.groupBox2.Controls.Add(this.ProductID);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.InpAddSum);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(30, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(996, 167);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "采购单明细";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(659, 50);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(81, 26);
            this.button7.TabIndex = 10;
            this.button7.Text = "选择";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // PurchaseQuantity
            // 
            this.PurchaseQuantity.Location = new System.Drawing.Point(487, 102);
            this.PurchaseQuantity.Name = "PurchaseQuantity";
            this.PurchaseQuantity.Size = new System.Drawing.Size(166, 25);
            this.PurchaseQuantity.TabIndex = 13;
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(487, 52);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(166, 25);
            this.ProductName.TabIndex = 10;
            // 
            // PurchaseUnitPrice
            // 
            this.PurchaseUnitPrice.Location = new System.Drawing.Point(154, 105);
            this.PurchaseUnitPrice.Name = "PurchaseUnitPrice";
            this.PurchaseUnitPrice.Size = new System.Drawing.Size(166, 25);
            this.PurchaseUnitPrice.TabIndex = 12;
            // 
            // ProductID
            // 
            this.ProductID.Location = new System.Drawing.Point(154, 55);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(166, 25);
            this.ProductID.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(870, 105);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 29);
            this.button5.TabIndex = 11;
            this.button5.Text = "删除";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(870, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 29);
            this.button4.TabIndex = 10;
            this.button4.Text = "修改";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // InpAddSum
            // 
            this.InpAddSum.Location = new System.Drawing.Point(870, 35);
            this.InpAddSum.Name = "InpAddSum";
            this.InpAddSum.Size = new System.Drawing.Size(101, 29);
            this.InpAddSum.TabIndex = 9;
            this.InpAddSum.Text = "插入";
            this.InpAddSum.UseVisualStyleBackColor = true;
            this.InpAddSum.Click += new System.EventHandler(this.InpAddSum_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(417, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "数量";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "商品名称";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "单价";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "商品编号";
            // 
            // PurchaseDetailGridView
            // 
            this.PurchaseDetailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PurchaseDetailGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID_Lie,
            this.ProductName_Lie,
            this.PurchaseUnitPrice_Lie,
            this.PurchaseQuantity_Lie,
            this.PurchaseAmount_Lie});
            this.PurchaseDetailGridView.Location = new System.Drawing.Point(30, 348);
            this.PurchaseDetailGridView.Name = "PurchaseDetailGridView";
            this.PurchaseDetailGridView.RowHeadersWidth = 51;
            this.PurchaseDetailGridView.RowTemplate.Height = 27;
            this.PurchaseDetailGridView.Size = new System.Drawing.Size(996, 203);
            this.PurchaseDetailGridView.TabIndex = 2;
            this.PurchaseDetailGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PurchaseDetailGridView_CellContentClick);
            this.PurchaseDetailGridView.Click += new System.EventHandler(this.PurchaseDetailGridView_Click);
            // 
            // ProductID_Lie
            // 
            this.ProductID_Lie.HeaderText = "商品编号";
            this.ProductID_Lie.MinimumWidth = 6;
            this.ProductID_Lie.Name = "ProductID_Lie";
            this.ProductID_Lie.Width = 125;
            // 
            // ProductName_Lie
            // 
            this.ProductName_Lie.HeaderText = "商品名称";
            this.ProductName_Lie.MinimumWidth = 6;
            this.ProductName_Lie.Name = "ProductName_Lie";
            this.ProductName_Lie.Width = 125;
            // 
            // PurchaseUnitPrice_Lie
            // 
            this.PurchaseUnitPrice_Lie.HeaderText = "单价";
            this.PurchaseUnitPrice_Lie.MinimumWidth = 6;
            this.PurchaseUnitPrice_Lie.Name = "PurchaseUnitPrice_Lie";
            this.PurchaseUnitPrice_Lie.Width = 125;
            // 
            // PurchaseQuantity_Lie
            // 
            this.PurchaseQuantity_Lie.HeaderText = "数量";
            this.PurchaseQuantity_Lie.MinimumWidth = 6;
            this.PurchaseQuantity_Lie.Name = "PurchaseQuantity_Lie";
            this.PurchaseQuantity_Lie.Width = 125;
            // 
            // PurchaseAmount_Lie
            // 
            this.PurchaseAmount_Lie.HeaderText = "金额";
            this.PurchaseAmount_Lie.MinimumWidth = 6;
            this.PurchaseAmount_Lie.Name = "PurchaseAmount_Lie";
            this.PurchaseAmount_Lie.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(558, 569);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 44);
            this.button2.TabIndex = 4;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PurchaseDateOperateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1067, 646);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PurchaseDetailGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.采购单);
            this.Name = "PurchaseDateOperateForm";
            this.Text = "PurchaseDateOperateForm";
            this.Load += new System.EventHandler(this.PurchaseDateOperateForm_Load);
            this.采购单.ResumeLayout(false);
            this.采购单.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseDetailGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox 采购单;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView PurchaseDetailGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button InpAddSum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PurchaseID;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox SupplierSimpleName;
        private System.Windows.Forms.TextBox SupplierID;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox PurchaseQuantity;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.TextBox PurchaseUnitPrice;
        private System.Windows.Forms.TextBox ProductID;
        private System.Windows.Forms.DateTimePicker PurchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID_Lie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName_Lie;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseUnitPrice_Lie;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseQuantity_Lie;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseAmount_Lie;
        private System.Windows.Forms.Label SubTotal;
    }
}