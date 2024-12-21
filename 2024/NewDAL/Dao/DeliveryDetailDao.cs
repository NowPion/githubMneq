using Models;
using NewDAL.DaoBeng.NewDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDAL.Dao
{
   public class DeliveryDetailDao
    {
        string Sql;
        public IList<DeliveryDetail> GetDeliveryDetailList(string DeliveryID)
        {
            Sql = "Select DeliverydetailID,DeliveryID,ProductID," +
                  "SalesQuantity,SalesUnitPrice,SalesAmount" +
                  "  from DeliveryDetail Where DeliveryID=@DeliveryID";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@DeliveryID", DeliveryID);
            return new DB().GetEntities<DeliveryDetail>(Sql, CommandType.Text, param);

        }
        public DeliveryDetail GetByDeliveryDetailId(int DeliverydetailID)
        {
            // return productDao.GetByProductID(productID);
            Sql = "Select DeliverydetailID,DeliveryID,ProductID," +
                "SalesQuantity,SalesUnitPrice,SalesAmount" +
                "  from DeliveryDetail Where DeliverydetailID=@DeliverydetailID";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@DeliverydetailID", DeliverydetailID);
            return new DB().GetEntity<DeliveryDetail>(Sql, CommandType.Text, param);
        }

        public bool InputDeliveryDetail(DeliveryDetail deliveryDetail)
        {
            Sql = "insert into DeliveryDetail(DeliveryID,ProductID,SalesQuantity,SalesUnitPrice,SalesAmount)" +
                 " values (@DeliveryID,@ProductID,@SalesQuantity,@SalesUnitPrice,@SalesAmount);";
            SqlParameter[] param = new SqlParameter[6];
            // param[0] = new SqlParameter("@PurchaseDetailID", PurchaseDetail.PurchaseDetailID);
            param[0] = new SqlParameter("@DeliverydetailID", deliveryDetail.DeliverydetailID);
            param[1] = new SqlParameter("@DeliveryID", deliveryDetail.DeliveryID);
            param[2] = new SqlParameter("@ProductID", deliveryDetail.ProductID);
            param[3] = new SqlParameter("@SalesQuantity", deliveryDetail.SalesQuantity);
            param[4] = new SqlParameter("@SalesUnitPrice", deliveryDetail.SalesUnitPrice);
            param[5] = new SqlParameter("@SalesAmount", deliveryDetail.SalesAmount);

            return new DB().executeSql(Sql, CommandType.Text, param);
        }

        public bool DelectDeliveryDetail(string DeliveryID)
        {
            Sql = "Delete DeliveryDetail where DeliveryID=@DeliveryID";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@DeliveryID", DeliveryID);
            return new DB().executeSql(Sql, CommandType.Text, param);
        }

        public bool UpdataDeliveryDetail(DeliveryDetail deliveryDetail)
        {
            Sql="UPDATE PurchaseDetail SET " +
                "DeliveryID=@DeliveryID," +
                "ProductID=@ProductID," +
                "SalesQuantity=@SalesQuantity," +
                "SalesUnitPrice=@SalesUnitPrice," +
                "SalesAmount=@SalesAmount" +
                "  Where DeliverydetailID=@DeliverydetailID;";
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@DeliverydetailID", deliveryDetail.DeliverydetailID);
            param[1] = new SqlParameter("@DeliveryID", deliveryDetail.DeliveryID);
            param[2] = new SqlParameter("@ProductID", deliveryDetail.ProductID);
            param[3] = new SqlParameter("@SalesQuantity", deliveryDetail.SalesQuantity);
            param[4] = new SqlParameter("@SalesUnitPrice", deliveryDetail.SalesUnitPrice);
            param[5] = new SqlParameter("@SalesAmount", deliveryDetail.SalesAmount);

            return new DB().executeSql(Sql, CommandType.Text, param);
        }
    }
}
