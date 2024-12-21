using NewBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformDity
{
    public partial class SupplierChooseForm : Form
    {
        public static int Select_Staut = -1;
        public static int Select_Aing = -1;
        public SupplierChooseForm()
        {
            InitializeComponent();
        }

        private void SupplierChooseForm_Load(object sender, EventArgs e)
        {
            SupplierList();
        }
        void SupplierList()
        {
            SupplierGridView.DataSource = new SupplierService().GetSupplierList(Select_Aing, SelectWhere.Text);
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbn = sender as RadioButton;
            if (rbn.Checked)
            {
                string Tag = rbn.Text;
                if (Tag == "供应商编号")
                {
                    Select_Staut = 0;
                }
                else
                {
                    Select_Staut = 1;
                }
            }
        }


        private void select_Click(object sender, EventArgs e)
        {
                Select_Aing = Select_Staut;
                if (SelectWhere.Text == "")
            {
                Select_Aing = -1;
            }
                SupplierList();   
        }

        private void SupplierGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount =
SupplierGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0)
            {
                //StringBuilder sb = new StringBuilder();
                int index = 0;
                for (int i = 0; i < selectedRowCount; i++)
                {
                    index = SupplierGridView.SelectedRows[i].Index;
                }

                StaticById.SupplierID = SupplierGridView.Rows[index].Cells[0].Value.ToString();
                Close();
                //MessageBox.Show(SupplierGridView.Rows[index].Cells[0].Value.ToString());
            }
        }
    }
}
