using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using NewBLL;
using NPOI.SS.UserModel;

namespace winformDity
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            ProductList();
        }
        void ProductList()
        {
            ProductGridView.DataSource = new ProductService().GetProductList();
        }

        void ScanDateView(Product product)
        {
            ProductID.Text = product.ProductID;
            ProductName.Text = product.ProductName;
            SafeStock.Text = product.SafeStock.ToString();
            SuggestBuyPrice.Text = product.SuggestBuyPrice.ToString();
            SuggestSalePrice.Text = product.SuggestSalePrice.ToString();
        }

        Product PrinDateView()
        {
            Product product = new Product();
            product.ProductID = ProductID.Text;
            product.ProductName = ProductName.Text;
            product.SafeStock = Convert.ToInt32(SafeStock.Text);
            product.SuggestBuyPrice = Convert.ToDecimal(SuggestBuyPrice.Text);
            product.SuggestSalePrice = Convert.ToDecimal(SuggestSalePrice.Text);
            return product;
        }

        private void ProductGridView_Click(object sender, EventArgs e)
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
                //MessageBox.Show(CustomerGridView.Rows[index].Cells[0].Value.ToString());
                ScanDateView(new ProductService().GetByProductID(ProductGridView.Rows[index].Cells[0].Value.ToString()));

            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            bool staus = new ProductService().UpdataProduct(PrinDateView());
            if (staus)
            {
                MessageBox.Show("操作成功！");
                ProductList();
            }
            else
            {
                MessageBox.Show("操作失败！");
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            bool staus = new ProductService().InputProduct(PrinDateView());
            if (staus)
            {
                MessageBox.Show("操作成功！");
                ProductList();
            }
            else
            {
                MessageBox.Show("操作失败！");
            }
        }

        private void delect_Click(object sender, EventArgs e)
        {
            bool staus = new ProductService().DelectProduct(PrinDateView());
            if (staus)
            {
                MessageBox.Show("操作成功！");
                ProductList();
            }
            else
            {
                MessageBox.Show("操作失败！");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1423");
        }



    }
}
