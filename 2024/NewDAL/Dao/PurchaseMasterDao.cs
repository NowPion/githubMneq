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
  public  class PurchaseMasterDao
    {
        string Sql;
        public IList<PurchaseMaster> GetPurchaseMasterList(int PurchaseProperty)
        {
            Sql = "Select PurchaseID,PurchaseDate,SupplierID,PurchaseProperty,SubTotal from PurchaseMaster Where PurchaseProperty=@PurchaseProperty";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@PurchaseProperty", PurchaseProperty);
            return new DB().GetEntities<PurchaseMaster>(Sql, CommandType.Text, param);
           // return new DB().GetEntities<PurchaseMaster>(Sql, CommandType.Text, null);
        }
        public PurchaseMaster GetByPurchaseMasterID(string purchaseID)
        {
            Sql= "Select PurchaseID,PurchaseDate,SupplierID,PurchaseProperty,SubTotal " +
                "from PurchaseMaster Where PurchaseID=@PurchaseID";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@PurchaseID", purchaseID);
            return new DB().GetEntity<PurchaseMaster>(Sql, CommandType.Text, param);
        }


        public bool InputPurchaseMaster(PurchaseMaster purchaseMaster)
        {
            Sql = "insert into PurchaseMaster(PurchaseID,PurchaseDate,SupplierID,PurchaseProperty,SubTotal)" +
                 " values (@PurchaseID,@PurchaseDate,@SupplierID,@PurchaseProperty,@SubTotal);";
            SqlParameter[] param = new SqlParameter[5];

            // param[0] = new SqlParameter("@PurchaseDetailID", PurchaseDetail.PurchaseDetailID);
            param[0] = new SqlParameter("@PurchaseID", purchaseMaster.PurchaseID);
            param[1] = new SqlParameter("@PurchaseDate", purchaseMaster.PurchaseDate);
            param[2] = new SqlParameter("@SupplierID", purchaseMaster.SupplierID);
            param[3] = new SqlParameter("@PurchaseProperty", purchaseMaster.PurchaseProperty);
            param[4] = new SqlParameter("@SubTotal", purchaseMaster.SubTotal);

            return new DB().executeSql(Sql, CommandType.Text, param);

         }

        public bool DelectPurchaseMaster(PurchaseMaster purchaseMaster)
        {
            return false;
        }

        public bool UpdataPurchaseMaster(PurchaseMaster purchaseMaster)
        {
            Sql = "UPDATE PurchaseMaster SET PurchaseID=@PurchaseID,PurchaseDate=@PurchaseDate," +
              "SupplierID=@SupplierID,PurchaseProperty=@PurchaseProperty,SubTotal=@SubTotal " +
              "Where PurchaseID=@PurchaseID;";
            SqlParameter[] param = new SqlParameter[5];
            //PurchaseID
            param[0] = new SqlParameter("@PurchaseID", purchaseMaster.PurchaseID);
            param[1] = new SqlParameter("@PurchaseDate", purchaseMaster.PurchaseDate);
            param[2] = new SqlParameter("@SupplierID", purchaseMaster.SupplierID);
            param[3] = new SqlParameter("@PurchaseProperty", purchaseMaster.PurchaseProperty);
            param[4] = new SqlParameter("@SubTotal", purchaseMaster.SubTotal);
            return new DB().executeSql(Sql, CommandType.Text, param);
        }
    }
}
