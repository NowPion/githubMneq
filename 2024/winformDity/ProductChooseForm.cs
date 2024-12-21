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
    public partial class ProductChooseForm : Form
    {
        public ProductChooseForm()
        {
            InitializeComponent();
        }

        private void ProductChooseForm_Load(object sender, EventArgs e)
        {
            ProductList();
        }

        void ProductList()
        {
            ProductGridView.DataSource = new ProductService().GetProductList();
        }

        private void ProductGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount =
                  ProductGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0)
            {
                //StringBuilder sb = new StringBuilder();
                int index = 0;
                for (int i = 0; i < selectedRowCount; i++)
                {
                    index = ProductGridView.SelectedRows[i].Index;
                }
                //MessageBox.Show(ProductGridView.Rows[index].Cells[0].Value.ToString());
                StaticById.ProductID = ProductGridView.Rows[index].Cells[0].Value.ToString();
                Close();
                
            }
        }
    }
}
