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
   public class UserDao
    {
        string Sql;
        public User GetUser(string UserName)
        {
            Sql = "select UserId,UserName,UserPwd,DepartmentId from [user] Where UserName=@UserName;";

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@UserName", UserName);
            return new DB().GetEntity<User>(Sql, CommandType.Text, param);

        }
    }
}
