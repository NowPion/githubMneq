using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using NewDAL.Dao;

namespace NewBLL
{
   public class PurchaseDetailService
    {
        PurchaseDetailDao PurchaseDetailDao = new PurchaseDetailDao();
        ProductDao ProductDao = new ProductDao();
        public IList<PurchaseDetail> GetPurchaseDetailList(string PurchaseID)
        {
            IList<PurchaseDetail> purchaseDetails = PurchaseDetailDao.GetPurchaseDetailList(PurchaseID);
            for (int Index = 0; Index < purchaseDetails.Count(); Index++)
            {
                Product product = ProductDao.GetByProductID(purchaseDetails[Index].ProductID);
                if (product != null)
                {
                    purchaseDetails[Index].ProductName = product.ProductName;
                }
            }
            return purchaseDetails;
        }
        public PurchaseDetail GetByPurchaseDetailID(string purchaseDetailID)
        {
            return PurchaseDetailDao.GetByPurchaseDetailID(purchaseDetailID);
        }

        public bool InputPurchaseDetail(PurchaseDetail purchaseDetail)
        {
            // return productDao.InputProduct(product);
            return PurchaseDetailDao.InputPurchaseDetail(purchaseDetail);
        }

        //public bool DelectPurchaseDetail(PurchaseDetail purchaseDetail)
        //{
        //    //  return productDao.DelectProduct(product);
        //    return PurchaseDetailDao.DelectPurchaseDetail(purchaseDetail);
        //}

        public bool UpdataPurchaseDetail(PurchaseDetail purchaseDetail)
        {
            //  return productDao.UpdataProduct(product);
            return PurchaseDetailDao.UpdataPurchaseDetail(purchaseDetail);
        }
    }
}
