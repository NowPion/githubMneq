
namespace winformDity
{
    partial class DeliveryMasterForm
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
            this.ThisXing = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.delect = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.PurchaseDetailView = new System.Windows.Forms.GroupBox();
            this.DeliveryDetailGridView = new System.Windows.Forms.DataGridView();
            this.produtchesMasterView = new System.Windows.Forms.GroupBox();
            this.DeliveryMasterGridView = new System.Windows.Forms.DataGridView();
            this.PurchaseDetailView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryDetailGridView)).BeginInit();
            this.produtchesMasterView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryMasterGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ThisXing
            // 
            this.ThisXing.AutoSize = true;
            this.ThisXing.Font = new System.Drawing.Font("宋体", 15F);
            this.ThisXing.ForeColor = System.Drawing.Color.Red;
            this.ThisXing.Location = new System.Drawing.Point(256, 596);
            this.ThisXing.Name = "ThisXing";
            this.ThisXing.Size = new System.Drawing.Size(0, 25);
            this.ThisXing.TabIndex = 32;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(955, 576);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(86, 35);
            this.exit.TabIndex = 31;
            this.exit.Text = "退出";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // delect
            // 
            this.delect.Location = new System.Drawing.Point(856, 576);
            this.delect.Name = "delect";
            this.delect.Size = new System.Drawing.Size(86, 35);
            this.delect.TabIndex = 30;
            this.delect.Text = "删除";
            this.delect.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(764, 576);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(86, 35);
            this.update.TabIndex = 29;
            this.update.Text = "修改";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(672, 576);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(86, 35);
            this.add.TabIndex = 28;
            this.add.Text = "插入";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // PurchaseDetailView
            // 
            this.PurchaseDetailView.Controls.Add(this.DeliveryDetailGridView);
            this.PurchaseDetailView.ForeColor = System.Drawing.Color.Blue;
            this.PurchaseDetailView.Location = new System.Drawing.Point(12, 319);
            this.PurchaseDetailView.Name = "PurchaseDetailView";
            this.PurchaseDetailView.Size = new System.Drawing.Size(1028, 217);
            this.PurchaseDetailView.TabIndex = 27;
            this.PurchaseDetailView.TabStop = false;
            this.PurchaseDetailView.Text = "销售单明细一览";
            // 
            // DeliveryDetailGridView
            // 
            this.DeliveryDetailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeliveryDetailGridView.Location = new System.Drawing.Point(6, 24);
            this.DeliveryDetailGridView.Name = "DeliveryDetailGridView";
            this.DeliveryDetailGridView.RowHeadersWidth = 51;
            this.DeliveryDetailGridView.RowTemplate.Height = 27;
            this.DeliveryDetailGridView.Size = new System.Drawing.Size(1016, 174);
            this.DeliveryDetailGridView.TabIndex = 1;
            // 
            // produtchesMasterView
            // 
            this.produtchesMasterView.Controls.Add(this.DeliveryMasterGridView);
            this.produtchesMasterView.ForeColor = System.Drawing.Color.Blue;
            this.produtchesMasterView.Location = new System.Drawing.Point(12, 27);
            this.produtchesMasterView.Name = "produtchesMasterView";
            this.produtchesMasterView.Size = new System.Drawing.Size(1028, 286);
            this.produtchesMasterView.TabIndex = 26;
            this.produtchesMasterView.TabStop = false;
            this.produtchesMasterView.Text = "销售单一览";
            // 
            // DeliveryMasterGridView
            // 
            this.DeliveryMasterGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeliveryMasterGridView.Location = new System.Drawing.Point(6, 24);
            this.DeliveryMasterGridView.Name = "DeliveryMasterGridView";
            this.DeliveryMasterGridView.RowHeadersWidth = 51;
            this.DeliveryMasterGridView.RowTemplate.Height = 27;
            this.DeliveryMasterGridView.Size = new System.Drawing.Size(1016, 256);
            this.DeliveryMasterGridView.TabIndex = 0;
            this.DeliveryMasterGridView.Click += new System.EventHandler(this.DeliveryMasterGridView_Click);
            // 
            // DeliveryMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 648);
            this.Controls.Add(this.ThisXing);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.delect);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Controls.Add(this.PurchaseDetailView);
            this.Controls.Add(this.produtchesMasterView);
            this.Name = "DeliveryMasterForm";
            this.Text = "DeliveryMasterForm";
            this.Load += new System.EventHandler(this.DeliveryMasterForm_Load);
            this.PurchaseDetailView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryDetailGridView)).EndInit();
            this.produtchesMasterView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryMasterGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ThisXing;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button delect;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.GroupBox PurchaseDetailView;
        private System.Windows.Forms.DataGridView DeliveryDetailGridView;
        private System.Windows.Forms.GroupBox produtchesMasterView;
        private System.Windows.Forms.DataGridView DeliveryMasterGridView;
    }
}