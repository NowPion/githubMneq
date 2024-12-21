
namespace winformDity
{
    partial class ProductForm
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
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.ProductIDlabel = new System.Windows.Forms.Label();
            this.SafeStocklabel = new System.Windows.Forms.Label();
            this.SuggestSalePricelabel = new System.Windows.Forms.Label();
            this.SuggestBuyPricelabel = new System.Windows.Forms.Label();
            this.ProductNamelabel = new System.Windows.Forms.Label();
            this.ProductID = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.SafeStock = new System.Windows.Forms.TextBox();
            this.SuggestBuyPrice = new System.Windows.Forms.TextBox();
            this.SuggestSalePrice = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.delect = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductGridView
            // 
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.Location = new System.Drawing.Point(15, 12);
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.RowHeadersWidth = 51;
            this.ProductGridView.RowTemplate.Height = 27;
            this.ProductGridView.Size = new System.Drawing.Size(1025, 283);
            this.ProductGridView.TabIndex = 1;
            this.ProductGridView.Click += new System.EventHandler(this.ProductGridView_Click);
            // 
            // ProductIDlabel
            // 
            this.ProductIDlabel.AutoSize = true;
            this.ProductIDlabel.Location = new System.Drawing.Point(26, 341);
            this.ProductIDlabel.Name = "ProductIDlabel";
            this.ProductIDlabel.Size = new System.Drawing.Size(67, 15);
            this.ProductIDlabel.TabIndex = 2;
            this.ProductIDlabel.Text = "商品编号";
            // 
            // SafeStocklabel
            // 
            this.SafeStocklabel.AutoSize = true;
            this.SafeStocklabel.Location = new System.Drawing.Point(26, 413);
            this.SafeStocklabel.Name = "SafeStocklabel";
            this.SafeStocklabel.Size = new System.Drawing.Size(67, 15);
            this.SafeStocklabel.TabIndex = 3;
            this.SafeStocklabel.Text = "安全库存";
            // 
            // SuggestSalePricelabel
            // 
            this.SuggestSalePricelabel.AutoSize = true;
            this.SuggestSalePricelabel.Location = new System.Drawing.Point(26, 490);
            this.SuggestSalePricelabel.Name = "SuggestSalePricelabel";
            this.SuggestSalePricelabel.Size = new System.Drawing.Size(97, 15);
            this.SuggestSalePricelabel.TabIndex = 4;
            this.SuggestSalePricelabel.Text = "建议销售价格";
            // 
            // SuggestBuyPricelabel
            // 
            this.SuggestBuyPricelabel.AutoSize = true;
            this.SuggestBuyPricelabel.Location = new System.Drawing.Point(26, 449);
            this.SuggestBuyPricelabel.Name = "SuggestBuyPricelabel";
            this.SuggestBuyPricelabel.Size = new System.Drawing.Size(97, 15);
            this.SuggestBuyPricelabel.TabIndex = 5;
            this.SuggestBuyPricelabel.Text = "建议进货价格";
            // 
            // ProductNamelabel
            // 
            this.ProductNamelabel.AutoSize = true;
            this.ProductNamelabel.Location = new System.Drawing.Point(26, 375);
            this.ProductNamelabel.Name = "ProductNamelabel";
            this.ProductNamelabel.Size = new System.Drawing.Size(67, 15);
            this.ProductNamelabel.TabIndex = 6;
            this.ProductNamelabel.Text = "商品名称";
            // 
            // ProductID
            // 
            this.ProductID.Location = new System.Drawing.Point(142, 338);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(114, 25);
            this.ProductID.TabIndex = 7;
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(142, 372);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(114, 25);
            this.ProductName.TabIndex = 8;
            // 
            // SafeStock
            // 
            this.SafeStock.Location = new System.Drawing.Point(142, 410);
            this.SafeStock.Name = "SafeStock";
            this.SafeStock.Size = new System.Drawing.Size(114, 25);
            this.SafeStock.TabIndex = 9;
            // 
            // SuggestBuyPrice
            // 
            this.SuggestBuyPrice.Location = new System.Drawing.Point(142, 444);
            this.SuggestBuyPrice.Name = "SuggestBuyPrice";
            this.SuggestBuyPrice.Size = new System.Drawing.Size(114, 25);
            this.SuggestBuyPrice.TabIndex = 10;
            // 
            // SuggestSalePrice
            // 
            this.SuggestSalePrice.Location = new System.Drawing.Point(142, 481);
            this.SuggestSalePrice.Name = "SuggestSalePrice";
            this.SuggestSalePrice.Size = new System.Drawing.Size(114, 25);
            this.SuggestSalePrice.TabIndex = 11;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(443, 469);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(86, 35);
            this.exit.TabIndex = 24;
            this.exit.Text = "退出";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // delect
            // 
            this.delect.Location = new System.Drawing.Point(443, 410);
            this.delect.Name = "delect";
            this.delect.Size = new System.Drawing.Size(86, 35);
            this.delect.TabIndex = 23;
            this.delect.Text = "删除";
            this.delect.UseVisualStyleBackColor = true;
            this.delect.Click += new System.EventHandler(this.delect_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(334, 410);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(86, 35);
            this.update.TabIndex = 22;
            this.update.Text = "修改";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(334, 472);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(86, 35);
            this.add.TabIndex = 21;
            this.add.Text = "插入";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 643);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.delect);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.SuggestSalePrice);
            this.Controls.Add(this.SuggestBuyPrice);
            this.Controls.Add(this.SafeStock);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.ProductID);
            this.Controls.Add(this.ProductNamelabel);
            this.Controls.Add(this.SuggestBuyPricelabel);
            this.Controls.Add(this.SuggestSalePricelabel);
            this.Controls.Add(this.SafeStocklabel);
            this.Controls.Add(this.ProductIDlabel);
            this.Controls.Add(this.ProductGridView);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductGridView;
        private System.Windows.Forms.Label ProductIDlabel;
        private System.Windows.Forms.Label SafeStocklabel;
        private System.Windows.Forms.Label SuggestSalePricelabel;
        private System.Windows.Forms.Label SuggestBuyPricelabel;
        private System.Windows.Forms.Label ProductNamelabel;
        private System.Windows.Forms.TextBox ProductID;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.TextBox SafeStock;
        private System.Windows.Forms.TextBox SuggestBuyPrice;
        private System.Windows.Forms.TextBox SuggestSalePrice;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button delect;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
    }
}