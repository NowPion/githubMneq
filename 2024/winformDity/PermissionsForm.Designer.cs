
namespace winformDity
{
    partial class PermissionsForm
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
            this.treeTest = new System.Windows.Forms.TreeView();
            this.RoleGridView = new System.Windows.Forms.DataGridView();
            this.AddPit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RoleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // treeTest
            // 
            this.treeTest.CheckBoxes = true;
            this.treeTest.Location = new System.Drawing.Point(417, 12);
            this.treeTest.Name = "treeTest";
            this.treeTest.Size = new System.Drawing.Size(574, 796);
            this.treeTest.TabIndex = 8;
            this.treeTest.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeTest_AfterCheck);
            // 
            // RoleGridView
            // 
            this.RoleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoleGridView.Location = new System.Drawing.Point(12, 12);
            this.RoleGridView.Name = "RoleGridView";
            this.RoleGridView.RowHeadersWidth = 51;
            this.RoleGridView.RowTemplate.Height = 27;
            this.RoleGridView.Size = new System.Drawing.Size(399, 796);
            this.RoleGridView.TabIndex = 9;
            this.RoleGridView.Click += new System.EventHandler(this.RoleGridView_Click);
            // 
            // AddPit
            // 
            this.AddPit.Location = new System.Drawing.Point(1028, 42);
            this.AddPit.Name = "AddPit";
            this.AddPit.Size = new System.Drawing.Size(121, 54);
            this.AddPit.TabIndex = 10;
            this.AddPit.Text = "保存";
            this.AddPit.UseVisualStyleBackColor = true;
            this.AddPit.Click += new System.EventHandler(this.AddPit_Click);
            // 
            // PermissionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 818);
            this.Controls.Add(this.AddPit);
            this.Controls.Add(this.RoleGridView);
            this.Controls.Add(this.treeTest);
            this.Name = "PermissionsForm";
            this.Text = "PermissionsForm";
            this.Load += new System.EventHandler(this.PermissionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoleGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeTest;
        private System.Windows.Forms.DataGridView RoleGridView;
        private System.Windows.Forms.Button AddPit;
    }
}