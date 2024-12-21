
namespace winformDity
{
    partial class SupplierForm
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
            this.SupplierGridView = new System.Windows.Forms.DataGridView();
            this.SupplierID = new System.Windows.Forms.RadioButton();
            this.SupplierSimpleName = new System.Windows.Forms.RadioButton();
            this.selectZho = new System.Windows.Forms.GroupBox();
            this.select = new System.Windows.Forms.Button();
            this.SelectWhere = new System.Windows.Forms.TextBox();
            this.SupplierIDlabel = new System.Windows.Forms.Label();
            this.SupplierSimpleNamelabel = new System.Windows.Forms.Label();
            this.SupplierNamelabel = new System.Windows.Forms.Label();
            this.SupplierIDView = new System.Windows.Forms.TextBox();
            this.SupplierSimpleNameView = new System.Windows.Forms.TextBox();
            this.SupplierNameView = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.delect = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.Ownerlabel = new System.Windows.Forms.Label();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.Telephonelabel = new System.Windows.Forms.Label();
            this.MobilePhonelabel = new System.Windows.Forms.Label();
            this.Faxlabel = new System.Windows.Forms.Label();
            this.CompanyAddresslabel = new System.Windows.Forms.Label();
            this.OwnerView = new System.Windows.Forms.TextBox();
            this.TelephoneView = new System.Windows.Forms.TextBox();
            this.MobilePhoneView = new System.Windows.Forms.TextBox();
            this.FaxView = new System.Windows.Forms.TextBox();
            this.CompanyAddressView = new System.Windows.Forms.TextBox();
            this.FactoryAddresslabel = new System.Windows.Forms.Label();
            this.LastDeliveryDatelabel = new System.Windows.Forms.Label();
            this.FactoryAddressView = new System.Windows.Forms.TextBox();
            this.LastDeliveryDateView = new System.Windows.Forms.TextBox();
            this.TitleView = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGridView)).BeginInit();
            this.selectZho.SuspendLayout();
            this.SuspendLayout();
            // 
            // SupplierGridView
            // 
            this.SupplierGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplierGridView.Location = new System.Drawing.Point(12, 82);
            this.SupplierGridView.Name = "SupplierGridView";
            this.SupplierGridView.RowHeadersWidth = 51;
            this.SupplierGridView.RowTemplate.Height = 27;
            this.SupplierGridView.Size = new System.Drawing.Size(1017, 208);
            this.SupplierGridView.TabIndex = 0;
            this.SupplierGridView.Click += new System.EventHandler(this.SupplierGridView_Click);
            // 
            // SupplierID
            // 
            this.SupplierID.AutoSize = true;
            this.SupplierID.Checked = true;
            this.SupplierID.Location = new System.Drawing.Point(6, 24);
            this.SupplierID.Name = "SupplierID";
            this.SupplierID.Size = new System.Drawing.Size(103, 19);
            this.SupplierID.TabIndex = 0;
            this.SupplierID.TabStop = true;
            this.SupplierID.Text = "供应商编号";
            this.SupplierID.UseVisualStyleBackColor = true;
            this.SupplierID.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // SupplierSimpleName
            // 
            this.SupplierSimpleName.AutoSize = true;
            this.SupplierSimpleName.Location = new System.Drawing.Point(137, 23);
            this.SupplierSimpleName.Name = "SupplierSimpleName";
            this.SupplierSimpleName.Size = new System.Drawing.Size(103, 19);
            this.SupplierSimpleName.TabIndex = 1;
            this.SupplierSimpleName.Text = "供应商简称";
            this.SupplierSimpleName.UseVisualStyleBackColor = true;
            this.SupplierSimpleName.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // selectZho
            // 
            this.selectZho.Controls.Add(this.SupplierSimpleName);
            this.selectZho.Controls.Add(this.SupplierID);
            this.selectZho.Location = new System.Drawing.Point(264, 24);
            this.selectZho.Name = "selectZho";
            this.selectZho.Size = new System.Drawing.Size(267, 52);
            this.selectZho.TabIndex = 1;
            this.selectZho.TabStop = false;
            this.selectZho.Text = "查询条件";
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(801, 33);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(82, 37);
            this.select.TabIndex = 3;
            this.select.Text = "查询";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // SelectWhere
            // 
            this.SelectWhere.Location = new System.Drawing.Point(553, 41);
            this.SelectWhere.Name = "SelectWhere";
            this.SelectWhere.Size = new System.Drawing.Size(200, 25);
            this.SelectWhere.TabIndex = 2;
            // 
            // SupplierIDlabel
            // 
            this.SupplierIDlabel.AutoSize = true;
            this.SupplierIDlabel.Location = new System.Drawing.Point(165, 314);
            this.SupplierIDlabel.Name = "SupplierIDlabel";
            this.SupplierIDlabel.Size = new System.Drawing.Size(82, 15);
            this.SupplierIDlabel.TabIndex = 4;
            this.SupplierIDlabel.Text = "供应商编号";
            // 
            // SupplierSimpleNamelabel
            // 
            this.SupplierSimpleNamelabel.AutoSize = true;
            this.SupplierSimpleNamelabel.Location = new System.Drawing.Point(165, 356);
            this.SupplierSimpleNamelabel.Name = "SupplierSimpleNamelabel";
            this.SupplierSimpleNamelabel.Size = new System.Drawing.Size(82, 15);
            this.SupplierSimpleNamelabel.TabIndex = 5;
            this.SupplierSimpleNamelabel.Text = "供应商简称";
            // 
            // SupplierNamelabel
            // 
            this.SupplierNamelabel.AutoSize = true;
            this.SupplierNamelabel.Location = new System.Drawing.Point(165, 401);
            this.SupplierNamelabel.Name = "SupplierNamelabel";
            this.SupplierNamelabel.Size = new System.Drawing.Size(82, 15);
            this.SupplierNamelabel.TabIndex = 6;
            this.SupplierNamelabel.Text = "供应商全称";
            // 
            // SupplierIDView
            // 
            this.SupplierIDView.Location = new System.Drawing.Point(276, 309);
            this.SupplierIDView.Name = "SupplierIDView";
            this.SupplierIDView.Size = new System.Drawing.Size(100, 25);
            this.SupplierIDView.TabIndex = 7;
            // 
            // SupplierSimpleNameView
            // 
            this.SupplierSimpleNameView.Location = new System.Drawing.Point(276, 354);
            this.SupplierSimpleNameView.Name = "SupplierSimpleNameView";
            this.SupplierSimpleNameView.Size = new System.Drawing.Size(100, 25);
            this.SupplierSimpleNameView.TabIndex = 8;
            // 
            // SupplierNameView
            // 
            this.SupplierNameView.Location = new System.Drawing.Point(276, 396);
            this.SupplierNameView.Name = "SupplierNameView";
            this.SupplierNameView.Size = new System.Drawing.Size(142, 25);
            this.SupplierNameView.TabIndex = 9;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(553, 541);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(86, 35);
            this.exit.TabIndex = 24;
            this.exit.Text = "退出";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // delect
            // 
            this.delect.Location = new System.Drawing.Point(417, 541);
            this.delect.Name = "delect";
            this.delect.Size = new System.Drawing.Size(86, 35);
            this.delect.TabIndex = 23;
            this.delect.Text = "删除";
            this.delect.UseVisualStyleBackColor = true;
            this.delect.Click += new System.EventHandler(this.delect_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(264, 541);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(86, 35);
            this.update.TabIndex = 22;
            this.update.Text = "修改";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(680, 541);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(86, 35);
            this.add.TabIndex = 21;
            this.add.Text = "插入";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Ownerlabel
            // 
            this.Ownerlabel.AutoSize = true;
            this.Ownerlabel.Location = new System.Drawing.Point(466, 311);
            this.Ownerlabel.Name = "Ownerlabel";
            this.Ownerlabel.Size = new System.Drawing.Size(52, 15);
            this.Ownerlabel.TabIndex = 25;
            this.Ownerlabel.Text = "负责人";
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Location = new System.Drawing.Point(466, 355);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(82, 15);
            this.Titlelabel.TabIndex = 26;
            this.Titlelabel.Text = "负责人称谓";
            // 
            // Telephonelabel
            // 
            this.Telephonelabel.AutoSize = true;
            this.Telephonelabel.Location = new System.Drawing.Point(466, 400);
            this.Telephonelabel.Name = "Telephonelabel";
            this.Telephonelabel.Size = new System.Drawing.Size(37, 15);
            this.Telephonelabel.TabIndex = 27;
            this.Telephonelabel.Text = "座机";
            // 
            // MobilePhonelabel
            // 
            this.MobilePhonelabel.AutoSize = true;
            this.MobilePhonelabel.Location = new System.Drawing.Point(698, 313);
            this.MobilePhonelabel.Name = "MobilePhonelabel";
            this.MobilePhonelabel.Size = new System.Drawing.Size(37, 15);
            this.MobilePhonelabel.TabIndex = 28;
            this.MobilePhonelabel.Text = "手机";
            // 
            // Faxlabel
            // 
            this.Faxlabel.AutoSize = true;
            this.Faxlabel.Location = new System.Drawing.Point(698, 355);
            this.Faxlabel.Name = "Faxlabel";
            this.Faxlabel.Size = new System.Drawing.Size(37, 15);
            this.Faxlabel.TabIndex = 29;
            this.Faxlabel.Text = "传真";
            // 
            // CompanyAddresslabel
            // 
            this.CompanyAddresslabel.AutoSize = true;
            this.CompanyAddresslabel.Location = new System.Drawing.Point(165, 451);
            this.CompanyAddresslabel.Name = "CompanyAddresslabel";
            this.CompanyAddresslabel.Size = new System.Drawing.Size(67, 15);
            this.CompanyAddresslabel.TabIndex = 30;
            this.CompanyAddresslabel.Text = "公司地址";
            // 
            // OwnerView
            // 
            this.OwnerView.Location = new System.Drawing.Point(555, 306);
            this.OwnerView.Name = "OwnerView";
            this.OwnerView.Size = new System.Drawing.Size(100, 25);
            this.OwnerView.TabIndex = 31;
            // 
            // TelephoneView
            // 
            this.TelephoneView.Location = new System.Drawing.Point(554, 389);
            this.TelephoneView.Name = "TelephoneView";
            this.TelephoneView.Size = new System.Drawing.Size(100, 25);
            this.TelephoneView.TabIndex = 33;
            // 
            // MobilePhoneView
            // 
            this.MobilePhoneView.Location = new System.Drawing.Point(783, 306);
            this.MobilePhoneView.Name = "MobilePhoneView";
            this.MobilePhoneView.Size = new System.Drawing.Size(100, 25);
            this.MobilePhoneView.TabIndex = 34;
            // 
            // FaxView
            // 
            this.FaxView.Location = new System.Drawing.Point(783, 351);
            this.FaxView.Name = "FaxView";
            this.FaxView.Size = new System.Drawing.Size(100, 25);
            this.FaxView.TabIndex = 35;
            // 
            // CompanyAddressView
            // 
            this.CompanyAddressView.Location = new System.Drawing.Point(276, 446);
            this.CompanyAddressView.Name = "CompanyAddressView";
            this.CompanyAddressView.Size = new System.Drawing.Size(607, 25);
            this.CompanyAddressView.TabIndex = 36;
            // 
            // FactoryAddresslabel
            // 
            this.FactoryAddresslabel.AutoSize = true;
            this.FactoryAddresslabel.Location = new System.Drawing.Point(167, 499);
            this.FactoryAddresslabel.Name = "FactoryAddresslabel";
            this.FactoryAddresslabel.Size = new System.Drawing.Size(67, 15);
            this.FactoryAddresslabel.TabIndex = 37;
            this.FactoryAddresslabel.Text = "工厂地址";
            // 
            // LastDeliveryDatelabel
            // 
            this.LastDeliveryDatelabel.AutoSize = true;
            this.LastDeliveryDatelabel.Location = new System.Drawing.Point(669, 397);
            this.LastDeliveryDatelabel.Name = "LastDeliveryDatelabel";
            this.LastDeliveryDatelabel.Size = new System.Drawing.Size(97, 15);
            this.LastDeliveryDatelabel.TabIndex = 38;
            this.LastDeliveryDatelabel.Text = "最后送货日期";
            // 
            // FactoryAddressView
            // 
            this.FactoryAddressView.Location = new System.Drawing.Point(276, 493);
            this.FactoryAddressView.Name = "FactoryAddressView";
            this.FactoryAddressView.Size = new System.Drawing.Size(607, 25);
            this.FactoryAddressView.TabIndex = 39;
            // 
            // LastDeliveryDateView
            // 
            this.LastDeliveryDateView.Location = new System.Drawing.Point(783, 393);
            this.LastDeliveryDateView.Name = "LastDeliveryDateView";
            this.LastDeliveryDateView.Size = new System.Drawing.Size(100, 25);
            this.LastDeliveryDateView.TabIndex = 40;
            // 
            // TitleView
            // 
            this.TitleView.FormattingEnabled = true;
            this.TitleView.Location = new System.Drawing.Point(553, 351);
            this.TitleView.Name = "TitleView";
            this.TitleView.Size = new System.Drawing.Size(101, 23);
            this.TitleView.TabIndex = 41;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 588);
            this.Controls.Add(this.TitleView);
            this.Controls.Add(this.LastDeliveryDateView);
            this.Controls.Add(this.FactoryAddressView);
            this.Controls.Add(this.LastDeliveryDatelabel);
            this.Controls.Add(this.FactoryAddresslabel);
            this.Controls.Add(this.CompanyAddressView);
            this.Controls.Add(this.FaxView);
            this.Controls.Add(this.MobilePhoneView);
            this.Controls.Add(this.TelephoneView);
            this.Controls.Add(this.OwnerView);
            this.Controls.Add(this.CompanyAddresslabel);
            this.Controls.Add(this.Faxlabel);
            this.Controls.Add(this.MobilePhonelabel);
            this.Controls.Add(this.Telephonelabel);
            this.Controls.Add(this.Titlelabel);
            this.Controls.Add(this.Ownerlabel);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.delect);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.SupplierNameView);
            this.Controls.Add(this.SupplierSimpleNameView);
            this.Controls.Add(this.SupplierIDView);
            this.Controls.Add(this.SupplierNamelabel);
            this.Controls.Add(this.SupplierSimpleNamelabel);
            this.Controls.Add(this.SupplierIDlabel);
            this.Controls.Add(this.select);
            this.Controls.Add(this.SelectWhere);
            this.Controls.Add(this.selectZho);
            this.Controls.Add(this.SupplierGridView);
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            this.Load += new System.EventHandler(this.SupplierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGridView)).EndInit();
            this.selectZho.ResumeLayout(false);
            this.selectZho.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SupplierGridView;
        private System.Windows.Forms.RadioButton SupplierID;
        private System.Windows.Forms.RadioButton SupplierSimpleName;
        private System.Windows.Forms.GroupBox selectZho;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.TextBox SelectWhere;
        private System.Windows.Forms.Label SupplierIDlabel;
        private System.Windows.Forms.Label SupplierSimpleNamelabel;
        private System.Windows.Forms.Label SupplierNamelabel;
        private System.Windows.Forms.TextBox SupplierIDView;
        private System.Windows.Forms.TextBox SupplierSimpleNameView;
        private System.Windows.Forms.TextBox SupplierNameView;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button delect;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label Ownerlabel;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.Label Telephonelabel;
        private System.Windows.Forms.Label MobilePhonelabel;
        private System.Windows.Forms.Label Faxlabel;
        private System.Windows.Forms.Label CompanyAddresslabel;
        private System.Windows.Forms.TextBox OwnerView;
        private System.Windows.Forms.TextBox TelephoneView;
        private System.Windows.Forms.TextBox MobilePhoneView;
        private System.Windows.Forms.TextBox FaxView;
        private System.Windows.Forms.TextBox CompanyAddressView;
        private System.Windows.Forms.Label FactoryAddresslabel;
        private System.Windows.Forms.Label LastDeliveryDatelabel;
        private System.Windows.Forms.TextBox FactoryAddressView;
        private System.Windows.Forms.TextBox LastDeliveryDateView;
        private System.Windows.Forms.ComboBox TitleView;
    }
}