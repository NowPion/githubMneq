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
    public partial class DeliveryMasterForm : Form
    {
        static int DeliveryProperty = 1;
        string DeliveryID = "";
        public DeliveryMasterForm()
        {
            InitializeComponent();
        }

        private void DeliveryMasterForm_Load(object sender, EventArgs e)
        {
            DeliveryMasterList();
        }

        void DeliveryMasterList()
        {
            DeliveryMasterGridView.DataSource = new DeliveryMasterService().GetDeliveryMasterList(DeliveryProperty);
            DeliveryMasterGridView.Columns["CustomerID"].Visible = false;
            DeliveryMasterGridView.Columns["DeliveryProperty"].Visible = false;
            DeliveryMasterGridView.Columns["SalesManID"].Visible = false;
            DeliveryMasterGridView.Columns["DeliveryDetail"].Visible = false;
        }

        private void DeliveryMasterGridView_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
       DeliveryMasterGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0)
            {
                int index = 0;
                for (int i = 0; i < selectedRowCount; i++)
                {
                    index = DeliveryMasterGridView.SelectedRows[i].Index;
                }
                DeliveryID = DeliveryMasterGridView.Rows[index].Cells[0].Value.ToString();
                DeliveryDetail(DeliveryID);
            }
        }
        void DeliveryDetail(string DeliveryID)
        {
            DeliveryDetailGridView.DataSource = new DeliveryDetailService().GetDeliveryDetailList(DeliveryID);
            if (DeliveryDetailGridView.DataSource != null)
            {
            DeliveryDetailGridView.Columns["DeliverydetailID"].Visible = false;
            DeliveryDetailGridView.Columns["DeliveryID"].Visible = false;
            }
           
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (DeliveryID != "")
            {
                ThisXing.Text = "";
                new DeliveryDateOperateForm(DeliveryID).ShowDialog();
                DeliveryMasterList();
                DeliveryDetail(DeliveryID);
            }
            else
            {
                ThisXing.Text = "选择销售单信息！！！";
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            new DeliveryDateOperateForm(null).ShowDialog();
            DeliveryMasterList();
        }
    }
}
