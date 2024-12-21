using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
	public class PurchaseMaster
	{
		private string purchaseID;
		public string PurchaseID
		{
			get { return purchaseID; }
			set { purchaseID = value; }
		}
	
		private DateTime purchaseDate;
		public DateTime PurchaseDate
		{
			get { return purchaseDate; }
			set { purchaseDate = value; }
		}
	
		private string supplierID;
		public string SupplierName
        {
			get;set;
        }
		public string SupplierID
		{
			get { return supplierID; }
			set { supplierID = value; }
		}
	
		private bool purchaseProperty;
		public bool PurchaseProperty
		{
			get { return purchaseProperty; }
			set { purchaseProperty = value; }
		}
	
		private decimal subTotal;
		public decimal SubTotal
		{
			get { return subTotal; }
			set { subTotal = value; }
		}
		public IList<PurchaseDetail> purchaseDetails { get; set; }
	}
}