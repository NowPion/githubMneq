
namespace winformDity
{
    partial class PurchaseMasterForm
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
            this.produtchesMasterView = new System.Windows.Forms.GroupBox();
            this.PurchaseMasterGridView = new System.Windows.Forms.DataGridView();
            this.PurchaseDetailView = new System.Windows.Forms.GroupBox();
            this.PurchaseDetailGridView = new System.Windows.Forms.DataGridView();
            this.exit = new System.Windows.Forms.Button();
            this.delect = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.ThisXing = new System.Windows.Forms.Label();
            this.produtchesMasterView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseMasterGridView)).BeginInit();
            this.PurchaseDetailView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseDetailGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // produtchesMasterView
            // 
            this.produtchesMasterView.Controls.Add(this.PurchaseMasterGridView);
            this.produtchesMasterView.ForeColor = System.Drawing.Color.Blue;
            this.produtchesMasterView.Location = new System.Drawing.Point(12, 12);
            this.produtchesMasterView.Name = "produtchesMasterView";
            this.produtchesMasterView.Size = new System.Drawing.Size(1028, 286);
            this.produtchesMasterView.TabIndex = 0;
            this.produtchesMasterView.TabStop = false;
            this.produtchesMasterView.Text = "采购单一览";
            // 
            // PurchaseMasterGridView
            // 
            this.PurchaseMasterGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PurchaseMasterGridView.Location = new System.Drawing.Point(6, 24);
            this.PurchaseMasterGridView.Name = "PurchaseMasterGridView";
            this.PurchaseMasterGridView.RowHeadersWidth = 51;
            this.PurchaseMasterGridView.RowTemplate.Height = 27;
            this.PurchaseMasterGridView.Size = new System.Drawing.Size(1016, 256);
            this.PurchaseMasterGridView.TabIndex = 0;
            this.PurchaseMasterGridView.Click += new System.EventHandler(this.PurchaseMasterGridView_Click);
            // 
            // PurchaseDetailView
            // 
            this.PurchaseDetailView.Controls.Add(this.PurchaseDetailGridView);
            this.PurchaseDetailView.ForeColor = System.Drawing.Color.Blue;
            this.PurchaseDetailView.Location = new System.Drawing.Point(12, 304);
            this.PurchaseDetailView.Name = "PurchaseDetailView";
            this.PurchaseDetailView.Size = new System.Drawing.Size(1028, 217);
            this.PurchaseDetailView.TabIndex = 1;
            this.PurchaseDetailView.TabStop = false;
            this.PurchaseDetailView.Text = "采购单明细一览";
            // 
            // PurchaseDetailGridView
            // 
            this.PurchaseDetailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PurchaseDetailGridView.Location = new System.Drawing.Point(6, 24);
            this.PurchaseDetailGridView.Name = "PurchaseDetailGridView";
            this.PurchaseDetailGridView.RowHeadersWidth = 51;
            this.PurchaseDetailGridView.RowTemplate.Height = 27;
            this.PurchaseDetailGridView.Size = new System.Drawing.Size(1016, 174);
            this.PurchaseDetailGridView.TabIndex = 1;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(948, 561);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(86, 35);
            this.exit.TabIndex = 24;
            this.exit.Text = "退出";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // delect
            // 
            this.delect.Location = new System.Drawing.Point(856, 561);
            this.delect.Name = "delect";
            this.delect.Size = new System.Drawing.Size(86, 35);
            this.delect.TabIndex = 23;
            this.delect.Text = "删除";
            this.delect.UseVisualStyleBackColor = true;
            this.delect.Click += new System.EventHandler(this.delect_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(764, 561);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(86, 35);
            this.update.TabIndex = 22;
            this.update.Text = "修改";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(672, 561);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(86, 35);
            this.add.TabIndex = 21;
            this.add.Text = "插入";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // ThisXing
            // 
            this.ThisXing.AutoSize = true;
            this.ThisXing.Font = new System.Drawing.Font("宋体", 15F);
            this.ThisXing.ForeColor = System.Drawing.Color.Red;
            this.ThisXing.Location = new System.Drawing.Point(256, 581);
            this.ThisXing.Name = "ThisXing";
            this.ThisXing.Size = new System.Drawing.Size(0, 25);
            this.ThisXing.TabIndex = 25;
            // 
            // PurchaseMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 643);
            this.Controls.Add(this.ThisXing);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.delect);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.PurchaseDetailView);
            this.Controls.Add(this.produtchesMasterView);
            this.Name = "PurchaseMasterForm";
            this.Text = "PurchaseMasterForm";
            this.Load += new System.EventHandler(this.PurchaseMasterForm_Load);
            this.produtchesMasterView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseMasterGridView)).EndInit();
            this.PurchaseDetailView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseDetailGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox produtchesMasterView;
        private System.Windows.Forms.DataGridView PurchaseMasterGridView;
        private System.Windows.Forms.GroupBox PurchaseDetailView;
        private System.Windows.Forms.DataGridView PurchaseDetailGridView;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button delect;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label ThisXing;
    }
}