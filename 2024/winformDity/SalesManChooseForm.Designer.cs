
namespace winformDity
{
    partial class SalesManChooseForm
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
            this.SalesManGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SalesManGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesManGridView
            // 
            this.SalesManGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesManGridView.Location = new System.Drawing.Point(24, 24);
            this.SalesManGridView.Name = "SalesManGridView";
            this.SalesManGridView.RowHeadersWidth = 51;
            this.SalesManGridView.RowTemplate.Height = 27;
            this.SalesManGridView.Size = new System.Drawing.Size(1025, 394);
            this.SalesManGridView.TabIndex = 1;
            this.SalesManGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesManGridView_CellDoubleClick);
            // 
            // SalesManChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 578);
            this.Controls.Add(this.SalesManGridView);
            this.Name = "SalesManChooseForm";
            this.Text = "SalesManChooseForm";
            this.Load += new System.EventHandler(this.SalesManChooseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesManGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SalesManGridView;
    }
}