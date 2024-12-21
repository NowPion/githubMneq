using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using NewDAL.DaoBeng.NewDAL;

namespace NewDAL.Dao
{
   public class PurchaseDetailDao
    {
        string Sql;
        public IList<PurchaseDetail> GetPurchaseDetailList(string PurchaseID)
        {
            Sql = "Select PurchaseDetailID,PurchaseID,ProductID," +
                "PurchaseQuantity,PurchaseUnitPrice,PurchaseAmount from PurchaseDetail Where PurchaseID=@PurchaseID";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@PurchaseID", PurchaseID);
            return new DB().GetEntities<PurchaseDetail>(Sql, CommandType.Text, param);
    
        }
        public PurchaseDetail GetByPurchaseDetailID(string purchaseDetailID)
        {
            // return productDao.GetByProductID(productID);
            Sql = "Select PurchaseDetailID,PurchaseID,ProductID," +
               "PurchaseQuantity,PurchaseUnitPrice,PurchaseAmount from PurchaseDetail Where PurchaseDetailID=@PurchaseDetailID";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@PurchaseDetailID", purchaseDetailID);
            return new DB().GetEntity<PurchaseDetail>(Sql, CommandType.Text, param);
        }

        public bool InputPurchaseDetail(PurchaseDetail PurchaseDetail)
        {
            Sql = "insert into PurchaseDetail(PurchaseID,ProductID,PurchaseQuantity,PurchaseUnitPrice,PurchaseAmount)" +
                 " values (@PurchaseID,@ProductID,@PurchaseQuantity,@PurchaseUnitPrice,@PurchaseAmount);";
            SqlParameter[] param = new SqlParameter[5];
           // param[0] = new SqlParameter("@PurchaseDetailID", PurchaseDetail.PurchaseDetailID);
            param[0] = new SqlParameter("@PurchaseID", PurchaseDetail.PurchaseID);
            param[1] = new SqlParameter("@ProductID", PurchaseDetail.ProductID);
            param[2] = new SqlParameter("@PurchaseQuantity", PurchaseDetail.PurchaseQuantity);
            param[3] = new SqlParameter("@PurchaseUnitPrice", PurchaseDetail.PurchaseUnitPrice);
            param[4] = new SqlParameter("@PurchaseAmount", PurchaseDetail.PurchaseAmount);

            return new DB().executeSql(Sql, CommandType.Text, param);
        }

        public bool DelectPurchaseDetail(string PurchaseID)
        {
            Sql = "Delete PurchaseDetail where PurchaseID=@PurchaseID";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@PurchaseID", PurchaseID);
            return new DB().executeSql(Sql, CommandType.Text, param);
        }

        public bool UpdataPurchaseDetail(PurchaseDetail PurchaseDetail)
        {
            Sql="UPDATE PurchaseDetail SET PurchaseDetailID=@PurchaseDetailID,PurchaseID=@PurchaseID," +
                "ProductID=@ProductID,PurchaseQuantity=@PurchaseQuantity,PurchaseUnitPrice=@PurchaseUnitPrice,PurchaseAmount=@PurchaseAmount " +
                "Where PurchaseDetailID=@PurchaseDetailID;";
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@PurchaseDetailID", PurchaseDetail.PurchaseDetailID);
            param[1] = new SqlParameter("@PurchaseID", PurchaseDetail.PurchaseID);
            param[2] = new SqlParameter("@ProductID", PurchaseDetail.ProductID);
            param[3] = new SqlParameter("@PurchaseQuantity", PurchaseDetail.PurchaseQuantity);
            param[4] = new SqlParameter("@PurchaseUnitPrice", PurchaseDetail.PurchaseUnitPrice);
            param[5] = new SqlParameter("@PurchaseAmount", PurchaseDetail.PurchaseAmount);

            return new DB().executeSql(Sql, CommandType.Text, param);
        }
    }
}
