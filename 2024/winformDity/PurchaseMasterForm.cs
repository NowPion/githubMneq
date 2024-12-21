using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using NewBLL;

namespace winformDity
{
    public partial class PurchaseMasterForm : Form
    {
        static int PurchaseProperty = 1;
        string PurchaseID = "";
        public PurchaseMasterForm()
        {
            InitializeComponent();
        }
        private void PurchaseMasterForm_Load(object sender, EventArgs e)
        {
            PurchaseMasterList();
        }

        void PurchaseMasterList()
        {
            PurchaseMasterGridView.DataSource = new PurchaseMasterService().GetPurchaseMasterList(PurchaseProperty);
            PurchaseMasterGridView.Columns["SupplierID"].Visible = false;
        }
        void PurchaseDetail(string PurchaseID)
        {
            //MessageBox.Show(PurchaseID);
            PurchaseDetailGridView.DataSource = new PurchaseDetailService().GetPurchaseDetailList(PurchaseID);
            PurchaseDetailGridView.Columns["ProductID"].Visible = false;
        }
        private void PurchaseMasterGridView_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
           PurchaseMasterGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0)
            {
                int index = 0;
                for (int i = 0; i < selectedRowCount; i++)
                {
                    index = PurchaseMasterGridView.SelectedRows[i].Index;
                }
                PurchaseID = PurchaseMasterGridView.Rows[index].Cells[0].Value.ToString();
                PurchaseDetail(PurchaseID);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            new PurchaseDateOperateForm().ShowDialog();
            PurchaseMasterList();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if(PurchaseID != "")
            {
                ThisXing.Text = "";
                new PurchaseDateOperateForm(PurchaseID, true).ShowDialog();
                PurchaseMasterList();
                PurchaseDetail(PurchaseID);
            }
            else
            {
                ThisXing.Text = "选择采购单信息！！！";
            }
        }

        private void delect_Click(object sender, EventArgs e)
        {

        }
    }
}
