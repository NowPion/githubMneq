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
    public partial class CustomerChooseFrom : Form
    {
        public CustomerChooseFrom()
        {
            InitializeComponent();
        }

        private void CustomerChooseFrom_Load(object sender, EventArgs e)
        {
            CustomerGridView.DataSource = new CustomerService().GetCustomerList();
        }

        private void CustomerGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount =
         CustomerGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0)
            {
                //StringBuilder sb = new StringBuilder();
                int index = 0;
                for (int i = 0; i < selectedRowCount; i++)
                {
                    index = CustomerGridView.SelectedRows[i].Index;
                }

                StaticById.CustomerID = CustomerGridView.Rows[index].Cells[0].Value.ToString();
                Close();
                //MessageBox.Show(SupplierGridView.Rows[index].Cells[0].Value.ToString());
            }
        }
    }
}
