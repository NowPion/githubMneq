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
   public class LoginDao
    {
        string Sql;
        public bool GetLoginDao(string user,string pass)
        {
            Sql = "select COUNT(*) as sum from [User]  where UserName='" +
              user + "' and  UserPwd='" + pass + "'";
            
            int sum  = (int)new DB().GetScalar(Sql);
            if (sum == 1)
            return true;
            return false;
        }
    }
}
