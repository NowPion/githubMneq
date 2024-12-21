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
    public partial class DeliveryDateOperateForm : Form
    {
        IList<DeliveryDetail> deliveryDetailList = new List<DeliveryDetail>();
        int DeliveryDetailIndex = -1;
        bool DeliveryProperty;
        bool IsNot;
        public DeliveryDateOperateForm(string DeliveryID = null)
        {
            InitializeComponent();
            if (DeliveryID != null)
            {

                IsNot = false;
                //PringSupplier

                DeliveryMaster deliveryMaster = new DeliveryMasterService().GetByDeliveryMasterID(DeliveryID);
                if (deliveryMaster != null)
                {

                    PringDeliveryMaster(deliveryMaster);
                    //DeliveryProperty = deliveryMaster.DeliveryProperty;
                    deliveryDetailList = deliveryMaster.DeliveryDetail;

                    if(deliveryDetailList!=null)
                    foreach (DeliveryDetail delivery in deliveryDetailList)
                    {
                        AddPurDtaiView(delivery, false);
                    }
                    else
                    {
                        deliveryDetailList = new List<DeliveryDetail>();
                    }
                }

                //SubTotal.Text = PurChasSubTotalSum(purchaseDetailsList).ToString();
            }
            else
            {
                IsNot = true;
            }
        }

        void PringDeliveryMaster(DeliveryMaster delivery)
        {
            DeliveryID.Text = delivery.DeliveryID;
            DeliveryDate.Value = delivery.DeliveryDate;
            SalesManID.Text = delivery.SalesManID;
            SalesManName.Text = delivery.salesManName;
            CustomerID.Text = delivery.CustomerID;
            CustomerName.Text = delivery.CustomerName;
            DeliveryAddress.Text = delivery.DeliveryAddress;
        }

        public void AddPurDtaiView(DeliveryDetail deliveryDetail, bool Staue)
        {
            int Index = DeliveryDetailGridView.Rows.Add();
            UpdataGiwPurcharseDetail(deliveryDetail, Index);
            if (Staue)
                deliveryDetailList.Add(deliveryDetail);
        }


        void UpdataGiwPurcharseDetail(DeliveryDetail deliveryDetail, int Index)
        {
            DeliveryDetailGridView.Rows[Index].Cells["ProductID_Lie"].Value = deliveryDetail.ProductID;
            DeliveryDetailGridView.Rows[Index].Cells["ProductName_Lie"].Value = deliveryDetail.productName;
            DeliveryDetailGridView.Rows[Index].Cells["SalesUnitPrice_Lie"].Value = deliveryDetail.SalesUnitPrice;
            DeliveryDetailGridView.Rows[Index].Cells["SalesQuantity_Lie"].Value = deliveryDetail.SalesQuantity;
            DeliveryDetailGridView.Rows[Index].Cells["SalesAmount_Lie"].Value = deliveryDetail.SalesAmount;
            //PurchaseDetailGridView.Rows[Index].Cells["ProductID_Lie"].Value = purchaseDetail.ProductID;
            //PurchaseDetailGridView.Rows[Index].Cells["ProductName_Lie"].Value = purchaseDetail.ProductName;
            //PurchaseDetailGridView.Rows[Index].Cells["PurchaseUnitPrice_Lie"].Value = purchaseDetail.PurchaseUnitPrice;
            //PurchaseDetailGridView.Rows[Index].Cells["PurchaseQuantity_Lie"].Value = purchaseDetail.PurchaseQuantity;
            //PurchaseDetailGridView.Rows[Index].Cells["PurchaseAmount_Lie"].Value = purchaseDetail.PurchaseUnitPrice;
        }

        private void DeliveryAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeliveryDateOperateForm_Load(object sender, EventArgs e)
        {

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
                SalesUnitPrice.Text = product.SuggestBuyPrice.ToString();
                //PurchaseQuantity.Text = product.
            }
        }

        private void InpAddSum_Click(object sender, EventArgs e)
        {
            AddPurDtaiView(PringDeliveryDetail(), true);
            ReatOpen();
            SubTotal.Text = PurChasSubTotalSum(deliveryDetailList).ToString();
            // SubTotal.Text = PurChasSubTotalSum(purchaseDetailsList).ToString();
        }

        DeliveryDetail PringDeliveryDetail()
        {
            DeliveryDetail deliveryDetail = new DeliveryDetail();
            deliveryDetail.ProductID = ProductID.Text;
            deliveryDetail.productName = ProductName.Text;
            deliveryDetail.DeliveryID = DeliveryID.Text;
            deliveryDetail.SalesUnitPrice = Convert.ToDecimal(SalesUnitPrice.Text);
            deliveryDetail.SalesQuantity = Convert.ToDecimal(SalesQuantity.Text);
            deliveryDetail.SalesAmount = Convert.ToDecimal(SalesUnitPrice.Text) * Convert.ToDecimal(SalesQuantity.Text);
            return deliveryDetail;
        }

        DeliveryMaster PringDeliveryMaster()
        {
            DeliveryMaster deliveryMaster = new DeliveryMaster();

            deliveryMaster.DeliveryID = DeliveryID.Text;
            deliveryMaster.DeliveryProperty = true;
            deliveryMaster.DeliveryDate = DeliveryDate.Value;
            deliveryMaster.SalesManID = SalesManID.Text;
            deliveryMaster.CustomerID = CustomerID.Text;
            deliveryMaster.DeliveryAddress = DeliveryAddress.Text;
            deliveryMaster.DeliveryDetail = deliveryDetailList;
            deliveryMaster.DeliveryProperty = DeliveryProperty;
            deliveryMaster.SubTotal = PurChasSubTotalSum(deliveryDetailList);
            return deliveryMaster;
        }
        public decimal PurChasSubTotalSum(IList<DeliveryDetail> deliveryDetailList)
        {
            decimal Sum = 0;
            foreach (DeliveryDetail deliveryDetail in deliveryDetailList)
            {
                Sum += deliveryDetail.SalesAmount;
                //AddPurDtaiView(purchaseDetail, false);
            }
            return Sum;
        }
        void ReatOpen()
        {
            ProductID.Text = "";
            ProductName.Text = "";
            SalesUnitPrice.Text = "";
            SalesQuantity.Text = "";
        }

        private void DeliveryDetailGridView_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
DeliveryDetailGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount > 0)
            {
                int index = 0;
                for (int i = 0; i < selectedRowCount; i++)
                {
                    index = DeliveryDetailGridView.SelectedRows[i].Index;
                }
                DeliveryDetailIndex = index;
                ProductID.Text = DeliveryDetailGridView.Rows[index].Cells["ProductID_Lie"].Value.ToString();
                ProductName.Text = DeliveryDetailGridView.Rows[index].Cells["ProductName_Lie"].Value.ToString();
                SalesUnitPrice.Text = DeliveryDetailGridView.Rows[index].Cells["SalesUnitPrice_Lie"].Value.ToString();
                SalesQuantity.Text = DeliveryDetailGridView.Rows[index].Cells["SalesQuantity_Lie"].Value.ToString();
                //PurchaseDetailGridView.Rows[index].Cells["PurchaseAmount_Lie"].Value;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DeliveryDetailIndex != -1)
            {
                DeliveryDetail Item = PringDeliveryDetail();
                UpdataGiwPurcharseDetail(Item, DeliveryDetailIndex);
                deliveryDetailList[DeliveryDetailIndex] = Item;
                ReatOpen();
                SubTotal.Text = PurChasSubTotalSum(deliveryDetailList).ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (DeliveryDetailIndex != -1)
            {
                DeliveryDetailGridView.Rows.RemoveAt(DeliveryDetailIndex);
                deliveryDetailList.RemoveAt(DeliveryDetailIndex);
                ReatOpen();
                SubTotal.Text = PurChasSubTotalSum(deliveryDetailList).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool staus;
            //staus = new DeliveryMasterService().UpdataDeliveryMaster(PringDeliveryMaster());
            if (IsNot)
            {
                staus = new DeliveryMasterService().InputDeliveryMaster(PringDeliveryMaster());
            }
            else
            {
                staus = new DeliveryMasterService().UpdataDeliveryMaster(PringDeliveryMaster());
            }

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

        private void button6_Click(object sender, EventArgs e)
        {
            new SalesManChooseForm().ShowDialog();
            PringSalesMan(StaticById.SalesManID);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new CustomerChooseFrom().ShowDialog();
            PringCustomer(StaticById.CustomerID);
        }

        void PringSalesMan(string SalesManID)
        {
            SalesMan salesMan = new SalesManService().GetBySalesManID(SalesManID);
            if(salesMan != null)
            {
                this.SalesManID.Text = salesMan.SalesManID;
                this.SalesManName.Text = salesMan.ChineseName;
            }
        }

        void PringCustomer(string CustomerID)
        {
            Customer customer = new CustomerService().GetByCustomerID(CustomerID);
            if(customer != null)
            {
                this.CustomerID.Text = customer.CustomerID;
                this.CustomerName.Text = customer.CustomerName; 
            }
        }

        
    }
}
