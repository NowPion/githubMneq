
namespace winformDity
{
    partial class SupplierChooseForm
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
            this.select = new System.Windows.Forms.Button();
            this.SelectWhere = new System.Windows.Forms.TextBox();
            this.selectZho = new System.Windows.Forms.GroupBox();
            this.SupplierSimpleName = new System.Windows.Forms.RadioButton();
            this.SupplierID = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGridView)).BeginInit();
            this.selectZho.SuspendLayout();
            this.SuspendLayout();
            // 
            // SupplierGridView
            // 
            this.SupplierGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplierGridView.Location = new System.Drawing.Point(12, 111);
            this.SupplierGridView.Name = "SupplierGridView";
            this.SupplierGridView.RowHeadersWidth = 51;
            this.SupplierGridView.RowTemplate.Height = 27;
            this.SupplierGridView.Size = new System.Drawing.Size(1029, 472);
            this.SupplierGridView.TabIndex = 0;
            this.SupplierGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SupplierGridView_CellDoubleClick);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(672, 46);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(82, 37);
            this.select.TabIndex = 6;
            this.select.Text = "查询";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // SelectWhere
            // 
            this.SelectWhere.Location = new System.Drawing.Point(439, 53);
            this.SelectWhere.Name = "SelectWhere";
            this.SelectWhere.Size = new System.Drawing.Size(200, 25);
            this.SelectWhere.TabIndex = 5;
            // 
            // selectZho
            // 
            this.selectZho.Controls.Add(this.SupplierSimpleName);
            this.selectZho.Controls.Add(this.SupplierID);
            this.selectZho.Location = new System.Drawing.Point(166, 31);
            this.selectZho.Name = "selectZho";
            this.selectZho.Size = new System.Drawing.Size(267, 58);
            this.selectZho.TabIndex = 4;
            this.selectZho.TabStop = false;
            this.selectZho.Text = "查询条件";
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
            // SupplierChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 595);
            this.Controls.Add(this.select);
            this.Controls.Add(this.SelectWhere);
            this.Controls.Add(this.selectZho);
            this.Controls.Add(this.SupplierGridView);
            this.Name = "SupplierChooseForm";
            this.Text = "SupplierChooseForm";
            this.Load += new System.EventHandler(this.SupplierChooseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SupplierGridView)).EndInit();
            this.selectZho.ResumeLayout(false);
            this.selectZho.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SupplierGridView;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.TextBox SelectWhere;
        private System.Windows.Forms.GroupBox selectZho;
        private System.Windows.Forms.RadioButton SupplierSimpleName;
        private System.Windows.Forms.RadioButton SupplierID;
    }
}