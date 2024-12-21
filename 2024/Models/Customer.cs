using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
	public class Customer
	{
		private string customerID;
		public string CustomerID
		{
			get { return customerID; }
			set { customerID = value; }
		}
	
		private string customerSimpleName;
		public string CustomerSimpleName
		{
			get { return customerSimpleName; }
			set { customerSimpleName = value; }
		}
	
		private string customerName;
		public string CustomerName
		{
			get { return customerName; }
			set { customerName = value; }
		}
	
		private string owner;
		public string Owner
		{
			get { return owner; }
			set { owner = value; }
		}
	
		private string title;
		public string Title
		{
			get { return title; }
			set { title = value; }
		}
	
		private string telephone;
		public string Telephone
		{
			get { return telephone; }
			set { telephone = value; }
		}
	
		private string mobilePhone;
		public string MobilePhone
		{
			get { return mobilePhone; }
			set { mobilePhone = value; }
		}
	
		private string fax;
		public string Fax
		{
			get { return fax; }
			set { fax = value; }
		}
	
		private string salesManId;
		public string SalesManId
		{
			get { return salesManId; }
			set { salesManId = value; }
		}
		public string SalesManName { get; set; }

		private string customerAddress;
		public string CustomerAddress
		{
			get { return customerAddress; }
			set { customerAddress = value; }
		}
	
		private string deliveryAddress;
		public string DeliveryAddress
		{
			get { return deliveryAddress; }
			set { deliveryAddress = value; }
		}
	
		private string invoiceAddress;
		public string InvoiceAddress
		{
			get { return invoiceAddress; }
			set { invoiceAddress = value; }
		}
        private DateTime lastDeliveryDate;
        public DateTime LastDeliveryDate
        {
            get { return lastDeliveryDate; }
            set { lastDeliveryDate = value; }
        }
	}
}