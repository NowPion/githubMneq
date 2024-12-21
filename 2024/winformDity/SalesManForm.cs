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
    public partial class SalesManForm : Form
    {
    
        public SalesManForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SalesManList();
        }
        void SalesManList()
        {
            //IList<SalesMan> salesMen = new SalesManService().GetSalesManList();
            SalesManGridView.DataSource = new SalesManService().GetSalesManList();
            //textBox.Text = salesMen[0].SalesManID;
        }
        void ScanDateView(SalesMan saleman)
        {
            SalesManIdView.Text = saleman.SalesManID;
            ChineseNameView.Text = saleman.ChineseName;
            MobilePhoneView.Text = saleman.MobilePhone;
            EnglishNameView.Text = saleman.EnglishName;
            TellePhoneView.Text = saleman.TellePhone;
            EmailView.Text = saleman.Email;
            ContractAddressView.Text = saleman.ContractAddress;
        }
        SalesMan PrinDateView()
        {
            SalesMan salesmanItem = new SalesMan();
            salesmanItem.SalesManID = SalesManIdView.Text;
            salesmanItem.ChineseName = ChineseNameView.Text;
            salesmanItem.MobilePhone = MobilePhoneView.Text;
            salesmanItem.EnglishName = EnglishNameView.Text;
            salesmanItem.TellePhone = TellePhoneView.Text;
            salesmanItem.Email = EmailView.Text;
            salesmanItem.ContractAddress = ContractAddressView.Text;
            return salesmanItem;
        }
        private void SalesManGridView_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
             SalesManGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0)
            {
           
                int index = 0;
                for (int i = 0; i < selectedRowCount; i++)
                {
                    index = SalesManGridView.SelectedRows[i].Index;
                }
                ScanDateView(new SalesManService().GetBySalesManID(SalesManGridView.Rows[index].Cells[0].Value.ToString()));
            }

        }

        private void update_Click(object sender, EventArgs e)
        {
            SalesMan salesMan = PrinDateView();
            bool staut = new SalesManService().UpdataSalesMan(salesMan);
            if (staut)
            {
                MessageBox.Show("操作成功！");
                SalesManList();
            }
            else
            {
                MessageBox.Show("操作失败！");
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            SalesMan salesMan = PrinDateView();
            bool staut = new SalesManService().InputSalesMan(salesMan);
            if (staut)
            {
                MessageBox.Show("操作成功！");
                SalesManList();
            }
            else
            {
                MessageBox.Show("操作失败！");
            }
        }

        private void delect_Click(object sender, EventArgs e)
        {
            SalesMan salesMan = PrinDateView();
            bool staut = new SalesManService().DelectSalesMan(salesMan);
            if (staut)
            {
                MessageBox.Show("操作成功！");
                SalesManList();
            }
            else
            {
                MessageBox.Show("操作失败！");
            }
        }

        private void SalesManGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //
    }
}
