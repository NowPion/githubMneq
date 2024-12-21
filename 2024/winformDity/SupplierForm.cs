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
    public partial class SupplierForm : Form
    {
        public static int Select_Staut = -1;
        public static int Select_Aing = -1;
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            comboBoxDate();
            SupplierList();
        }

        void comboBoxDate()
        {
            TitleView.Items.Add("女士");
            TitleView.Items.Add("先生");
            TitleView.SelectedIndex = 0;
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
            if (SelectWhere.Text == "") Select_Aing = -1;
            SupplierList();
        }

        private void SupplierGridView_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
            SupplierGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0)
            {
                StringBuilder sb = new StringBuilder();
                int index = 0;
                for (int i = 0; i < selectedRowCount; i++)
                {
                    index = SupplierGridView.SelectedRows[i].Index;
                }
                //MessageBox.Show(SupplierGridView.Rows[index].Cells[0].Value.ToString());
                ScanDateView(new SupplierService().GetBySupplierID(SupplierGridView.Rows[index].Cells[0].Value.ToString()));
            }
        }

        void ScanDateView(Supplier supplier)
        {
            //MessageBox.Show(supplier.SupplierID);
            SupplierIDView.Text = supplier.SupplierID;
            SupplierNameView.Text = supplier.SupplierName;
            SupplierSimpleNameView.Text = supplier.SupplierSimpleName;
            OwnerView.Text = supplier.Owner;
            TitleView.SelectedIndex = supplier.Title == "女士" ? 0:1;
            TelephoneView.Text = supplier.Telephone;
            MobilePhoneView.Text = supplier.MobilePhone;
            FaxView.Text = supplier.Fax;
            CompanyAddressView.Text = supplier.CompanyAddress;
            FactoryAddressView.Text = supplier.FactoryAddress;
            LastDeliveryDateView.Text = supplier.LastDeliveryDate.ToString();

        }

        Supplier PrinDateView()
        {
            Supplier supplierItem = new Supplier();
            supplierItem.SupplierID = SupplierIDView.Text;
            supplierItem.SupplierName = SupplierNameView.Text;
            supplierItem.SupplierSimpleName = SupplierSimpleNameView.Text;
            supplierItem.Owner = OwnerView.Text;
            supplierItem.Title = TitleView.SelectedItem.ToString();
            supplierItem.Telephone = TelephoneView.Text;
            supplierItem.MobilePhone = MobilePhoneView.Text;
            supplierItem.Fax = FaxView.Text;
            supplierItem.CompanyAddress = CompanyAddressView.Text;
            supplierItem.FactoryAddress = FactoryAddressView.Text;
            supplierItem.LastDeliveryDate = Convert.ToDateTime(LastDeliveryDateView.Text);
            return supplierItem;
        }


        private void update_Click(object sender, EventArgs e)
        {
            bool staus = new SupplierService().UpdataSupplier(PrinDateView());
            if (staus)
            {
                MessageBox.Show("操作成功！");
                SupplierList();
            }
            else
            {
                MessageBox.Show("操作失败！");
            }
        }

        private void delect_Click(object sender, EventArgs e)
        {
            bool staus = new SupplierService().DelectSupplier(PrinDateView());
            if (staus)
            {
                MessageBox.Show("操作成功！");
                SupplierList();
            }
            else
            {
                MessageBox.Show("操作失败！");
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            bool staus = new SupplierService().InputSupplier(PrinDateView());
            if (staus)
            {
                MessageBox.Show("操作成功！");
                SupplierList();
            }
            else
            {
                MessageBox.Show("操作失败！");
            }
        }
    }
}
