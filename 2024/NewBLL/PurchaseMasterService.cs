using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using NewDAL.Dao;

namespace NewBLL
{
    public class PurchaseMasterService
    {
        public PurchaseMasterDao PurchaseMasterDao = new PurchaseMasterDao();
        public PurchaseDetailDao PurchaseDetailDao = new PurchaseDetailDao();
        public SupplierDao SupplierDao = new SupplierDao();
        public IList<PurchaseMaster> GetPurchaseMasterList(int PurchaseProperty)
        {
            IList<PurchaseMaster> mastersList = PurchaseMasterDao.GetPurchaseMasterList(PurchaseProperty);
            for(int Index = 0;Index  < mastersList.Count(); Index++)
            {
                Supplier supplier = SupplierDao.GetBySupplierID(mastersList[Index].SupplierID);
                if (supplier != null)
                {
                    mastersList[Index].SupplierName = supplier.SupplierSimpleName;
                }
            }
            return mastersList;
        }
        public PurchaseMaster GetByPurchaseMasterID(string purchaseID)
        {
            PurchaseMaster purchaseMaster = PurchaseMasterDao.GetByPurchaseMasterID(purchaseID);
            Supplier supplier = SupplierDao.GetBySupplierID(purchaseMaster.SupplierID);
            purchaseMaster.SupplierName = supplier.SupplierSimpleName;
            return purchaseMaster;
        }

        public bool InputPurchaseMaster(PurchaseMaster purchaseMaster)
        {
            if (PurchaseMasterDao.InputPurchaseMaster(purchaseMaster))
            {
                foreach (PurchaseDetail purchaseDetail in purchaseMaster.purchaseDetails)
                {
                    if (!PurchaseDetailDao.InputPurchaseDetail(purchaseDetail))
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
        }

        public bool DelectPurchaseMaster(PurchaseMaster purchaseMaster)
        {
            return PurchaseMasterDao.DelectPurchaseMaster(purchaseMaster);
        }

        public bool UpdataPurchaseMaster(PurchaseMaster purchaseMaster)
        {
            
            if(PurchaseDetailDao.DelectPurchaseDetail(purchaseMaster.PurchaseID) && PurchaseMasterDao.UpdataPurchaseMaster(purchaseMaster))
            {
                foreach (PurchaseDetail purchaseDetail in purchaseMaster.purchaseDetails)
                {
                    PurchaseDetailDao.InputPurchaseDetail(purchaseDetail);
                }


            }
            else
            {

            }
            
            return true;
           //return PurchaseMasterDao.UpdataPurchaseMaster(purchaseMaster);
        }


    }
}
