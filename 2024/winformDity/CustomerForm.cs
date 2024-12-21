using Models;
using NewBLL;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
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

namespace winformDity
{
    public partial class CustomerForm : Form
    {
        
        Dictionary<string, string> SalesMandictionary = new Dictionary<string, string>();
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            CustomerList();
            ComBgVelut();
        }

        void ComBgVelut()
        {
            IList<SalesMan> salesMenList = new SalesManService().GetSalesManList();
            foreach(SalesMan salesMan in salesMenList)
            {
                SalesManBycomboBox.Items.Add(salesMan.ChineseName);
                SalesMandictionary.Add(salesMan.ChineseName, salesMan.SalesManID);
            }
        }

        void CustomerList()
        {
            CustomerGridView.DataSource = new CustomerService().GetCustomerList();
            CustomerGridView.Columns["SalesManId"].Visible = false;
            //SalesManBycomboBox
        }
        void ScanDateView(Customer customer)
        {
            CustomerIDView.Text = customer.CustomerID;
            CustomerSimpleNameView.Text = customer.CustomerSimpleName;
            CustomerNameView.Text = customer.CustomerName;
            OwnerView.Text = customer.Owner;
            TitleView.Text = customer.Title;
            TelephoneView.Text = customer.Telephone;
            MobilePhoneView.Text = customer.MobilePhone;
            FaxView.Text = customer.Fax;
            CustomerAddressView.Text = customer.CustomerAddress;
            DeliveryAddressView.Text = customer.DeliveryAddress;
            InvoiceAddressView.Text = customer.InvoiceAddress;
            LastDeliveryDateView.Text = customer.LastDeliveryDate.ToString();
            //SalesManBycomboBox.SelectedIndex
            for (int index = 0; index < SalesMandictionary.Count; index++)
            {
                KeyValuePair<string, string> item = SalesMandictionary.ElementAt(index);
                if(customer.SalesManId == item.Value)
                {
                    SalesManBycomboBox.SelectedIndex = index;
                    break;
                }
            }
        }

        Customer PrinDateView()
        {
            Customer customer = new Customer();
            customer.CustomerID = CustomerIDView.Text;
            customer.CustomerSimpleName = CustomerSimpleNameView.Text;
            customer.CustomerName = CustomerNameView.Text;
            customer.Owner = OwnerView.Text;
            customer.Title = TitleView.Text;
            customer.Telephone = TelephoneView.Text;
            customer.MobilePhone = MobilePhoneView.Text;
            customer.Fax = FaxView.Text;
            customer.CustomerAddress = CustomerAddressView.Text;
            customer.DeliveryAddress = DeliveryAddressView.Text;
            customer.InvoiceAddress = InvoiceAddressView.Text;
            customer.LastDeliveryDate = Convert.ToDateTime(LastDeliveryDateView.Text);
            customer.SalesManId = SalesMandictionary[SalesManBycomboBox.SelectedItem.ToString()];
            return customer;
        }


        private void CustomerGridView_Click(object sender, EventArgs e)
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
                //MessageBox.Show(CustomerGridView.Rows[index].Cells[0].Value.ToString());
                ScanDateView(new CustomerService().GetByCustomerID(CustomerGridView.Rows[index].Cells[0].Value.ToString()));

            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            bool staus = new CustomerService().UpdataCustomer(PrinDateView());
            if (staus)
            {
                MessageBox.Show("操作成功！");
                CustomerList();
            }
            else
            {
                MessageBox.Show("操作失败！");
            }
        }

        private void delect_Click(object sender, EventArgs e)
        {
            bool staus = new CustomerService().DelectCustomer(PrinDateView());
            if (staus)
            {
                MessageBox.Show("操作成功！");
                CustomerList();
            }
            else
            {
                MessageBox.Show("操作失败！");
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            bool staus = new CustomerService().InputCustomer(PrinDateView());
            if (staus)
            {
                MessageBox.Show("操作成功！");
                CustomerList();
            }
            else
            {
                MessageBox.Show("操作失败！");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();

            // 添加列
            foreach (DataGridViewColumn column in CustomerGridView.Columns)
            {
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }

            // 添加行
            foreach (DataGridViewRow row in CustomerGridView.Rows)
            {
                DataRow dr = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dr[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dr);
            }

            TConvert(dt, @"E:\exels");
        }




        public  void TConvert(DataTable dt, string filePath)
        {
            // 创建一个新的Excel工作簿
            IWorkbook workbook = new XSSFWorkbook();

            // 创建一个新的工作表并命名为“Sheet1”
            ISheet worksheet = workbook.CreateSheet("Sheet1");

            // 将DataTable的列名写入工作表中
            IRow headerRow = worksheet.CreateRow(0);
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                ICell cell = headerRow.CreateCell(i);
                cell.SetCellValue(dt.Columns[i].ColumnName);
            }

            // 将DataTable的数据写入工作表中
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                IRow dataRow = worksheet.CreateRow(i + 1);
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    ICell cell = dataRow.CreateCell(j);
                    cell.SetCellValue(dt.Rows[i][j].ToString());
                }
            }


            string Path = "";
            SaveFileDialog s = new SaveFileDialog();
            s.Title = "保存Excel文件";
            s.Filter = "Excel文件(*.xls)|*.xls";
            s.FilterIndex = 1;
            if (s.ShowDialog() == DialogResult.OK)
                Path = s.FileName;
            else
                return;
            ///"C:\Users\10506\Desktop\信息表.xls"
            FileStream file = new FileStream(@Path, FileMode.CreateNew, FileAccess.Write);
            workbook.Write(file);//book写到file
            file.Dispose();

            MessageBox.Show("创建完成", "提示");
        }

        private void CustomerForm_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
          
        }
    }
}
