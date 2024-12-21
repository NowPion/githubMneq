using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//销售主表实体类
namespace Models
{
    public class DeliveryMaster
    {
        private string deliveryID;
        public string DeliveryID
        {
            get { return deliveryID; }
            set { deliveryID = value; }
        }

        private bool deliveryProperty;
        public bool DeliveryProperty
        {
            get { return deliveryProperty; }
            set { deliveryProperty = value; }
        }

        private DateTime deliveryDate;
        public DateTime DeliveryDate
        {
            get { return deliveryDate; }
            set { deliveryDate = value; }
        }

        private string customerID;
        public string CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public string CustomerName { get; set; }

        private string salesManID;
        public string salesManName { get; set; }

        public string SalesManID
        {
            get { return salesManID; }
            set { salesManID = value; }
        }

        private string deliveryAddress;
        public string DeliveryAddress
        {
            get { return deliveryAddress; }
            set { deliveryAddress = value; }
        }

        private decimal subTotal;
        public decimal SubTotal
        {
            get { return subTotal; }
            set { subTotal = value; }
        }


        public IList<DeliveryDetail> DeliveryDetail { get; set; }
    }
}
