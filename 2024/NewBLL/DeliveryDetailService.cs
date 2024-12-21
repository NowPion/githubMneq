using Models;
using NewDAL.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBLL
{
   public class DeliveryDetailService
    {
        DeliveryDetailDao deliveryDetailDao = new DeliveryDetailDao();
        ProductDao productDao = new ProductDao();
        int DeliveryDetailIndex = -1;
        public IList<DeliveryDetail> GetDeliveryDetailList(string DeliveryID)
        {
            IList<DeliveryDetail> list = deliveryDetailDao.GetDeliveryDetailList(DeliveryID);
            if(list != null)
            foreach (DeliveryDetail detail in list)
            {
                Product product = productDao.GetByProductID(detail.ProductID);
                if(product != null)
                {
                    detail.productName = product.ProductName;
                }
            }
            return list;
        }

        public DeliveryDetail GetByDeliveryDetailId(int DeliverydetailID)
        {
            return deliveryDetailDao.GetByDeliveryDetailId(DeliverydetailID);
        }
        public bool InputDeliveryDetail(DeliveryDetail deliveryDetail)
        {
            return deliveryDetailDao.InputDeliveryDetail(deliveryDetail);
        }

        public bool DelectDeliveryDetail(string DeliveryID)
        {
            return deliveryDetailDao.DelectDeliveryDetail(DeliveryID);
        }
        public bool UpdataDeliveryDetail(DeliveryDetail deliveryDetail)
        {
            return deliveryDetailDao.UpdataDeliveryDetail(deliveryDetail);
        }
    }
}
