using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//供应商交易记录实体类
namespace Models
{
    class SupplierBusiReport
    {
        private string supplierID;
        public string SupplierID
        {
            get { return supplierID; }
            set { supplierID = value; }
        }

        private string supplierSimpleName;
        public string SupplierSimpleName
        {
            get { return supplierSimpleName; }
            set { supplierSimpleName = value; }
        }
        private string productName;
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        private decimal quantity;
        public decimal Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        private decimal amount;
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        //以下为实现接口中的方法
        public void setValue(int index, object obj)
        {
            switch (index)
            {
                case 0:
                    supplierID = (string)obj;
                    break;
                case 1:
                    supplierSimpleName = (string)obj;
                    break;
                case 2:
                    productName = (string)obj;
                    break;
                case 3:
                    quantity = (decimal )obj;
                    break;
                case 4:
                    amount = (decimal)obj;
                    break;                
            }
        }
    }
}
