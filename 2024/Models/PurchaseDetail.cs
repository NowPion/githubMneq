using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
	public class PurchaseDetail
	{
		private int purchaseDetailID;
		public int PurchaseDetailID
		{
			get { return purchaseDetailID; }
			set { purchaseDetailID = value; }
		}
	
		private string purchaseID;
		public string PurchaseID
		{
			get { return purchaseID; }
			set { purchaseID = value; }
		}
	
		private string productID;
		public string ProductID
		{
			get { return productID; }
			set { productID = value; }
		}

		public string ProductName{ get;set; }


		private decimal purchaseQuantity;
		public decimal PurchaseQuantity
		{
			get { return purchaseQuantity; }
			set { purchaseQuantity = value; }
		}
	
		private decimal purchaseUnitPrice;
		public decimal PurchaseUnitPrice
		{
			get { return purchaseUnitPrice; }
			set { purchaseUnitPrice = value; }
		}
	
		private decimal purchaseAmount;
		public decimal PurchaseAmount
		{
			get { return purchaseAmount; }
			set { purchaseAmount = value; }
		}
	}
}