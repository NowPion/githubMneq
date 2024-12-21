
namespace winformDity
{
    partial class SalesManForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.SalesManGridView = new System.Windows.Forms.DataGridView();
            this.SalesManIdView = new System.Windows.Forms.TextBox();
            this.ChineseNameView = new System.Windows.Forms.TextBox();
            this.EnglishNameView = new System.Windows.Forms.TextBox();
            this.TellePhoneView = new System.Windows.Forms.TextBox();
            this.MobilePhoneView = new System.Windows.Forms.TextBox();
            this.EmailView = new System.Windows.Forms.TextBox();
            this.SalesManIdLable = new System.Windows.Forms.Label();
            this.ChineseNameLable = new System.Windows.Forms.Label();
            this.MobilePhoneLabel = new System.Windows.Forms.Label();
            this.EnglishNameLabel = new System.Windows.Forms.Label();
            this.TellePhoneLabel = new System.Windows.Forms.Label();
            this.ContractAddressLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.ContractAddressView = new System.Windows.Forms.RichTextBox();
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delect = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SalesManGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesManGridView
            // 
            this.SalesManGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesManGridView.Location = new System.Drawing.Point(12, 12);
            this.SalesManGridView.Name = "SalesManGridView";
            this.SalesManGridView.RowHeadersWidth = 51;
            this.SalesManGridView.RowTemplate.Height = 27;
            this.SalesManGridView.Size = new System.Drawing.Size(1025, 233);
            this.SalesManGridView.TabIndex = 0;
            this.SalesManGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesManGridView_CellContentClick);
            this.SalesManGridView.Click += new System.EventHandler(this.SalesManGridView_Click);
            // 
            // SalesManIdView
            // 
            this.SalesManIdView.Location = new System.Drawing.Point(296, 281);
            this.SalesManIdView.Name = "SalesManIdView";
            this.SalesManIdView.Size = new System.Drawing.Size(107, 25);
            this.SalesManIdView.TabIndex = 1;
            // 
            // ChineseNameView
            // 
            this.ChineseNameView.Location = new System.Drawing.Point(296, 336);
            this.ChineseNameView.Name = "ChineseNameView";
            this.ChineseNameView.Size = new System.Drawing.Size(107, 25);
            this.ChineseNameView.TabIndex = 2;
            // 
            // EnglishNameView
            // 
            this.EnglishNameView.Location = new System.Drawing.Point(515, 291);
            this.EnglishNameView.Name = "EnglishNameView";
            this.EnglishNameView.Size = new System.Drawing.Size(100, 25);
            this.EnglishNameView.TabIndex = 3;
            // 
            // TellePhoneView
            // 
            this.TellePhoneView.Location = new System.Drawing.Point(515, 345);
            this.TellePhoneView.Name = "TellePhoneView";
            this.TellePhoneView.Size = new System.Drawing.Size(100, 25);
            this.TellePhoneView.TabIndex = 4;
            // 
            // MobilePhoneView
            // 
            this.MobilePhoneView.Location = new System.Drawing.Point(296, 399);
            this.MobilePhoneView.Name = "MobilePhoneView";
            this.MobilePhoneView.Size = new System.Drawing.Size(107, 25);
            this.MobilePhoneView.TabIndex = 5;
            // 
            // EmailView
            // 
            this.EmailView.Location = new System.Drawing.Point(515, 402);
            this.EmailView.Name = "EmailView";
            this.EmailView.Size = new System.Drawing.Size(159, 25);
            this.EmailView.TabIndex = 7;
            // 
            // SalesManIdLable
            // 
            this.SalesManIdLable.AutoSize = true;
            this.SalesManIdLable.Location = new System.Drawing.Point(193, 291);
            this.SalesManIdLable.Name = "SalesManIdLable";
            this.SalesManIdLable.Size = new System.Drawing.Size(82, 15);
            this.SalesManIdLable.TabIndex = 8;
            this.SalesManIdLable.Text = "销售员编号";
            // 
            // ChineseNameLable
            // 
            this.ChineseNameLable.AutoSize = true;
            this.ChineseNameLable.Location = new System.Drawing.Point(208, 348);
            this.ChineseNameLable.Name = "ChineseNameLable";
            this.ChineseNameLable.Size = new System.Drawing.Size(67, 15);
            this.ChineseNameLable.TabIndex = 9;
            this.ChineseNameLable.Text = "中文姓名";
            // 
            // MobilePhoneLabel
            // 
            this.MobilePhoneLabel.AutoSize = true;
            this.MobilePhoneLabel.Location = new System.Drawing.Point(208, 409);
            this.MobilePhoneLabel.Name = "MobilePhoneLabel";
            this.MobilePhoneLabel.Size = new System.Drawing.Size(67, 15);
            this.MobilePhoneLabel.TabIndex = 10;
            this.MobilePhoneLabel.Text = "手机号码";
            // 
            // EnglishNameLabel
            // 
            this.EnglishNameLabel.AutoSize = true;
            this.EnglishNameLabel.Location = new System.Drawing.Point(442, 301);
            this.EnglishNameLabel.Name = "EnglishNameLabel";
            this.EnglishNameLabel.Size = new System.Drawing.Size(67, 15);
            this.EnglishNameLabel.TabIndex = 11;
            this.EnglishNameLabel.Text = "英文姓名";
            // 
            // TellePhoneLabel
            // 
            this.TellePhoneLabel.AutoSize = true;
            this.TellePhoneLabel.Location = new System.Drawing.Point(454, 355);
            this.TellePhoneLabel.Name = "TellePhoneLabel";
            this.TellePhoneLabel.Size = new System.Drawing.Size(37, 15);
            this.TellePhoneLabel.TabIndex = 12;
            this.TellePhoneLabel.Text = "座机";
            // 
            // ContractAddressLabel
            // 
            this.ContractAddressLabel.AutoSize = true;
            this.ContractAddressLabel.Location = new System.Drawing.Point(650, 294);
            this.ContractAddressLabel.Name = "ContractAddressLabel";
            this.ContractAddressLabel.Size = new System.Drawing.Size(67, 15);
            this.ContractAddressLabel.TabIndex = 13;
            this.ContractAddressLabel.Text = "联系地址";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(424, 412);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(67, 15);
            this.EmailLabel.TabIndex = 14;
            this.EmailLabel.Text = "电子邮箱";
            // 
            // ContractAddressView
            // 
            this.ContractAddressView.Location = new System.Drawing.Point(723, 294);
            this.ContractAddressView.Name = "ContractAddressView";
            this.ContractAddressView.Size = new System.Drawing.Size(116, 130);
            this.ContractAddressView.TabIndex = 15;
            this.ContractAddressView.Text = "";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(647, 492);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(86, 35);
            this.add.TabIndex = 16;
            this.add.Text = "插入";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(317, 492);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(86, 35);
            this.update.TabIndex = 17;
            this.update.Text = "修改";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delect
            // 
            this.delect.Location = new System.Drawing.Point(423, 492);
            this.delect.Name = "delect";
            this.delect.Size = new System.Drawing.Size(86, 35);
            this.delect.TabIndex = 19;
            this.delect.Text = "删除";
            this.delect.UseVisualStyleBackColor = true;
            this.delect.Click += new System.EventHandler(this.delect_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(530, 492);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(86, 35);
            this.exit.TabIndex = 20;
            this.exit.Text = "退出";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // SalesManForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 643);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.delect);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.ContractAddressView);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.ContractAddressLabel);
            this.Controls.Add(this.TellePhoneLabel);
            this.Controls.Add(this.EnglishNameLabel);
            this.Controls.Add(this.MobilePhoneLabel);
            this.Controls.Add(this.ChineseNameLable);
            this.Controls.Add(this.SalesManIdLable);
            this.Controls.Add(this.EmailView);
            this.Controls.Add(this.MobilePhoneView);
            this.Controls.Add(this.TellePhoneView);
            this.Controls.Add(this.EnglishNameView);
            this.Controls.Add(this.ChineseNameView);
            this.Controls.Add(this.SalesManIdView);
            this.Controls.Add(this.SalesManGridView);
            this.Name = "SalesManForm";
            this.Text = "销售员资料";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesManGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SalesManGridView;
        private System.Windows.Forms.TextBox SalesManIdView;
        private System.Windows.Forms.TextBox ChineseNameView;
        private System.Windows.Forms.TextBox EnglishNameView;
        private System.Windows.Forms.TextBox TellePhoneView;
        private System.Windows.Forms.TextBox MobilePhoneView;
        private System.Windows.Forms.TextBox EmailView;
        private System.Windows.Forms.Label SalesManIdLable;
        private System.Windows.Forms.Label ChineseNameLable;
        private System.Windows.Forms.Label MobilePhoneLabel;
        private System.Windows.Forms.Label EnglishNameLabel;
        private System.Windows.Forms.Label TellePhoneLabel;
        private System.Windows.Forms.Label ContractAddressLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.RichTextBox ContractAddressView;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delect;
        private System.Windows.Forms.Button exit;
    }
}

