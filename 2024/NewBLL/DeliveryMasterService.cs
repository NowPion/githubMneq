using Models;
using NewDAL.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBLL
{
   public class DeliveryMasterService
    {
        DeliveryMasterDao deliveryMasterDao = new DeliveryMasterDao();
        CusomerDao cusomerDao = new CusomerDao();
        SalesManDao salesManDao = new SalesManDao();
        DeliveryDetailDao deliveryDetailDao = new DeliveryDetailDao();
        public IList<DeliveryMaster> GetDeliveryMasterList(int DeliveryProperty)
        {
            IList<DeliveryMaster> list = deliveryMasterDao.GetDeliveryMasterList(DeliveryProperty);
            foreach (DeliveryMaster delivery in list)
            {
                Customer customer = cusomerDao.GetByCustomerID(delivery.CustomerID);
                SalesMan salesMan = salesManDao.GetBySalesManID(delivery.SalesManID);
                if(customer != null)
                {
                    delivery.CustomerName = customer.CustomerName;
                }
                if(salesMan != null)
                {
                    delivery.salesManName = salesMan.ChineseName;
                }
            }
            return list;
        }
        public DeliveryMaster GetByDeliveryMasterID(string DeliveryID)
        {
            DeliveryMaster delivery = deliveryMasterDao.GetByDeliveryMasterID(DeliveryID);
            Customer customer = cusomerDao.GetByCustomerID(delivery.CustomerID);
            SalesMan salesMan = salesManDao.GetBySalesManID(delivery.SalesManID);
            IList<DeliveryDetail> deliveryDetailList = new DeliveryDetailService().GetDeliveryDetailList(DeliveryID);
            if (customer != null)
            {
                delivery.CustomerName = customer.CustomerName;
            }
            if (salesMan != null)
            {
                delivery.salesManName = salesMan.ChineseName;
            }
            if(deliveryDetailList != null)
            {
                delivery.DeliveryDetail = deliveryDetailList;

            }
            return delivery;
        }
        public bool InputDeliveryMaster(DeliveryMaster deliveryMaster)
        {

            if(deliveryMasterDao.InputDeliveryMaster(deliveryMaster))
            foreach (DeliveryDetail deliveryDetail in deliveryMaster.DeliveryDetail)
            {
                if (!deliveryDetailDao.InputDeliveryDetail(deliveryDetail))
                return false;
                
            }
            else
            {
                return false;
            }
            return true;
            //return deliveryMasterDao.InputDeliveryMaster(deliveryMaster);
        }
        public bool DelectDeliveryMaster(DeliveryMaster deliveryMaster)
        {
            return deliveryMasterDao.DelectDeliveryMaster(deliveryMaster);
        }
        public bool UpdataDeliveryMaster(DeliveryMaster deliveryMaster)
        {
            IList<DeliveryDetail> details = deliveryDetailDao.GetDeliveryDetailList(deliveryMaster.DeliveryID);
            if ((details == null || deliveryDetailDao.DelectDeliveryDetail(deliveryMaster.DeliveryID)) && deliveryMasterDao.UpdataDeliveryMaster(deliveryMaster))
            {
                foreach (DeliveryDetail deliveryDetail in deliveryMaster.DeliveryDetail)
                {
                    if(!deliveryDetailDao.InputDeliveryDetail(deliveryDetail))
                    {
                        return false;
                    }
                }

            }
            else
            {
                return false;
            }

            return true;
            //return deliveryMasterDao.UpdataDeliveryMaster(deliveryMaster);
        }
    }
}
