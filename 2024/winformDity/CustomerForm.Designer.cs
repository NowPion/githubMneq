
namespace winformDity
{
    partial class CustomerForm
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
            this.CustomerGridView = new System.Windows.Forms.DataGridView();
            this.SalesManBycomboBox = new System.Windows.Forms.ComboBox();
            this.CustomerSimpleNamelabel = new System.Windows.Forms.Label();
            this.Owner = new System.Windows.Forms.Label();
            this.CustomerIDlabel = new System.Windows.Forms.Label();
            this.Fax = new System.Windows.Forms.Label();
            this.SalesManName = new System.Windows.Forms.Label();
            this.MobilePhone = new System.Windows.Forms.Label();
            this.LastDeliveryDate = new System.Windows.Forms.Label();
            this.CustomerAddress = new System.Windows.Forms.Label();
            this.DeliveryAddress = new System.Windows.Forms.Label();
            this.CustomerNamelabel = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Telephone = new System.Windows.Forms.Label();
            this.InvoiceAddress = new System.Windows.Forms.Label();
            this.CustomerIDView = new System.Windows.Forms.TextBox();
            this.CustomerSimpleNameView = new System.Windows.Forms.TextBox();
            this.OwnerView = new System.Windows.Forms.TextBox();
            this.CustomerNameView = new System.Windows.Forms.TextBox();
            this.TitleView = new System.Windows.Forms.TextBox();
            this.TelephoneView = new System.Windows.Forms.TextBox();
            this.MobilePhoneView = new System.Windows.Forms.TextBox();
            this.FaxView = new System.Windows.Forms.TextBox();
            this.LastDeliveryDateView = new System.Windows.Forms.TextBox();
            this.CustomerAddressView = new System.Windows.Forms.TextBox();
            this.DeliveryAddressView = new System.Windows.Forms.TextBox();
            this.InvoiceAddressView = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.delect = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerGridView
            // 
            this.CustomerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGridView.Location = new System.Drawing.Point(12, 12);
            this.CustomerGridView.Name = "CustomerGridView";
            this.CustomerGridView.RowHeadersWidth = 51;
            this.CustomerGridView.RowTemplate.Height = 27;
            this.CustomerGridView.Size = new System.Drawing.Size(1030, 245);
            this.CustomerGridView.TabIndex = 0;
            this.CustomerGridView.Click += new System.EventHandler(this.CustomerGridView_Click);
            // 
            // SalesManBycomboBox
            // 
            this.SalesManBycomboBox.FormattingEnabled = true;
            this.SalesManBycomboBox.Location = new System.Drawing.Point(464, 392);
            this.SalesManBycomboBox.Name = "SalesManBycomboBox";
            this.SalesManBycomboBox.Size = new System.Drawing.Size(121, 23);
            this.SalesManBycomboBox.TabIndex = 1;
            // 
            // CustomerSimpleNamelabel
            // 
            this.CustomerSimpleNamelabel.AutoSize = true;
            this.CustomerSimpleNamelabel.Location = new System.Drawing.Point(60, 315);
            this.CustomerSimpleNamelabel.Name = "CustomerSimpleNamelabel";
            this.CustomerSimpleNamelabel.Size = new System.Drawing.Size(97, 15);
            this.CustomerSimpleNamelabel.TabIndex = 2;
            this.CustomerSimpleNamelabel.Text = "客户公司简称";
            // 
            // Owner
            // 
            this.Owner.AutoSize = true;
            this.Owner.Location = new System.Drawing.Point(60, 396);
            this.Owner.Name = "Owner";
            this.Owner.Size = new System.Drawing.Size(82, 15);
            this.Owner.TabIndex = 3;
            this.Owner.Text = "负责人姓名";
            // 
            // CustomerIDlabel
            // 
            this.CustomerIDlabel.AutoSize = true;
            this.CustomerIDlabel.Location = new System.Drawing.Point(60, 280);
            this.CustomerIDlabel.Name = "CustomerIDlabel";
            this.CustomerIDlabel.Size = new System.Drawing.Size(67, 15);
            this.CustomerIDlabel.TabIndex = 4;
            this.CustomerIDlabel.Text = "客户编号";
            // 
            // Fax
            // 
            this.Fax.AutoSize = true;
            this.Fax.Location = new System.Drawing.Point(393, 355);
            this.Fax.Name = "Fax";
            this.Fax.Size = new System.Drawing.Size(37, 15);
            this.Fax.TabIndex = 5;
            this.Fax.Text = "传真";
            // 
            // SalesManName
            // 
            this.SalesManName.AutoSize = true;
            this.SalesManName.Location = new System.Drawing.Point(387, 396);
            this.SalesManName.Name = "SalesManName";
            this.SalesManName.Size = new System.Drawing.Size(52, 15);
            this.SalesManName.TabIndex = 6;
            this.SalesManName.Text = "销售员";
            // 
            // MobilePhone
            // 
            this.MobilePhone.AutoSize = true;
            this.MobilePhone.Location = new System.Drawing.Point(393, 315);
            this.MobilePhone.Name = "MobilePhone";
            this.MobilePhone.Size = new System.Drawing.Size(37, 15);
            this.MobilePhone.TabIndex = 7;
            this.MobilePhone.Text = "手机";
            this.MobilePhone.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LastDeliveryDate
            // 
            this.LastDeliveryDate.AutoSize = true;
            this.LastDeliveryDate.Location = new System.Drawing.Point(342, 437);
            this.LastDeliveryDate.Name = "LastDeliveryDate";
            this.LastDeliveryDate.Size = new System.Drawing.Size(97, 15);
            this.LastDeliveryDate.TabIndex = 8;
            this.LastDeliveryDate.Text = "最后交易时间";
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.AutoSize = true;
            this.CustomerAddress.Location = new System.Drawing.Point(60, 493);
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.Size = new System.Drawing.Size(97, 15);
            this.CustomerAddress.TabIndex = 9;
            this.CustomerAddress.Text = "客户联系地址";
            // 
            // DeliveryAddress
            // 
            this.DeliveryAddress.AutoSize = true;
            this.DeliveryAddress.Location = new System.Drawing.Point(60, 533);
            this.DeliveryAddress.Name = "DeliveryAddress";
            this.DeliveryAddress.Size = new System.Drawing.Size(67, 15);
            this.DeliveryAddress.TabIndex = 10;
            this.DeliveryAddress.Text = "送货地址";
            // 
            // CustomerNamelabel
            // 
            this.CustomerNamelabel.AutoSize = true;
            this.CustomerNamelabel.Location = new System.Drawing.Point(60, 355);
            this.CustomerNamelabel.Name = "CustomerNamelabel";
            this.CustomerNamelabel.Size = new System.Drawing.Size(97, 15);
            this.CustomerNamelabel.TabIndex = 11;
            this.CustomerNamelabel.Text = "客户公司名称";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(60, 437);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(82, 15);
            this.Title.TabIndex = 12;
            this.Title.Text = "负责人称谓";
            // 
            // Telephone
            // 
            this.Telephone.AutoSize = true;
            this.Telephone.Location = new System.Drawing.Point(393, 280);
            this.Telephone.Name = "Telephone";
            this.Telephone.Size = new System.Drawing.Size(37, 15);
            this.Telephone.TabIndex = 13;
            this.Telephone.Text = "座机";
            // 
            // InvoiceAddress
            // 
            this.InvoiceAddress.AutoSize = true;
            this.InvoiceAddress.Location = new System.Drawing.Point(60, 568);
            this.InvoiceAddress.Name = "InvoiceAddress";
            this.InvoiceAddress.Size = new System.Drawing.Size(82, 15);
            this.InvoiceAddress.TabIndex = 14;
            this.InvoiceAddress.Text = "开发票地址";
            // 
            // CustomerIDView
            // 
            this.CustomerIDView.Location = new System.Drawing.Point(178, 280);
            this.CustomerIDView.Name = "CustomerIDView";
            this.CustomerIDView.Size = new System.Drawing.Size(123, 25);
            this.CustomerIDView.TabIndex = 15;
            // 
            // CustomerSimpleNameView
            // 
            this.CustomerSimpleNameView.Location = new System.Drawing.Point(178, 312);
            this.CustomerSimpleNameView.Name = "CustomerSimpleNameView";
            this.CustomerSimpleNameView.Size = new System.Drawing.Size(123, 25);
            this.CustomerSimpleNameView.TabIndex = 16;
            // 
            // OwnerView
            // 
            this.OwnerView.Location = new System.Drawing.Point(178, 390);
            this.OwnerView.Name = "OwnerView";
            this.OwnerView.Size = new System.Drawing.Size(123, 25);
            this.OwnerView.TabIndex = 17;
            // 
            // CustomerNameView
            // 
            this.CustomerNameView.Location = new System.Drawing.Point(178, 352);
            this.CustomerNameView.Name = "CustomerNameView";
            this.CustomerNameView.Size = new System.Drawing.Size(123, 25);
            this.CustomerNameView.TabIndex = 18;
            // 
            // TitleView
            // 
            this.TitleView.Location = new System.Drawing.Point(178, 427);
            this.TitleView.Name = "TitleView";
            this.TitleView.Size = new System.Drawing.Size(123, 25);
            this.TitleView.TabIndex = 19;
            // 
            // TelephoneView
            // 
            this.TelephoneView.Location = new System.Drawing.Point(462, 280);
            this.TelephoneView.Name = "TelephoneView";
            this.TelephoneView.Size = new System.Drawing.Size(123, 25);
            this.TelephoneView.TabIndex = 20;
            // 
            // MobilePhoneView
            // 
            this.MobilePhoneView.Location = new System.Drawing.Point(462, 315);
            this.MobilePhoneView.Name = "MobilePhoneView";
            this.MobilePhoneView.Size = new System.Drawing.Size(123, 25);
            this.MobilePhoneView.TabIndex = 21;
            // 
            // FaxView
            // 
            this.FaxView.Location = new System.Drawing.Point(464, 352);
            this.FaxView.Name = "FaxView";
            this.FaxView.Size = new System.Drawing.Size(123, 25);
            this.FaxView.TabIndex = 22;
            // 
            // LastDeliveryDateView
            // 
            this.LastDeliveryDateView.Location = new System.Drawing.Point(462, 434);
            this.LastDeliveryDateView.Name = "LastDeliveryDateView";
            this.LastDeliveryDateView.Size = new System.Drawing.Size(123, 25);
            this.LastDeliveryDateView.TabIndex = 23;
            // 
            // CustomerAddressView
            // 
            this.CustomerAddressView.Location = new System.Drawing.Point(178, 493);
            this.CustomerAddressView.Name = "CustomerAddressView";
            this.CustomerAddressView.Size = new System.Drawing.Size(409, 25);
            this.CustomerAddressView.TabIndex = 24;
            // 
            // DeliveryAddressView
            // 
            this.DeliveryAddressView.Location = new System.Drawing.Point(178, 530);
            this.DeliveryAddressView.Name = "DeliveryAddressView";
            this.DeliveryAddressView.Size = new System.Drawing.Size(409, 25);
            this.DeliveryAddressView.TabIndex = 25;
            // 
            // InvoiceAddressView
            // 
            this.InvoiceAddressView.Location = new System.Drawing.Point(178, 564);
            this.InvoiceAddressView.Name = "InvoiceAddressView";
            this.InvoiceAddressView.Size = new System.Drawing.Size(407, 25);
            this.InvoiceAddressView.TabIndex = 26;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(741, 481);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(86, 35);
            this.exit.TabIndex = 30;
            this.exit.Text = "退出";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // delect
            // 
            this.delect.Location = new System.Drawing.Point(847, 420);
            this.delect.Name = "delect";
            this.delect.Size = new System.Drawing.Size(86, 35);
            this.delect.TabIndex = 29;
            this.delect.Text = "删除";
            this.delect.UseVisualStyleBackColor = true;
            this.delect.Click += new System.EventHandler(this.delect_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(741, 420);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(86, 35);
            this.update.TabIndex = 28;
            this.update.Text = "修改";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(847, 481);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(86, 35);
            this.add.TabIndex = 27;
            this.add.Text = "插入";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(743, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 31;
            this.button1.Text = "导出数据";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 639);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.delect);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.InvoiceAddressView);
            this.Controls.Add(this.DeliveryAddressView);
            this.Controls.Add(this.CustomerAddressView);
            this.Controls.Add(this.LastDeliveryDateView);
            this.Controls.Add(this.FaxView);
            this.Controls.Add(this.MobilePhoneView);
            this.Controls.Add(this.TelephoneView);
            this.Controls.Add(this.TitleView);
            this.Controls.Add(this.CustomerNameView);
            this.Controls.Add(this.OwnerView);
            this.Controls.Add(this.CustomerSimpleNameView);
            this.Controls.Add(this.CustomerIDView);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.CustomerNamelabel);
            this.Controls.Add(this.CustomerIDlabel);
            this.Controls.Add(this.Owner);
            this.Controls.Add(this.CustomerSimpleNamelabel);
            this.Controls.Add(this.InvoiceAddress);
            this.Controls.Add(this.Telephone);
            this.Controls.Add(this.DeliveryAddress);
            this.Controls.Add(this.CustomerAddress);
            this.Controls.Add(this.LastDeliveryDate);
            this.Controls.Add(this.MobilePhone);
            this.Controls.Add(this.SalesManName);
            this.Controls.Add(this.Fax);
            this.Controls.Add(this.SalesManBycomboBox);
            this.Controls.Add(this.CustomerGridView);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.Click += new System.EventHandler(this.CustomerForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerGridView;
        private System.Windows.Forms.ComboBox SalesManBycomboBox;
        private System.Windows.Forms.Label CustomerSimpleNamelabel;
        private System.Windows.Forms.Label Owner;
        private System.Windows.Forms.Label CustomerIDlabel;
        private System.Windows.Forms.Label Fax;
        private System.Windows.Forms.Label SalesManName;
        private System.Windows.Forms.Label MobilePhone;
        private System.Windows.Forms.Label LastDeliveryDate;
        private System.Windows.Forms.Label CustomerAddress;
        private System.Windows.Forms.Label DeliveryAddress;
        private System.Windows.Forms.Label CustomerNamelabel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Telephone;
        private System.Windows.Forms.Label InvoiceAddress;
        private System.Windows.Forms.TextBox CustomerIDView;
        private System.Windows.Forms.TextBox CustomerSimpleNameView;
        private System.Windows.Forms.TextBox OwnerView;
        private System.Windows.Forms.TextBox CustomerNameView;
        private System.Windows.Forms.TextBox TitleView;
        private System.Windows.Forms.TextBox TelephoneView;
        private System.Windows.Forms.TextBox MobilePhoneView;
        private System.Windows.Forms.TextBox FaxView;
        private System.Windows.Forms.TextBox LastDeliveryDateView;
        private System.Windows.Forms.TextBox CustomerAddressView;
        private System.Windows.Forms.TextBox DeliveryAddressView;
        private System.Windows.Forms.TextBox InvoiceAddressView;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button delect;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button1;
    }
}