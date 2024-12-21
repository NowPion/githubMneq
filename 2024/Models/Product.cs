using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
  public  class Product
    {
        private string productID;
        public string ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        private string productName;
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        private int safeStock;
        public int SafeStock
        {
            get { return safeStock; }
            set { safeStock = value; }
        }

        private DateTime lastPurchaseDate;
        public DateTime LastPurchaseDate
        {
            get { return lastPurchaseDate; }
            set { lastPurchaseDate = value; }
        }

        private DateTime lastDeliveryDate;
        public DateTime LastDeliveryDate
        {
            get { return lastDeliveryDate; }
            set { lastDeliveryDate = value; }
        }

        private decimal quantity;
        public decimal Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private decimal suggestBuyPrice;
        public decimal SuggestBuyPrice
        {
            get { return suggestBuyPrice; }
            set { suggestBuyPrice = value; }
        }

        private decimal suggestSalePrice;
        public decimal SuggestSalePrice
        {
            get { return suggestSalePrice; }
            set { suggestSalePrice = value; }
        }

    }
}
