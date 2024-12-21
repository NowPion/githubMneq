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
    public partial class SalesManChooseForm : Form
    {
        public SalesManChooseForm()
        {
            InitializeComponent();
        }

        private void SalesManChooseForm_Load(object sender, EventArgs e)
        {
            SalesManGridView.DataSource = new SalesManService().GetSalesManList();
        }

        private void SalesManGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount =
         SalesManGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0)
            {
                //StringBuilder sb = new StringBuilder();
                int index = 0;
                for (int i = 0; i < selectedRowCount; i++)
                {
                    index = SalesManGridView.SelectedRows[i].Index;
                }

                StaticById.SalesManID = SalesManGridView.Rows[index].Cells[0].Value.ToString();
                Close();
                //MessageBox.Show(SupplierGridView.Rows[index].Cells[0].Value.ToString());
            }
        }
    }
}
