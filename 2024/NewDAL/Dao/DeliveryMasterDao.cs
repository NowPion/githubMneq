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
   public class DeliveryMasterDao
    {
        string Sql;
        public IList<DeliveryMaster> GetDeliveryMasterList(int DeliveryProperty)
        {
            Sql = "Select  DeliveryID,DeliveryProperty,DeliveryDate," +
                "CustomerID,SalesManID,DeliveryAddress,SubTotal from DeliveryMaster Where DeliveryProperty=@DeliveryProperty";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@DeliveryProperty", DeliveryProperty);
            return new DB().GetEntities<DeliveryMaster>(Sql, CommandType.Text, param);

        }
        public DeliveryMaster GetByDeliveryMasterID(string DeliveryID)
        {
            Sql = "Select  DeliveryID,DeliveryProperty,DeliveryDate," +
                "CustomerID,SalesManID,DeliveryAddress,SubTotal from DeliveryMaster Where DeliveryID=@DeliveryID"; ;
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@DeliveryID", DeliveryID);
            return new DB().GetEntity<DeliveryMaster>(Sql, CommandType.Text, param);
        }


        public bool InputDeliveryMaster(DeliveryMaster deliveryMaster)
        {
            Sql = "insert into DeliveryMaster(DeliveryID,DeliveryProperty,DeliveryDate,CustomerID,SalesManID,DeliveryAddress,SubTotal)" +
                 " values (@DeliveryID,@DeliveryProperty,@DeliveryDate,@CustomerID,@SalesManID,@DeliveryAddress,@SubTotal);";
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@DeliveryID", deliveryMaster.DeliveryID);
            param[1] = new SqlParameter("@DeliveryProperty", deliveryMaster.DeliveryProperty);
            param[2] = new SqlParameter("@DeliveryDate", deliveryMaster.DeliveryDate);
            param[3] = new SqlParameter("@CustomerID", deliveryMaster.CustomerID);
            param[4] = new SqlParameter("@SalesManID", deliveryMaster.SalesManID);
            param[5] = new SqlParameter("@DeliveryAddress", deliveryMaster.DeliveryAddress);
            param[6] = new SqlParameter("@SubTotal", deliveryMaster.SubTotal);
            //// param[0] = new SqlParameter("@PurchaseDetailID", PurchaseDetail.PurchaseDetailID);
            //param[0] = new SqlParameter("@PurchaseID", purchaseMaster.PurchaseID);
            //param[1] = new SqlParameter("@PurchaseDate", purchaseMaster.PurchaseDate);
            //param[2] = new SqlParameter("@SupplierID", purchaseMaster.SupplierID);
            //param[3] = new SqlParameter("@PurchaseProperty", purchaseMaster.PurchaseProperty);
            //param[4] = new SqlParameter("@SubTotal", purchaseMaster.SubTotal);

            return new DB().executeSql(Sql, CommandType.Text, param);

        }

        public bool DelectDeliveryMaster(DeliveryMaster deliveryMaster)
        {
            return false;
        }

        public bool UpdataDeliveryMaster(DeliveryMaster deliveryMaster)
        {
            Sql = "UPDATE DeliveryMaster SET DeliveryID=@DeliveryID," +
                "DeliveryProperty=@DeliveryProperty," +
                "DeliveryDate=@DeliveryDate," +
                "CustomerID=@CustomerID," +
                "SalesManID=@SalesManID," +
                "DeliveryAddress=@DeliveryAddress," +
                "SubTotal=@SubTotal Where DeliveryID=@DeliveryID";

            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@DeliveryID", deliveryMaster.DeliveryID);
            param[1] = new SqlParameter("@DeliveryProperty", deliveryMaster.DeliveryProperty);
            param[2] = new SqlParameter("@DeliveryDate", deliveryMaster.DeliveryDate);
            param[3] = new SqlParameter("@CustomerID", deliveryMaster.CustomerID);
            param[4] = new SqlParameter("@SalesManID", deliveryMaster.SalesManID);
            param[5] = new SqlParameter("@DeliveryAddress", deliveryMaster.DeliveryAddress);
            param[6] = new SqlParameter("@SubTotal", deliveryMaster.SubTotal);

    
            return new DB().executeSql(Sql, CommandType.Text, param);
        }
    }
}
