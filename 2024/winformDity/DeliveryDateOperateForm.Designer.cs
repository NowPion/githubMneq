
namespace winformDity
{
    partial class DeliveryDateOperateForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DeliveryDetailGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.SalesQuantity = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.SalesUnitPrice = new System.Windows.Forms.TextBox();
            this.ProductID = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.InpAddSum = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.采购单 = new System.Windows.Forms.GroupBox();
            this.SubTotal = new System.Windows.Forms.Label();
            this.DeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.button6 = new System.Windows.Forms.Button();
            this.SalesManName = new System.Windows.Forms.TextBox();
            this.SalesManID = new System.Windows.Forms.TextBox();
            this.DeliveryID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductID_Lie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName_Lie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesUnitPrice_Lie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesQuantity_Lie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesAmount_Lie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.CustomerID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DeliveryAddress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryDetailGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.采购单.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(559, 655);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 44);
            this.button2.TabIndex = 9;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 655);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeliveryDetailGridView
            // 
            this.DeliveryDetailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeliveryDetailGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID_Lie,
            this.ProductName_Lie,
            this.SalesUnitPrice_Lie,
            this.SalesQuantity_Lie,
            this.SalesAmount_Lie});
            this.DeliveryDetailGridView.Location = new System.Drawing.Point(37, 435);
            this.DeliveryDetailGridView.Name = "DeliveryDetailGridView";
            this.DeliveryDetailGridView.RowHeadersWidth = 51;
            this.DeliveryDetailGridView.RowTemplate.Height = 27;
            this.DeliveryDetailGridView.Size = new System.Drawing.Size(996, 203);
            this.DeliveryDetailGridView.TabIndex = 7;
            this.DeliveryDetailGridView.Click += new System.EventHandler(this.DeliveryDetailGridView_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.SalesQuantity);
            this.groupBox2.Controls.Add(this.ProductName);
            this.groupBox2.Controls.Add(this.SalesUnitPrice);
            this.groupBox2.Controls.Add(this.ProductID);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.InpAddSum);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(37, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(996, 167);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "销售单明细";
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
            // SalesQuantity
            // 
            this.SalesQuantity.Location = new System.Drawing.Point(487, 102);
            this.SalesQuantity.Name = "SalesQuantity";
            this.SalesQuantity.Size = new System.Drawing.Size(166, 25);
            this.SalesQuantity.TabIndex = 13;
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(487, 52);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(166, 25);
            this.ProductName.TabIndex = 10;
            // 
            // SalesUnitPrice
            // 
            this.SalesUnitPrice.Location = new System.Drawing.Point(154, 105);
            this.SalesUnitPrice.Name = "SalesUnitPrice";
            this.SalesUnitPrice.Size = new System.Drawing.Size(166, 25);
            this.SalesUnitPrice.TabIndex = 12;
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
            this.button5.Location = new System.Drawing.Point(818, 111);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 29);
            this.button5.TabIndex = 11;
            this.button5.Text = "删除";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(818, 76);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 29);
            this.button4.TabIndex = 10;
            this.button4.Text = "修改";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // InpAddSum
            // 
            this.InpAddSum.Location = new System.Drawing.Point(818, 41);
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
            // 采购单
            // 
            this.采购单.Controls.Add(this.DeliveryAddress);
            this.采购单.Controls.Add(this.label12);
            this.采购单.Controls.Add(this.button3);
            this.采购单.Controls.Add(this.CustomerName);
            this.采购单.Controls.Add(this.CustomerID);
            this.采购单.Controls.Add(this.label10);
            this.采购单.Controls.Add(this.label11);
            this.采购单.Controls.Add(this.SubTotal);
            this.采购单.Controls.Add(this.DeliveryDate);
            this.采购单.Controls.Add(this.button6);
            this.采购单.Controls.Add(this.SalesManName);
            this.采购单.Controls.Add(this.SalesManID);
            this.采购单.Controls.Add(this.DeliveryID);
            this.采购单.Controls.Add(this.label5);
            this.采购单.Controls.Add(this.label4);
            this.采购单.Controls.Add(this.label3);
            this.采购单.Controls.Add(this.label2);
            this.采购单.Controls.Add(this.label1);
            this.采购单.ForeColor = System.Drawing.Color.Blue;
            this.采购单.Location = new System.Drawing.Point(37, 29);
            this.采购单.Name = "采购单";
            this.采购单.Size = new System.Drawing.Size(996, 193);
            this.采购单.TabIndex = 5;
            this.采购单.TabStop = false;
            this.采购单.Text = "销售单信息";
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSize = true;
            this.SubTotal.ForeColor = System.Drawing.Color.Crimson;
            this.SubTotal.Location = new System.Drawing.Point(740, 121);
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Size = new System.Drawing.Size(0, 15);
            this.SubTotal.TabIndex = 11;
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.Location = new System.Drawing.Point(167, 81);
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.Size = new System.Drawing.Size(104, 25);
            this.DeliveryDate.TabIndex = 10;
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(499, 31);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(66, 26);
            this.button6.TabIndex = 9;
            this.button6.Text = "选择";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // SalesManName
            // 
            this.SalesManName.Location = new System.Drawing.Point(414, 75);
            this.SalesManName.Name = "SalesManName";
            this.SalesManName.Size = new System.Drawing.Size(151, 25);
            this.SalesManName.TabIndex = 8;
            // 
            // SalesManID
            // 
            this.SalesManID.Location = new System.Drawing.Point(414, 31);
            this.SalesManID.Name = "SalesManID";
            this.SalesManID.Size = new System.Drawing.Size(83, 25);
            this.SalesManID.TabIndex = 7;
            // 
            // DeliveryID
            // 
            this.DeliveryID.Location = new System.Drawing.Point(168, 30);
            this.DeliveryID.Name = "DeliveryID";
            this.DeliveryID.Size = new System.Drawing.Size(103, 25);
            this.DeliveryID.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(656, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "总金额：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(323, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "销售员姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(323, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "销售员编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(93, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "销售日期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(80, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "销售单编号";
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
            // SalesUnitPrice_Lie
            // 
            this.SalesUnitPrice_Lie.HeaderText = "单价";
            this.SalesUnitPrice_Lie.MinimumWidth = 6;
            this.SalesUnitPrice_Lie.Name = "SalesUnitPrice_Lie";
            this.SalesUnitPrice_Lie.Width = 125;
            // 
            // SalesQuantity_Lie
            // 
            this.SalesQuantity_Lie.HeaderText = "销售数量";
            this.SalesQuantity_Lie.MinimumWidth = 6;
            this.SalesQuantity_Lie.Name = "SalesQuantity_Lie";
            this.SalesQuantity_Lie.Width = 125;
            // 
            // SalesAmount_Lie
            // 
            this.SalesAmount_Lie.HeaderText = "金额";
            this.SalesAmount_Lie.MinimumWidth = 6;
            this.SalesAmount_Lie.Name = "SalesAmount_Lie";
            this.SalesAmount_Lie.Width = 125;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(817, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 26);
            this.button3.TabIndex = 16;
            this.button3.Text = "选择";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(732, 68);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(151, 25);
            this.CustomerName.TabIndex = 15;
            // 
            // CustomerID
            // 
            this.CustomerID.Location = new System.Drawing.Point(732, 24);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(83, 25);
            this.CustomerID.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(653, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "客户姓名";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(653, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "客户编号";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(95, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 17;
            this.label12.Text = "送货地址";
            // 
            // DeliveryAddress
            // 
            this.DeliveryAddress.Location = new System.Drawing.Point(168, 153);
            this.DeliveryAddress.Name = "DeliveryAddress";
            this.DeliveryAddress.Size = new System.Drawing.Size(715, 25);
            this.DeliveryAddress.TabIndex = 18;
            this.DeliveryAddress.TextChanged += new System.EventHandler(this.DeliveryAddress_TextChanged);
            // 
            // DeliveryDateOperateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 711);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeliveryDetailGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.采购单);
            this.Name = "DeliveryDateOperateForm";
            this.Text = "DeliveryDateOperateForm";
            this.Load += new System.EventHandler(this.DeliveryDateOperateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryDetailGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.采购单.ResumeLayout(false);
            this.采购单.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DeliveryDetailGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox SalesQuantity;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.TextBox SalesUnitPrice;
        private System.Windows.Forms.TextBox ProductID;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button InpAddSum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox 采购单;
        private System.Windows.Forms.Label SubTotal;
        private System.Windows.Forms.DateTimePicker DeliveryDate;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox SalesManName;
        private System.Windows.Forms.TextBox SalesManID;
        private System.Windows.Forms.TextBox DeliveryID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID_Lie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName_Lie;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesUnitPrice_Lie;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesQuantity_Lie;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesAmount_Lie;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.TextBox CustomerID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DeliveryAddress;
        private System.Windows.Forms.Label label12;
    }
}