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
    public class SalesManDao
    {
        static string Sql;
        public IList<SalesMan> GetSalesManList()
        {
            Sql = "select SalesManID,ChineseName," +
                "EnglishName,TellePhone," +
                "MobilePhone,ContractAddress,Email from SalesMan";
            return new DB().GetEntities<SalesMan>(Sql, CommandType.Text, null);
        }
        public SalesMan GetBySalesManID(string salesManID)
        {

            Sql = "select SalesManID,ChineseName," +
                "EnglishName,TellePhone," +
                "MobilePhone,ContractAddress,Email from SalesMan where SalesManID=@SalesManID";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@SalesManID", salesManID);
            return new DB().GetEntity<SalesMan>(Sql, CommandType.Text, param);
        }

        public bool InputSalesMan(SalesMan salesMan)
        {
            Sql = "insert into SalesMan(SalesManID,ChineseName,EnglishName,TellePhone,MobilePhone,ContractAddress,Email)" +
                  " values (@SalesManID,@ChineseName,@EnglishName,@TellePhone,@MobilePhone,@ContractAddress,@Email);";
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@SalesManID", salesMan.SalesManID);
            param[1] = new SqlParameter("@ChineseName", salesMan.ChineseName);
            param[2] = new SqlParameter("@EnglishName", salesMan.EnglishName);
            param[3] = new SqlParameter("@TellePhone", salesMan.TellePhone);
            param[4] = new SqlParameter("@MobilePhone", salesMan.MobilePhone);
            param[5] = new SqlParameter("@ContractAddress", salesMan.ContractAddress);
            param[6] = new SqlParameter("@Email", salesMan.Email);

            return new DB().executeSql(Sql, CommandType.Text, param);
           // return false;
        }

        public bool DelectSalesMan(SalesMan salesMan)
        {
            Sql = "delete SalesMan where SalesManID=@SalesManID";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@SalesManID", salesMan.SalesManID);
            return new DB().executeSql(Sql, CommandType.Text, param);
        }

        public bool UpdataSalesMan(SalesMan salesMan)
        {

            Sql = "UPDATE SalesMan Set ChineseName=@ChineseName,EnglishName=@EnglishName,TellePhone=@TellePhone," +
                "MobilePhone=@MobilePhone,ContractAddress=@ContractAddress,Email=@Email where SalesManID=@SalesManID";
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@SalesManID", salesMan.SalesManID);
            param[1] = new SqlParameter("@ChineseName", salesMan.ChineseName);
            param[2] = new SqlParameter("@EnglishName", salesMan.EnglishName);
            param[3] = new SqlParameter("@TellePhone", salesMan.TellePhone);
            param[4] = new SqlParameter("@MobilePhone", salesMan.MobilePhone);
            param[5] = new SqlParameter("@ContractAddress", salesMan.ContractAddress);
            param[6] = new SqlParameter("@Email", salesMan.Email);
                
            return new DB().executeSql(Sql, CommandType.Text, param);
            //return false; ;
        }
    }
}
