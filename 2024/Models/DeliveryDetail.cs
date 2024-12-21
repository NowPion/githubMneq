using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
	public class DeliveryDetail
	{
		private int deliverydetailID;
		public int DeliverydetailID
		{
			get { return deliverydetailID; }
			set { deliverydetailID = value; }
		}
	
		private string deliveryID;
		public string DeliveryID
		{
			get { return deliveryID; }
			set { deliveryID = value; }
		}
	
		private string productID;
		public string ProductID
		{
			get { return productID; }
			set { productID = value; }
		}
	    
		public string productName { get; set; }

		private decimal salesQuantity;
		public decimal SalesQuantity
		{
			get { return salesQuantity; }
			set { salesQuantity = value; }
		}
	
		private decimal salesUnitPrice;
		public decimal SalesUnitPrice
		{
			get { return salesUnitPrice; }
			set { salesUnitPrice = value; }
		}
	
		private decimal salesAmount;
		public decimal SalesAmount
		{
			get { return salesAmount; }
			set { salesAmount = value; }
		}
	}
}