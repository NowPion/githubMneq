using Models;
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
    public partial class PurchaseDateOperateForm : Form
    {
        PurchaseMaster purchaseMaster = new PurchaseMaster();
        IList<PurchaseDetail> purchaseDetailsList = new List<PurchaseDetail>();
        int PurchaseDetailIndex = -1;
        bool IsNot = true;
        public PurchaseDateOperateForm(string PurchaseID = null, bool PurchaseProperty = true)
        {
            InitializeComponent();
            if (PurchaseID != null)
            {

                IsNot = false;
                //PringSupplier
                PurchaseMaster purchaseMaster = new PurchaseMasterService().GetByPurchaseMasterID(PurchaseID);
                if (purchaseMaster != null)
                {
                    PringSupplier(purchaseMaster.SupplierID);
                    this.PurchaseID.Text = purchaseMaster.PurchaseID;
                    PurchaseDate.Value = purchaseMaster.PurchaseDate;
                }
                purchaseDetailsList = new PurchaseDetailService().GetPurchaseDetailList(PurchaseID);
                foreach (PurchaseDetail purchaseDetail in purchaseDetailsList)
                {
                    AddPurDtaiView(purchaseDetail, false);
                }
                SubTotal.Text = PurChasSubTotalSum(purchaseDetailsList).ToString();
            }
            else
            {
                IsNot = true;
            }
        }
        public decimal PurChasSubTotalSum(IList<PurchaseDetail> purchaseDetails)
        {
            decimal Sum = 0;
            foreach (PurchaseDetail purchaseDetail in purchaseDetails)
            {
                Sum += purchaseDetail.PurchaseUnitPrice;
                //AddPurDtaiView(purchaseDetail, false);
            }
            return Sum;
        }
        private void PurchaseDateOperateForm_Load(object sender, EventArgs e)
        {



        }

        private void button6_Click(object sender, EventArgs e)
        {
            new SupplierChooseForm().ShowDialog();
            PringSupplier(StaticById.SupplierID);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            new ProductChooseForm().ShowDialog();
            PringProduct(StaticById.ProductID);
        }
        public void PringProduct(string productId)
        {
            Product product = new ProductService().GetByProductID(productId);
            if (product != null)
            {
                ProductID.Text = product.ProductID;
                ProductName.Text = product.ProductName;
                PurchaseUnitPrice.Text = product.SuggestBuyPrice.ToString();
                //PurchaseQuantity.Text = product.
            }
        }
        public void PringSupplier(string supplierId)
        {
            Supplier supplier = new SupplierService().GetBySupplierID(supplierId);
            if (supplier != null)
            {
                SupplierID.Text = supplier.SupplierID;
                SupplierSimpleName.Text = supplier.SupplierSimpleName;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount =
         PurchaseDetailGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0)
            {
                int index = 0;
                for (int i = 0; i < selectedRowCount; i++)
                {
                    index = PurchaseDetailGridView.SelectedRows[i].Index;
                }

                ProductID.Text = PurchaseDetailGridView.Rows[index].Cells["ProductID_Lie"].Value.ToString();
                ProductName.Text = PurchaseDetailGridView.Rows[index].Cells["ProductName_Lie"].Value.ToString();
                PurchaseUnitPrice.Text = PurchaseDetailGridView.Rows[index].Cells["PurchaseUnitPrice_Lie"].Value.ToString();
                PurchaseQuantity.Text = PurchaseDetailGridView.Rows[index].Cells["PurchaseQuantity_Lie"].Value.ToString();
                //PurchaseDetailGridView.Rows[index].Cells["PurchaseAmount_Lie"].Value;
            }

        }
        public PurchaseMaster PringPurchaseMaster()
        {
            PurchaseMaster purchaseMaster = new PurchaseMaster();

            purchaseMaster.PurchaseID = PurchaseID.Text;
            purchaseMaster.PurchaseDate = PurchaseDate.Value;
            purchaseMaster.SupplierID = SupplierID.Text;
            purchaseMaster.PurchaseProperty = true;
            purchaseMaster.SubTotal = Convert.ToDecimal(SubTotal.Text);
            purchaseMaster.purchaseDetails = purchaseDetailsList;
            return purchaseMaster;
        }
        public PurchaseDetail PringPurchaseDetail()
        {
            PurchaseDetail purchaseDetail = new PurchaseDetail();
            purchaseDetail.ProductID = ProductID.Text;
            purchaseDetail.PurchaseID = PurchaseID.Text;
            purchaseDetail.ProductName = ProductName.Text;
            purchaseDetail.PurchaseUnitPrice = Convert.ToDecimal(PurchaseUnitPrice.Text);
            purchaseDetail.PurchaseQuantity = Convert.ToDecimal(PurchaseQuantity.Text);

            return purchaseDetail;
        }
        public void ReatOpen()
        {
            ProductID.Text = "";
            ProductName.Text = "";
            PurchaseUnitPrice.Text = "";
            PurchaseQuantity.Text = "";
        }


        private void InpAddSum_Click(object sender, EventArgs e)
        {
            //
            AddPurDtaiView(PringPurchaseDetail(), true);
            ReatOpen();
            SubTotal.Text = PurChasSubTotalSum(purchaseDetailsList).ToString();
        }
        public void AddPurDtaiView(PurchaseDetail purchaseDetail, bool Staue)
        {
            int Index = PurchaseDetailGridView.Rows.Add();
            UpdataGiwPurcharseDetail(purchaseDetail, Index);
            if (Staue)
            purchaseDetailsList.Add(purchaseDetail);
        }

        void UpdataGiwPurcharseDetail(PurchaseDetail purchaseDetail, int Index)
        {
            PurchaseDetailGridView.Rows[Index].Cells["ProductID_Lie"].Value = purchaseDetail.ProductID;
            PurchaseDetailGridView.Rows[Index].Cells["ProductName_Lie"].Value = purchaseDetail.ProductName;
            PurchaseDetailGridView.Rows[Index].Cells["PurchaseUnitPrice_Lie"].Value = purchaseDetail.PurchaseUnitPrice;
            PurchaseDetailGridView.Rows[Index].Cells["PurchaseQuantity_Lie"].Value = purchaseDetail.PurchaseQuantity;
            PurchaseDetailGridView.Rows[Index].Cells["PurchaseAmount_Lie"].Value = purchaseDetail.PurchaseUnitPrice;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //修改 保存采购单和采购单明细

            //text.Text = "";
            //PringPurchaseMaster
            //PurchaseMaster purchase = PringPurchaseMaster();
            //Console.WriteLine(purchase.PurchaseID);
            //foreach(PurchaseDetail purchaseDetail in purchase.purchaseDetails)
            //{
            //    Console.WriteLine(purchase.PurchaseID + " --- " + purchaseDetail.ProductName);
            //}
            bool staus;
            if (IsNot)
            {
                staus = new PurchaseMasterService().InputPurchaseMaster(PringPurchaseMaster());
            }
            else 
                staus = new PurchaseMasterService().UpdataPurchaseMaster(PringPurchaseMaster());
            if (staus)
            {
                MessageBox.Show("操作成功！");
                //SupplierList();
                Close();
            }
            else
            {
                MessageBox.Show("操作失败！");
            }
        }

        private void PurchaseDetailGridView_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
        PurchaseDetailGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0)
            {
                int index = 0;
                for (int i = 0; i < selectedRowCount; i++)
                {
                    index = PurchaseDetailGridView.SelectedRows[i].Index;
                }
                PurchaseDetailIndex = index;
                ProductID.Text = PurchaseDetailGridView.Rows[index].Cells["ProductID_Lie"].Value.ToString();
                ProductName.Text = PurchaseDetailGridView.Rows[index].Cells["ProductName_Lie"].Value.ToString();
                PurchaseUnitPrice.Text = PurchaseDetailGridView.Rows[index].Cells["PurchaseUnitPrice_Lie"].Value.ToString();
                PurchaseQuantity.Text = PurchaseDetailGridView.Rows[index].Cells["PurchaseQuantity_Lie"].Value.ToString();
                //PurchaseDetailGridView.Rows[index].Cells["PurchaseAmount_Lie"].Value;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (PurchaseDetailIndex != -1)
            {
                PurchaseDetail Item = PringPurchaseDetail();
                UpdataGiwPurcharseDetail(Item, PurchaseDetailIndex);
                purchaseDetailsList[PurchaseDetailIndex] = Item;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (PurchaseDetailIndex != -1)
            {
                PurchaseDetailGridView.Rows.RemoveAt(PurchaseDetailIndex);
                purchaseDetailsList.RemoveAt(PurchaseDetailIndex);
            }
        }

        private void PurchaseDetailGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
