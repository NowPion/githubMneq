using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
	public class Supplier
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
	
		private string supplierName;
		public string SupplierName
		{
			get { return supplierName; }
			set { supplierName = value; }
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
	
		private string companyAddress;
		public string CompanyAddress
		{
			get { return companyAddress; }
			set { companyAddress = value; }
		}
	
		private string factoryAddress;
		public string FactoryAddress
		{
			get { return factoryAddress; }
			set { factoryAddress = value; }
		}
        private DateTime lastDeliveryDate;
        public DateTime LastDeliveryDate
        {
            get { return lastDeliveryDate; }
            set { lastDeliveryDate = value; }
        }
	}
}